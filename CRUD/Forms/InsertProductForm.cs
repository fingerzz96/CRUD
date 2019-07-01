using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD
{
    public partial class InsertProductForm : Form
    {
        public InsertProductForm() { InitializeComponent(); }

        public new string Name { get; set; }
        public int CategorieId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)
                && ValidateName()
                && ValidateCategorieId()
                && ValidatePrice()
                && ValidateDescription())
            {
                Name = textBoxName.Text;

                try
                {
                    CategorieId = Convert.ToInt32(textBoxCategorieId.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Error of validation of Categories Id number!" + exception.Message);
                    return;
                }

                try
                {
                    Price = Convert.ToDouble(textBoxPrice.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Error of validation of price!" + exception.Message);

                    return;
                }

                Description = textBoxDescription.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateDescription()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderDescription.SetError(textBoxDescription, "Name cannot be null! ");
            } else
            {
                errorProviderDescription.SetError(textBoxDescription, string.Empty);
                return true;
            }

            return false;
        }

        private bool ValidatePrice()
        {
            double price = 0;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderPrice.SetError(textBoxPrice, "Price cannot be null!");
            } else if (double.TryParse(textBoxPrice.Text, out price) == false)
            {
                errorProviderPrice.SetError(textBoxPrice, "Price must be number!");
            } else
            {
                errorProviderPrice.SetError(textBoxPrice, string.Empty);
                return true;
            }


            return false;
        }

        private bool ValidateCategorieId()
        {
            uint id = 0;
            if (string.IsNullOrWhiteSpace(textBoxCategorieId.Text))
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, "Categorie's Id cannot be null!");
            } else if (uint.TryParse(textBoxCategorieId.Text, out id) == false)
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, "Id must be whole number!");
            } else
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, string.Empty);
                return true;
            }

            return false;
        }

        private bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, "Name is cannot be null!");
            } else
            {
                errorProviderName.SetError(textBoxName, string.Empty);
                return true;
            }

            return false;
        }

        private void textBoxName_TextChanged(object sender, CancelEventArgs e) { ValidateName(); }

        private void textBoxCategorieId_TextChanged(object sender, CancelEventArgs e) { ValidateCategorieId(); }

        private void textBoxPrice_TextChanged(object sender, CancelEventArgs e) { ValidateDescription(); }

        private void textBoxDescription_TextChanged(object sender, CancelEventArgs e) { ValidatePrice(); }

        private void buttonCancel_Click(object sender, EventArgs e) { Close(); }
    }
}