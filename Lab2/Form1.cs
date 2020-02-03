//N5284
//Lab 2
//February 3, 2019
//This program is an example of creating a GUI that calculates the possible tip amount for a given meal amount


//Auto Generated using statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        //Create the Lab2 Form
        public Form1()
        {
            InitializeComponent();
        }

        //When the "Calculate button is pressed do the following"
        private void calculateBtn_Click(object sender, EventArgs e) 
        {
            const double HIGH_END_TIP = .20;    //Constant high end tip amount
            const double MID_END_TIP = .18;     //Constant middle tip amount   
            const double LOW_END_TIP = .15;     //Constant low tip amount

            double mealPrice;   //Temporary variable to hold the meal price amount
            double highEnd;     //Temporary variable to hold the calculated 20% tip
            double midEnd;      //Temporary variable to hold the calculated 18% tip
            double lowEnd;      //Temporary variable to hold the calculated 15% tip

            //Calculate the tip amounts and put them in their assigned temporary variables
            mealPrice = double.Parse(mealPriceTxt.Text);
            highEnd = mealPrice * HIGH_END_TIP;
            midEnd = mealPrice * MID_END_TIP;
            lowEnd = mealPrice * LOW_END_TIP;

            //Output the tip amounts to the text labels
            highEndLbl.Text = $"{highEnd:F2}";
            midEndLbl.Text = $"{midEnd:F2}";
            lowEndLbl.Text = $"{lowEnd:F2}";
        }
    }
}
