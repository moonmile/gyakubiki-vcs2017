using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace wpf399
{
    class MyModel : BindableBase
    {
        private string text;
        private Brush fillColor;

        public string Text
        {
            get { return text; }
            set { this.SetProperty(ref this.text, value); }
        }
        public Brush FillColor
        {
            get { return fillColor; }
            set { this.SetProperty(ref this.fillColor, value); }
        }

        public ICommand ClickRed { get; set; }
        public ICommand ClickBlue { get; set; }
        public ICommand ClickYellow { get; set; }


        private class ClickCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;
            public event Action OnClick;
            public ClickCommand( Action handler ) { OnClick = handler;  }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                if ( OnClick != null)
                {
                    OnClick();
                }
            }
        }

        public MyModel()
        {
            ClickRed = new ClickCommand(() => { Text = "青ボタンをクリック";  FillColor = new SolidColorBrush( Colors.Red); });
            ClickBlue = new ClickCommand(() => { Text = "赤ボタンをクリック"; FillColor = new SolidColorBrush(Colors.Blue); });
            ClickYellow = new ClickCommand(() => { Text = "黄色ボタンをクリック"; FillColor = new SolidColorBrush(Colors.Yellow); });
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

