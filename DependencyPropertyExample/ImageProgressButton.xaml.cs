
namespace Org.CodePantheon.CustomButton
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Interaction logic for ImageProgressButton.xaml
    /// </summary>
    public partial class ImageProgressButton : UserControl
    {
        public ImageProgressButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(
                "Image", 
                typeof(ImageSource), 
                typeof(ImageProgressButton),
                new UIPropertyMetadata(new BitmapImage(new Uri(@"pack://application:,,,/Org.CodePantheon.CustomControls;component/Resources/testImage.png"))));

        public static readonly DependencyProperty ProgressOnProperty =
            DependencyProperty.Register("ProgressOn", typeof(bool), typeof(ImageProgressButton), new UIPropertyMetadata(false));

        public static readonly DependencyProperty ImageOnProperty =
            DependencyProperty.Register("ImageOn", typeof(bool), typeof(ImageProgressButton), new UIPropertyMetadata(false));

        public static readonly DependencyProperty ProgressValueProperty =
            DependencyProperty.Register("ProgressValue", typeof(double), typeof(ImageProgressButton), new UIPropertyMetadata(0.0d));

        public static readonly DependencyProperty ImageProgressButtonCommandProperty =
            DependencyProperty.Register("ImageProgressButtonCommand", typeof(ICommand), typeof(ImageProgressButton));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public bool ProgressOn
        {
            get { return (bool)GetValue(ProgressOnProperty); }
            set { SetValue(ProgressOnProperty, value); }
        }

        public bool ImageOn
        {
            get { return (bool)GetValue(ImageOnProperty); }
            set { SetValue(ImageOnProperty, value); }
        }

        public double ProgressValue
        {
            get { return (double)GetValue(ProgressValueProperty); }
            set { SetValue(ProgressValueProperty, value); }
        }

        public ICommand ImageProgressButtonCommand
        {
            get { return (ICommand)GetValue(ImageProgressButtonCommandProperty); }
            set { SetValue(ImageProgressButtonCommandProperty, value); }
        }
    }
}
