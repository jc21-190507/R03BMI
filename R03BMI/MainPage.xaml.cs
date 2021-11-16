using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A01 伊藤凌雅";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String height = heighit.Text;
            String weight = weighit.Text;
            double b= 0;
            double hm = 0;
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);
                if (h > 5)
                {
                    hm = h / 100;
                    b = w / (hm * hm);
                    double bmi = Math.Round(b * 10.0) / 10.0;

                    result.Text = "身長" + h + "cm、体重" + w + "kgの人のBMIは、" + bmi + "です";
                }

                else
                {
                    hm = h;
                    b = w / (hm * hm);
                    double bmi = Math.Round(b * 10.0) / 10.0;

                    result.Text = "身長" + h + "m、体重" + w + "kgの人のBMIは、" + bmi + "です";
                }


            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }
        }
    }
}
