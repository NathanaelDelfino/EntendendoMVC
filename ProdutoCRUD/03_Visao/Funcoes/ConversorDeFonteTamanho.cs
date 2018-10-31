using System;
using System.Globalization;
using System.Windows.Data;

namespace ProdutoCRUD._03_Visao.Funcoes
{
    public class ConversorDeFonteTamanho : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double actualHeight = System.Convert.ToDouble(value);
            int fontSize = (int)(actualHeight * .3);
            return fontSize;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
