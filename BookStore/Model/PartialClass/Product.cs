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
                    img.Source = new BitmapImage(new Uri("/Resources/" + Image, UriKind.Relative));
                }
                else
                {
                    img.Source = new BitmapImage(new Uri("/Resources/picture.png", UriKind.Relative));
                }
                return img.Source;
            }
        }


    }
}
