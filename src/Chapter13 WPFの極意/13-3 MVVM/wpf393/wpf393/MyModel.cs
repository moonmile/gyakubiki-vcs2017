using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf393
{
    class MyModel : BindableBase
    {
        private string firstName;
        private string lastName;
        private int age;
        private string description;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.SetProperty(ref this.firstName, value);
                updateDesc();
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                this.SetProperty(ref this.lastName, value);
                updateDesc();
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                this.SetProperty(ref this.age, value);
                updateDesc();
            }
        }
        private void updateDesc()
        {
            // 説明文を更新する
            this.Description =
                string.Format("{0} {1} ({2})", FirstName, LastName, Age);
        }
        public string Description
        {
            get { return description; }
            set { this.SetProperty(ref this.description, value); }
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
