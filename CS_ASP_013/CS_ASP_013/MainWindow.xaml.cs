﻿using System;
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

namespace CS_ASP_013
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            string subDiscription = " Six Inch ";

            double subTotalPrice = 3.50;

            if (footlongRadio.IsChecked == true)
            {

                subDiscription = " Foot Long ";

                subTotalPrice = 5.00; 

            }


            if (wheatbread.IsChecked == true)
            {

                subDiscription = subDiscription + " Wheat Bread ";

            }

            else if (italianbread.IsChecked == true)
            {
                subDiscription = subDiscription + " Italian Bread ";
            }

            else
            {
                subDiscription = subDiscription + " Flat Bread ";

                subTotalPrice = subTotalPrice + .50; 

            }

            if (hammeat.IsChecked == true)
            {
                subDiscription = subDiscription + " Ham, ";
            }

            else if (roastedchicken.IsChecked == true)
            {
                subDiscription = subDiscription + " Roasted Chicken, ";
            }

            else if (meatball.IsChecked == true)
            {

                subDiscription = subDiscription + " Meatball,";

                subTotalPrice = subTotalPrice + 1.00;

            }

            else
            {
                subDiscription = subDiscription + " Steak, ";

                subTotalPrice = subTotalPrice + 1.50;
            }


            if (americanChesse.IsChecked == true)
            {
                subDiscription = subDiscription + " American Cheese, ";

                subTotalPrice = subTotalPrice + .25;
            }

            if (swissChesse.IsChecked == true)
            {
                subDiscription = subDiscription + " Swiss Cheese, ";

                subTotalPrice = subTotalPrice + .30;
            }

            if (pepperjackChesse.IsChecked == true)
            {
                subDiscription = subDiscription + " PepperJack Cheese, ";

                subTotalPrice = subTotalPrice + .75;
            }


            if (cucumber.IsChecked == true) { subDiscription = subDiscription + " Cucumbers, "; }

            if (greenpepper.IsChecked == true)
            {
                subDiscription = subDiscription + " Green Pepper, ";

                subTotalPrice = subTotalPrice + .25;
            }

            if (lettuce.IsChecked == true)
            {
                subDiscription = subDiscription + " Lettuce, ";

                subTotalPrice = subTotalPrice + .15;
            }

            if (redonion.IsChecked == true)
            {
                subDiscription = subDiscription + " Red Onion ";

                subTotalPrice = subTotalPrice + .10;
            }

            if (allveggies.IsChecked == true)
            {
                subDiscription = subDiscription + " Cucumbers, Green Pepper, Lettuce, Red Onion ";

                subTotalPrice = subTotalPrice + .25;
            }

            if ((wheatbread.IsChecked == true) && (meatball.IsChecked == true) &&
                (footlongRadio.IsChecked == true) && (americanChesse.IsChecked == true))
            {
                subDiscription = subDiscription + " Special**$2.00 Off ";

                subTotalPrice = subTotalPrice - 2.00;
            }

            //Print - Sub and Total Price

            subtextBlock.Text = subDiscription + " $ " + subTotalPrice;

        }



      }
   
   }
