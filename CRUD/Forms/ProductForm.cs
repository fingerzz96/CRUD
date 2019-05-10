using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public string Name { get; private set; }
        public int CategorieId { get; private set; }
        public int Price { get; private set; }
        public string Description { get; private set; }

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
                    MessageBox.Show(@"Error of validation of Categories Id number" + exception.Message);
                    return;
                }

                try
                {
                    Price = Convert.ToInt32(textBoxPrice.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Error of validation of price" + exception.Message);

                    return;
                }

                Description = textBoxDescription.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateDescription()
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, "Name cannot be null!");
            }
            else
            {
                errorProviderName.SetError(textBoxName, String.Empty);
            }

            return false;
        }

        private bool ValidatePrice()
        {
            uint price = 0;
            if (Convert.ToInt32(String.IsNullOrWhiteSpace(textBoxName.Text)) == 0)
            {
                errorProviderPrice.SetError(textBoxPrice, "Price cannot be null!");
            }
            else if (uint.TryParse(textBoxPrice.Text, out price) == false)
            {
                errorProviderPrice.SetError(textBoxPrice, "Price must be whole number!");
            }
            else
            {
                errorProviderPrice.SetError(textBoxPrice, String.Empty);
            }


            return false;
        }

        private bool ValidateCategorieId()
        {
            uint id = 0;
            if (Convert.ToInt32(String.IsNullOrWhiteSpace(textBoxCategorieId.Text)) == 0)
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, "Categorie's Id cannot be null!");
            }
            else if (uint.TryParse(textBoxCategorieId.Text, out id) == false)
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, "Id must be whole number!");
            }
            else
            {
                errorProviderCategorieId.SetError(textBoxCategorieId, String.Empty);
            }

            return false;
        }

        private bool ValidateName()
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, "Name is cannot be null!");
            }
            else
            {
                errorProviderName.SetError(textBoxName, String.Empty);
            }

            return false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void textBoxCategorieId_TextChanged(object sender, EventArgs e)
        {
            ValidateCategorieId();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            ValidatePrice();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateDescription();
        }
    }
}