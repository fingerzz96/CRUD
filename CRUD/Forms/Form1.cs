using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CRUD.Logger;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private List<Orders> _adminOrderses;

        private List<Customer> _customers;

        private List<Items> _itemses;
        private readonly ILogger _logger;

        private List<Orders> _orderses;

        private List<Product> _products;
        public BindingSource bindingSourceAdminOrders = new BindingSource();
        public BindingSource bindingSourceCustomers = new BindingSource();
        public BindingSource bindingSourceItemsOrders = new BindingSource();
        public BindingSource bindingSourceOrders = new BindingSource();
        public BindingSource bindingSourceProducts = new BindingSource();

        private Database database;

        public Form1(ILogger logger)
        {
            InitializeComponent();
            FormClosing += Form_Closing;
            _logger = logger;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            var form = new FormLog();
            form.Close();
            Application.Exit();
        }


        private void ConnectProducts()
        {
            if (bindingSourceProducts != null && _products != null)
            {
                if (listBoxProducts.DataSource == null) listBoxProducts.Items.Clear();

                bindingSourceProducts.DataSource = _products;
                listBoxProducts.DataSource = bindingSourceProducts;
            }
        }

        private void ConnectCustomers()
        {
            if (bindingSourceCustomers != null && _customers != null)
            {
                if (listBoxCustomers.DataSource == null) listBoxCustomers.Items.Clear();

                bindingSourceCustomers.DataSource = _customers;
                listBoxCustomers.DataSource = bindingSourceCustomers;
            }
        }

        private void ConnectOrders()
        {
            if (bindingSourceOrders != null && _orderses != null)
            {
                if (listBoxCustomerOrders.DataSource == null) listBoxCustomerOrders.Items.Clear();

                var customer = (Customer) listBoxCustomers.SelectedItem;
                if (customer == null)
                {
                    MessageBox.Show("No customers are existing");
                } else
                {
                    _orderses = database.ReturnAllUserOrders(customer.Id);
                    bindingSourceOrders.DataSource = _orderses;
                    listBoxCustomerOrders.DataSource = bindingSourceOrders;
                }
            }
        }

        private void ConnectAdminOrders()
        {
            if (bindingSourceAdminOrders != null && _orderses != null)
            {
                if (listBoxAdminOrders.DataSource == null) listBoxAdminOrders.Items.Clear();

                _adminOrderses = database.ReturnaAllOrders();
                bindingSourceAdminOrders.DataSource = _adminOrderses;
                listBoxAdminOrders.DataSource = bindingSourceAdminOrders;
            }
        }

        private void ConnectItemOrders(long? orderId)
        {
            if (orderId.HasValue)
            {
                if (bindingSourceItemsOrders != null && _itemses != null)
                {
                    if (listBoxCustomerItemsOrders == null) listBoxCustomerItemsOrders.Items.Clear();

                    bindingSourceItemsOrders.DataSource = _itemses.Where(
                        x => x.OrdersId == orderId.Value
                    ).ToList();
                    listBoxCustomerItemsOrders.DataSource = bindingSourceItemsOrders;
                }
            } else
            {
                listBoxCustomerItemsOrders.DataSource = new List<Items>();
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDatabase.ShowDialog() == DialogResult.OK)
            {
                database = new Database(saveFileDialogDatabase.FileName, _logger);

                if (database.IsDatabaseCreated()) File.Delete(saveFileDialogDatabase.FileName);

                database.CreateDatabase();

                _products = new List<Product>();

                ConnectProducts();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDatabase.ShowDialog() == DialogResult.OK)
            {
                database = new Database(openFileDialogDatabase.FileName, _logger);

                if (!database.IsDatabaseCreated()) database.CreateDatabase();

                try
                {
                    _products = database.ReturnAllProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error during selecting products! " + exception.Message);
                }

                ConnectProducts();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                var insertProductForm = new InsertProductForm();

                if (insertProductForm.ShowDialog(this) == DialogResult.OK)
                    try
                    {
                        database.InsertProduct(insertProductForm.Name, insertProductForm.CategorieId,
                            insertProductForm.Price,
                            insertProductForm.Description);
                        _products = database.ReturnAllProducts();
                        ConnectProducts();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"During inserting the data came unexpected error! " + exception.Message);
                    }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                var updateProductForm = new UpdateProductForm();

                if (updateProductForm.ShowDialog(this) == DialogResult.OK)
                    try
                    {
                        database.UpdateProduct(updateProductForm.Id, updateProductForm.Name,
                            updateProductForm.CategorieId, updateProductForm.Price, updateProductForm.Description);
                        _products = database.ReturnAllProducts();
                        ConnectProducts();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"During inserting the data came unexpected error! " + exception.Message);
                    }
            }
        }
    }
}