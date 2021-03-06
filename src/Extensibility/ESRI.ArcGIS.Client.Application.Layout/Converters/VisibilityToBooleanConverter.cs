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
using System.ComponentModel;

namespace ESRI.ArcGIS.Client.Application.Layout.Converters
{
    /// <summary>
    /// Converts a Visibility value to a Boolean.  Returns true if Visible, false if Collapsed.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class VisibilityToBooleanConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Perform the conversion to a Boolean
        /// </summary>
        /// <param name="value">The source Visibility value being passed to the target</param>
        /// <param name="targetType">The <see cref="T:System.Type"/> of data expected by the target dependency property</param>
        /// <param name="parameter">An optional parameter to be used in the converter logic</param>
        /// <param name="culture">The culture of the conversion</param>
        /// <returns>
        /// The Boolean to be passed to the target dependency property
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            if (!Enum.IsDefined(typeof(Visibility), value))
                return false;
            return ((Visibility)value == Visibility.Visible);   
        }

        /// <summary>
        /// Perform the conversion to a Visibility value
        /// </summary>
        /// <param name="value">The source Boolean being passed to the target</param>
        /// <param name="targetType">The <see cref="T:System.Type"/> of data expected by the target dependency property</param>
        /// <param name="parameter">An optional parameter to be used in the converter logic</param>
        /// <param name="culture">The culture of the conversion</param>
        /// <returns>
        /// The Visibility value to be passed to the target dependency property
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;
            bool? visibility = value as bool?;
            return visibility.HasValue && visibility.Value ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion
    }
}
