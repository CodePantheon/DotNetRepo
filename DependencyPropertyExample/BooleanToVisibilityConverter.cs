
namespace Org.CodePantheon.CustomButton
{
    using System;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Markup;

    /// <summary>
    /// Value converter for bool to Visibility.
    /// </summary>
    public class BooleanToVisibilityConverter : MarkupExtension, IValueConverter
    {
        /// <summary>
        /// Initializes a new instance of the BoolToVisibilityConverter class.
        /// </summary>
        public BooleanToVisibilityConverter()
        {
            this.TrueValue = Visibility.Visible;
            this.FalseValue = Visibility.Collapsed;
        }

        /// <summary>
        /// Gets or sets the value when visibility is true.
        /// </summary>
        public Visibility TrueValue { get; set; }

        /// <summary>
        /// Gets or sets the value when visibility is false;
        /// </summary>
        public Visibility FalseValue { get; set; }

        /// <summary>
        /// Converts a value
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">They type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A converted value. If the method returns null, the valid null value is used.</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool val = System.Convert.ToBoolean(value, culture);
            return val ? this.TrueValue : this.FalseValue;
        }

        /// <summary>
        /// Converts a value
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>A converted value. If the method returns null, the valid null value is used.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return this.TrueValue.Equals(value) ? true : false;
        }

        /// <summary>
        /// Returns an object that is set as the value of the target property for this markup extension.
        /// </summary>
        /// <param name="serviceProvider">Object that can provide services for the markup extension.</param>
        /// <returns>The object value to set on the property where the extension is applied.</returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
