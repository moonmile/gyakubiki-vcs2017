using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf398
{
    class MyItem : BindableBase
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

    class MyModel : BindableBase
    {
        private List<MyItem> items = new List<MyItem>();
        private MyItem selectItem;

        public List<MyItem> Items
        {
            get { return items; }
            set { this.SetProperty(ref this.items, value); }
        }
        public MyItem SelectItem
        {
            get { return selectItem; }
            set { this.SetProperty(ref this.selectItem, value); }
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
