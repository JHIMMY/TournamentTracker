using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerFormsUI;
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
            var model = new PrizeModel(placeNumberValue.Text,
                                       placeNameValue.Text,
                                       prizeAmountValue.Text,
                                       prizePercentageValue.Text);

            // save
            foreach (var db in GlobalConfig.Connections)
            {
                db.CreatePrize(model);
            }

            // empty form
            placeNumberValue.Text = string.Empty;
            placeNameValue.Text = string.Empty;
            prizeAmountValue.Text = "0";
            prizePercentageValue.Text = "0";
        }
        else
        {
            MessageBox.Show("This form has invalid information. Please check it and try again");
        }
    }

    private bool ValidateForm()
    {
        bool output = true;

        // field 1
        int placeNumber;
        if (int.TryParse(placeNumberValue.Text, out placeNumber) == false)
            output = false;

        if (placeNumber < 1)
            output = false;

        // field 2
        if (string.IsNullOrWhiteSpace(placeNameValue.Text)) // length == 0 (also possible)
            output = false;

        // field 3, 4
        decimal prizeAmount;
        double prizePercentage = 0;

        if (decimal.TryParse(prizeAmountValue.Text, out prizeAmount) == false ||
            double.TryParse(prizePercentageValue.Text, out prizePercentage) == false)
        {
            output = false;
        }

        if (prizeAmount <= 0 && prizePercentage <= 0)
            output = false;

        if (prizePercentage < 0 || prizePercentage > 100)
            output = false;

        return output;
    }
}
