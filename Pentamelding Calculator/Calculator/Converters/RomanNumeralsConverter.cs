using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Pentamelding_Calculator.Calculator.Converters
{
    public class RomanNumeralsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is not int integer)
            {
                return DependencyProperty.UnsetValue;
            }

            return " " + ToRoman(integer);

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public static string ToRoman(int number)
        {
            return number switch
            {
                < 1 => string.Empty,
                >= 1000 => "M" + ToRoman(number - 1000),
                >= 900 => "CM" + ToRoman(number - 900),
                >= 500 => "D" + ToRoman(number - 500),
                >= 400 => "CD" + ToRoman(number - 400),
                >= 100 => "C" + ToRoman(number - 100),
                >= 50 => "L" + ToRoman(number - 50),
                >= 10 => "X" + ToRoman(number - 10),
                >= 5 => "V" + ToRoman(number - 5),
                _ => "I" + ToRoman(number - 1)
            }; 
        }
    }
}
