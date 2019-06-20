using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm() { InitializeComponent(); }

        public long Id { get; set; }

        public new string Name { get; set; }

        public int CategorieId { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && ValidateId() && ValidateName()
                && ValidateCategorieId()
                && ValidatePrice()
                && ValidateDescription())
            {
                try
                {
                    Id = Convert.ToInt32(textBoxId.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Error of validation of Categories Id number!" + exception.Message);
                    return;
                }

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
                    Price = Convert.ToInt32(textBoxPrice.Text);
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

        private bool ValidateId()
        {
            uint id = 0;
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                errorProviderId.SetError(textBoxId, "Id cannot be null!");
            } else if (uint.TryParse(textBoxId.Text, out id) == false)
            {
                errorProviderId.SetError(textBoxId, "Id must be whole number!");
            } else
            {
                errorProviderId.SetError(textBoxId, string.Empty);
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

        private bool ValidatePrice()
        {
            uint price = 0;
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderPrice.SetError(textBoxPrice, "Price cannot be null!");
            } else if (uint.TryParse(textBoxPrice.Text, out price) == false)
            {
                errorProviderPrice.SetError(textBoxPrice, "Price must be whole number!");
            } else
            {
                errorProviderPrice.SetError(textBoxPrice, string.Empty);
                return true;
            }


            return false;
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

        private void textBoxId_TextChanged(object sender, EventArgs e) { ValidateId(); }

        private void textBoxName_TextChanged(object sender, EventArgs e) { ValidateName(); }

        private void textBoxCategorieId_TextChanged(object sender, EventArgs e) { ValidateCategorieId(); }

        private void textBoxPrice_TextChanged(object sender, EventArgs e) { ValidatePrice(); }

        private void textBoxDescription_TextChanged(object sender, EventArgs e) { ValidateDescription(); }
        private void button2_Click(object sender, EventArgs e) { Close(); }
    }
}