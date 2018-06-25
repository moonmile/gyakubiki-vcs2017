using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf395
{
    class MyModel : BindableBase
    {
        private string text;
        private string first;
        private string second;
        private string last;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                var lst = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (lst.Count() == 0)
                {
                    First = Second = Last = "";
                }
                else if (lst.Count() == 1)
                {
                    First = lst[0];
                    Second = Last = "";
                }
                else if (lst.Count() == 2)
                {
                    First = lst[0];
                    Second = lst[1];
                    Last = lst[1];
                }
                else {
                    First = lst[0];
                    Second = lst[1];
                    Last = lst[lst.Count() - 1];
                }
            }
        }
        public string First
        {
            get { return first; }
            set { this.SetProperty(ref this.first, value); }
        }
        public string Second
        {
            get { return second; }
            set { this.SetProperty(ref this.second, value); }
        }
        public string Last
        {
            get { return last; }
            set { this.SetProperty(ref this.last, value); }
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

