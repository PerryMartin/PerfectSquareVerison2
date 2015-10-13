/*
 * Created by: Perry Martin
 * Created on: 13-10-2015
 * Created for: ICS3U
 * Daily Assignment – unit#3-09
 * This program displays a perfect square
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

namespace PerfectSquare
{
    public partial class frmSquare : Form
    {
        public frmSquare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int value = 1;
            int endingValue;
            int squareRootAsInteger;
             int numberOfPerfectSquares = 0;
              double squareRootAsDouble;
            this.lstOfNumbers.Items.Clear();
            

            endingValue = Convert.ToInt32(this.nudNumber.Text);


            while (value <= endingValue)
            {
                squareRootAsDouble = Math.Sqrt(value);
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);


                if (squareRootAsInteger == squareRootAsDouble)
                {
                    numberOfPerfectSquares++;
                    this.lstOfNumbers.Items.Add(value);
                }


                value++;
            }
         }
    }
}

