using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wpf394
{
    class MyModel : BindableBase
    {
        private double height;  // 身長(cm)
        private double weight;  // 体重(kg)
        private double bmi;

        public double Height
        {
            get { return height * 100.0; }
            set
            {
                this.SetProperty(ref this.height, value / 100.0);
                this.BMI = calcBMI();
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                this.SetProperty(ref this.weight, value);
                this.BMI = calcBMI();
            }
        }
        double calcBMI()
        {
            return weight / (height * height);
        }
        public double BMI
        {
            get { return bmi; }
            set { this.SetProperty(ref this.bmi, value); }
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
