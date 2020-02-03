
namespace Org.CodePantheon.CustomButton
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private Timer timer;

        public MainWindowViewModel()
        {
            this.ButtonClickCommand = new RelayCommand(this.ButtonClickCommandHandler);
            timer = new Timer();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ButtonClickCommand { get; }

        public ImageSource ImagePath { get; set; } =
            new BitmapImage(new Uri(@"pack://application:,,,/Org.CodePantheon.CustomButton;component/Resources/testImage1.png"));

        public bool IsProgressOn { get; set; } = true;

        public double ProgressState { get; set; } = 0.0d;

        public void StartTimer()
        {
            timer.Enabled = true;
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
        }
        public void StopTimer()
        {
            timer.Enabled = false;
            timer.Stop();
            timer.Tick -= new EventHandler(timer1_Tick);
            this.ProgressState = 0.0d;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (this.ProgressState < 100)
            {
                this.ProgressState = this.ProgressState + 20;
            }
            else
            {
                this.ProgressState = 0.0d;
            }
            this.RaisePropertyChanged("ProgressState");

        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.OnPropertyChanged(propertyName);
        }

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners. This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="CallerMemberNameAttribute"/>.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ButtonClickCommandHandler(object parameter)
        {
            if (timer.Enabled)
            {
                this.StopTimer();
                return;
            }

            this.StartTimer();
        }
    }
}
