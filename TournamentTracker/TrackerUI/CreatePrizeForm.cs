using System;
using System.Windows.Forms;
using TrackerLibrary.DataPersistance;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            if (!int.TryParse(placeNumberValue.Text, out int placeNumber))
            {
                return false;
            }

            if (placeNumber < 1)
            {
                return false;
            }

            if(placeNameValue.Text.Length == 0)
            {
                return false;
            }

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out double prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                return false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                return false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                return false;
            }

            return true;
        }
    }
}
