/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using MeasureTool.Addins.Resources;

namespace MeasureTool.Addins
{
    /// <summary>
    /// Checks the bound value against the type specified by the ConverterParameter and returns a boolean
    /// value based on whether the types match.  Type string must be in the format 
    /// &lt;Assembly&gt;~&lt;Namespace&gt;~&lt;Type&gt;
    /// </summary>
    public class IsTypeConverter : IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value != null && parameter != null &&
                value.GetType() == Utils.GetTypeFromTypeInfoString(parameter.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) 
        {
            throw new InvalidOperationException(Strings.ConverterCannotConvertBack);
        }
    }
}
