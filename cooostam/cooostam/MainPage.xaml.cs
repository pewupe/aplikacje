using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace cooostam
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (checkBox1.IsChecked == true && checkBox2.IsChecked == true)
            {
                MessageBox.Show("Brawo");
            }


            if (checkBox1.IsChecked == false && checkBox2.IsChecked == false)
            {
                MessageBox.Show("Do roboty!");
            }
            if (checkBox1.IsChecked == true && checkBox2.IsChecked == false)
            {
                MessageBox.Show("Wyprowadź psa!");
            }
            if (checkBox1.IsChecked == false && checkBox2.IsChecked == true)
            {
                MessageBox.Show("Zrób sprawko!");
            }
            }


        }

    
}

            
   


                



     

