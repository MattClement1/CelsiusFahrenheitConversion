/*
*Created by: Matthew Clement
*Created on: 26-Oct-2015
*Created for: Unit #4-01
*This program converts Celsius to Fahrenheit.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusFahrenheitConversion
{
    public partial class frmConversion : Form
    {
        public void TempFahrenheit(int tempCelsius)
        {
            //This procedure converts Celsius to Fahrenheit

            //Variable
            double tempFahrenheit;

            tempFahrenheit = (9.0 / 5.0) * tempCelsius + 32;
            this.lblAnswer.Text = Convert.ToString(tempFahrenheit) + "°";
        }

        public frmConversion()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Get the temperature in Celsius and pass it on to the TempFahrenheit procedure.

            //Variable
            int celsius;

            celsius = Convert.ToInt32(this.txtCelsius.Text);

            TempFahrenheit(celsius);

        }
    }
}
