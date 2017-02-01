using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;

namespace WpfCursus
{
    /// <summary>
    /// Interaction logic for ButtonGebruikWindow.xaml
    /// </summary>
    public partial class ButtonGebruikWindow : Window
    {
        public ButtonGebruikWindow()
        {
            InitializeComponent();
        }

        private void ButtonBold_Checked(object sender, RoutedEventArgs e)
        {
            LabelTekst.FontWeight = FontWeights.Bold;
            boldcheckbox.IsChecked = ButtonBold.IsChecked;
        }

        private void ButtonBold_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelTekst.FontWeight = FontWeights.Normal;
            boldcheckbox.IsChecked = ButtonBold.IsChecked;
        }

        private void ButtonItalic_Click(object sender, RoutedEventArgs e)
        {
           

           ToggleButton knop = (ToggleButton)sender;

           // if (knop.IsChecked == null)
            // {
              //  LabelTekst.FontStyle = FontStyles.Italic;
           // }
          //  if (knop.IsChecked == false)
          //  { LabelTekst.FontStyle = FontStyles.Italic;
          //  }
            
             if (knop.IsChecked == true)
            {
               LabelTekst.FontStyle = FontStyles.Italic;
            }
             else if (knop.IsChecked == false)
            {
                LabelTekst.FontStyle = FontStyles.Normal;
            }
            ButtonItalic.IsChecked = knop.IsChecked;
            italiccheckbox.IsChecked = knop.IsChecked;

            // Console.WriteLine(sender.ToString());
            // if (ButtonItalic.IsChecked == true)
            // {
            //    LabelTekst.FontStyle = FontStyles.Italic;
            //    italiccheckbox.IsChecked = ButtonItalic.IsChecked;
            // }
            // else
            // { LabelTekst.FontStyle = FontStyles.Normal;
            //    italiccheckbox.IsChecked = ButtonItalic.IsChecked; 
            //}
                

        }

        private void increasefont_Click(object sender, RoutedEventArgs e)
        {
            if ( LabelTekst.FontSize < 25)
            LabelTekst.FontSize = LabelTekst.FontSize + 1;
        }

        private void decreasefont_Click(object sender, RoutedEventArgs e)
        {
            if (LabelTekst.FontSize > 1)
            LabelTekst.FontSize = LabelTekst.FontSize - 1;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Blue_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Color_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton knop = (RadioButton)sender;
            LabelTekst.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(knop.Content.ToString());
        }





        private void boldcheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            ButtonBold.IsChecked = boldcheckbox.IsChecked;
        }

        private void boldcheckbox_Checked(object sender, RoutedEventArgs e)
        {
            ButtonBold.IsChecked = boldcheckbox.IsChecked;
        }

        private void italiccheckbox_Click(object sender, RoutedEventArgs e)
        {
            ButtonItalic.IsChecked = italiccheckbox.IsChecked;
        }
    }
}
