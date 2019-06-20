using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer() { InitializeComponent(); }

        public string NameSurname { get; set; }
        public string Address { get; set; }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NameSurname = textBoxName.Text;
            Address = textBoxAddress.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) { Close(); }
    }
}