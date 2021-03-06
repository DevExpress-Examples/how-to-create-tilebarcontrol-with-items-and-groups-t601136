﻿using System;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace DXSample.Converter {
    public class StringToImageConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return new BitmapImage(new Uri(@"/DXSample;component/Images/"+value.ToString(), UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
