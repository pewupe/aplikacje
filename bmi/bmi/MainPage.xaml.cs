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

namespace bmi
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

            int num = Convert.ToInt32(this.Wzrost.Text);
            double a = ((double)Convert.ToInt32(this.Waga.Text)) / (Math.Pow((double)num, 2.0) / 10000.0);
            a = Math.Round(a);
            if (a < 18.5)
            {
                this.box.Text = "Twoje BMI wynosi: " + a.ToString() + " - niedowaga";
            }
            else if (a >= 18.5)
            {
                this.box.Text = "Twoje BMI wynosi: " + a.ToString() + " - waga prawidłowa";
            }
            else if (a >= 25.0)
            {
                this.box.Text = "Twoje BMI wynosi: " + a.ToString() + " - nadwaga";
            }
            else
            {
                this.box.Text = "Twoje BMI wynosi: " + a.ToString() + " - otyłość";
            }
        }
    }
}