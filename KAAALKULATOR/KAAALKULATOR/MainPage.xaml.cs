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

namespace KAAALKULATOR
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

    
        private void wynik_Click(object sender, RoutedEventArgs e)
        {
          
        }

    

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void podziel_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(this.liczba1.Text);
            double a = ((double)Convert.ToInt32(this.liczba1.Text)) / ((double)Convert.ToInt32(this.liczba2.Text));

            {
                this.wynik.Text = a.ToString();
            }
        }

        private void odejmij_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(this.liczba1.Text);
            double a = ((double)Convert.ToInt32(this.liczba1.Text)) - ((double)Convert.ToInt32(this.liczba2.Text));

            {
                this.wynik.Text = a.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(this.liczba1.Text);
            double a = ((double)Convert.ToInt32(this.liczba1.Text)) + ((double)Convert.ToInt32(this.liczba2.Text));

            {
                this.wynik.Text =  a.ToString();
            }
        }

        private void mnoz_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(this.liczba1.Text);
            double a = ((double)Convert.ToInt32(this.liczba1.Text)) * ((double)Convert.ToInt32(this.liczba2.Text));

            {
                this.wynik.Text = a.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        }
        }
        
    
