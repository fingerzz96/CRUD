using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Database database;

        private List<Product> _products;
        public BindingSource bindingSource = new BindingSource();


        private void ConnectList()
        {
            if (bindingSource != null && _products != null)
            {
                if (listBoxProducts.DataSource == null)
                {
                    listBoxProducts.Items.Clear();
                }

                bindingSource.DataSource = _products;
                listBoxProducts.DataSource = bindingSource;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDatabase.ShowDialog() == DialogResult.OK)
            {
                database = new Database(saveFileDialogDatabase.FileName);

                if (database.IsDatabaseCreated())
                {
                    File.Delete(saveFileDialogDatabase.FileName);
                }

                database.CreateDatabase();

                _products = new List<Product>();

                ConnectList();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDatabase.ShowDialog()==DialogResult.OK)
            {
                database = new Database(openFileDialogDatabase.FileName);

                if (!database.IsDatabaseCreated())
                {
                    database.CreateDatabase();
                }

                try
                {
                    _products = database.ReturnAllAdminProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error during selecting products! " + exception.Message);
                }
                
                ConnectList();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                ProductForm productForm = new ProductForm();

                if (productForm.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        database.InsertProduct(productForm.Name, productForm.CategorieId, productForm.Price,
                            productForm.Description);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("During inserting the data came unexpected error! " + exception.Message);
                    }
                }
            }
        }
    }
}