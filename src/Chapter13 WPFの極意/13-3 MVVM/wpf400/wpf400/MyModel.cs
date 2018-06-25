using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf400
{
    class Person : BindableBase
    {
        private int id;
        private string name;
        private string addr;
        public int ID
        {
            get { return id; }
            set { this.SetProperty(ref this.id, value); }
        }
        public string Name
        {
            get { return name; }
            set { this.SetProperty(ref this.name, value); }
        }
        public string Addr
        {
            get { return addr; }
            set { this.SetProperty(ref this.addr, value); }
        }
    }
    class Login : BindableBase
    {
        private string id;
        private string pass;
        private string mail;
        public string ID
        {
            get { return id; }
            set { this.SetProperty(ref this.id, value); }
        }
        public string Pass
        {
            get { return pass; }
            set { this.SetProperty(ref this.pass, value); }
        }
        public string Mail
        {
            get { return mail; }
            set { this.SetProperty(ref this.mail, value); }
        }
    }

    class MyModel : BindableBase
    {
        private Person person;
        private Login login ;
        public Person Person
        {
            get { return person; }
            set { this.SetProperty(ref this.person, value); }
        }
        public Login Login
        {
            get { return login; }
            set { this.SetProperty(ref this.login, value); }
        }
    }
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(storage, value)) return false;

            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
