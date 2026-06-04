using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calorite1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        
        public Page2()
        {
            this.InitializeComponent();
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage2));
            //TextBox textbox = sender as TextBox;
            String s1 = inputText.Text;
            int h = Int32.Parse(s1);
            //h = h / 100;
            String s3 = textBox6.Text;
            int age = Int32.Parse(s3);
            String s2 = textBox.Text;
            int w = int.Parse(s2);
            double c = 65+((6.2/2.2)*w)+((12.7*2.54)*h)-(6.8* age);
            Parameter.c = (int)c;
            //65 + (6.2/2.2 x weight in kgs) + (12.7 x 2.54 x height in cms) – (6.8 x age in years) 

            UserStatic.gweight = Int32.Parse(textBox.Text);
            UserStatic.height = Int32.Parse(inputText.Text);
            UserStatic.cweight = Int32.Parse(textBox.Text);
            UserStatic.age = Int32.Parse(textBox6.Text);
        }


    }
}
