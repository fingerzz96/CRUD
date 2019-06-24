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
        private readonly ILogger _logger;
        private List<Orders> _adminOrderses;

        private List<Customer> _customers;

        private List<Items> _itemses;

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
                    MessageBox.Show(@"No customers are existing");
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
                    if (listBoxCustomerItemsOrders == null) listBoxCustomerItemsOrders?.Items.Clear();

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

        private Discount ReturnDiscount(DateTime dateTime)
        {
            if (dateTime.Day >= 21 && dateTime.Month >= 3 && dateTime.Month < 6) return new SpringDiscount();

            if (dateTime.Day >= 21 && dateTime.Month >= 6 && dateTime.Month < 9) return new SummerDiscount();

            if (dateTime.Day >= 23 && dateTime.Month >= 9 && dateTime.Month < 12) return new AutumnDiscount();

            if (dateTime.Day >= 21 && dateTime.Month >= 12 && dateTime.Month < 3) return new WinterDiscount();

            return new EmptyDiscount();
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
                    _customers = database.ReturnAllCustomers();
                    _orderses = database.ReturnaAllOrders();
                    _adminOrderses = database.ReturnaAllOrders();
                    _itemses = database.ReturnAllItemsesOrder();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error during selecting products! " + exception.Message);
                }

                ConnectProducts();
                ConnectCustomers();
                ConnectOrders();
                ConnectAdminOrders();
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

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                var newCustomerForm = new FormNewCustomer();

                if (newCustomerForm.ShowDialog(this) == DialogResult.OK)
                    try
                    {
                        database.CreateNewCustomer(newCustomerForm.NameSurname, newCustomerForm.Address);

                        _customers = database.ReturnAllCustomers();
                        ConnectCustomers();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"During inserting the data came unexpected error! " + exception.Message);
                    }
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectOrders();

            var orders = (Orders) listBoxCustomerOrders.SelectedItem;
            if (orders != null)
                ConnectItemOrders(orders.Id);
            else
                ConnectItemOrders(null);
        }

        private void listBoxCustomerOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            var orders = (Orders) listBoxCustomerOrders.SelectedItem;
            if (orders != null) ConnectItemOrders(orders.Id);
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                var customer = (Customer) listBoxCustomers.SelectedItem;
                if (customer == null)
                {
                    MessageBox.Show(@"For creating new order must be created user");
                } else
                {
                    var product = database.ReturnAllProducts();
                    var createNewOrder = new FormCreateNewOrder(product);

                    if (createNewOrder.ShowDialog(this) == DialogResult.OK && customer != null)
                        try
                        {
                            database.CreateOrder(customer.Id);
                            _orderses = database.ReturnaAllOrders();
                            _adminOrderses = database.ReturnaAllOrders();
                            //TODO: Najit zpusob aby nedelal null;
                            var orderId = database.ReturnaAllOrders().LastOrDefault().Id;

                            if (createNewOrder.Itemses != null)
                                foreach (var itemse in createNewOrder.Itemses)
                                    database.CreateOrderItem(itemse, orderId);

                            _itemses = database.ReturnAllItemsesOrder();
                            var currentOrderItems = _itemses.Where(x => x.OrdersId == orderId).ToList();
                            var products = database.ReturnAllProducts();
                            var orders = database.ReturnAllUserOrders(customer.Id);
                            var date = DateTime.Now;
                            var discount = ReturnDiscount(date);

                            var price = discount.ReturnPrice(currentOrderItems, products, orders);
                            database.UpdateOrderTotalPrice(orderId, price);

                            _customers = database.ReturnAllCustomers();
                            ConnectCustomers();
                            ConnectOrders();
                            ConnectProducts();
                            ConnectItemOrders(orderId);
                            ConnectAdminOrders();
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(@"During inserting the data came unexpected error! " + exception.Message);
                        }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var index = listBoxProducts.SelectedIndex;

            if (index >= 0)
            {
                var product = _products[index];
                try
                {
                    database.DeleteProduct(product.Id, product.Name, product.CategoriesId, product.Price,
                        product.Description);
                    _products = database.ReturnAllProducts();
                    ConnectProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"During inserting the data came unexpected error! " + exception.Message);
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            var orders = (Orders) listBoxAdminOrders.SelectedItem;
            database.UpdateOrderStatus(orders.Id, 2);
            _adminOrderses = database.ReturnaAllOrders();
            ConnectAdminOrders();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var orders = (Orders) listBoxAdminOrders.SelectedItem;
            database.UpdateOrderStatus(orders.Id, 3);
            _adminOrderses = database.ReturnaAllOrders();
            ConnectAdminOrders();
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            var orders = (Orders) listBoxAdminOrders.SelectedItem;
            database.UpdateOrderStatus(orders.Id, 4);
            _adminOrderses = database.ReturnaAllOrders();
            ConnectAdminOrders();
        }
    }
}