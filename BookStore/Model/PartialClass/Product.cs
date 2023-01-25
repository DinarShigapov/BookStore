using BookStore.Properties;
using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BookStore.Model
{
    public partial class Product
    {
        public ImageSource MainImage
        {
            get 
            {
                Image img = new Image();
                if (Image != null)
                {
                    img.Source = new BitmapImage(new Uri("/Resources/Material/" + Image, UriKind.Relative));
                }
                else
                {
                    img.Source = new BitmapImage(new Uri("/Resources/DefaultImages/picture.png", UriKind.Relative));
                }
                return img.Source;
            }
        }

        public string StrDiscount
        {
            get 
            {
                return $"{Discount * 100}%";
            }
        }
        
        public string BGDiscount
        {
            get 
            {
                if (Discount > 0.05)
                    return "#7fff00";
                else
                    return $"{default(Color)}";
            }
        }

        public decimal DiscountPrice
        {
            get
            {
                if (Discount == 0)
                    return Math.Round(Price, 2);
                else
                    return Math.Round((decimal)Price - Convert.ToDecimal(Price) * Convert.ToDecimal(Discount), 2);

            }
        }

        public TextDecorationCollection TDPrice
        {
            get 
            {
                if (Discount == 0)
                    return default;
                else
                    return TextDecorations.Strikethrough;
            }
        }

        public Visibility VDiscountPrice
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }




    }
}
