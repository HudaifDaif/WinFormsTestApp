﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNumberText.Text,
                                                  placeNameText.Text,
                                                  prizeAmountText.Text,
                                                  prizePercentageText.Text);

            }
        }

        private bool ValidateForm()
        {
            bool output = true;


            int placeNumber;
            bool validPlaceNumber = int.TryParse(placeNameText.Text, out placeNumber);

            if (!validPlaceNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (placeNumber == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            bool validPrizeAmount = decimal.TryParse(prizeAmountText.Text, out prizeAmount);

            double prizePercentage = 0;
            bool validPrizePercentage = double.TryParse(prizePercentageText.Text, out prizePercentage);

            if (!validPrizePercentage || !validPrizePercentage)
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;

            }

            return output;
        }
    }
}
