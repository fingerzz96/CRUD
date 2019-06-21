using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormCreateNewOrder : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        private readonly List<Items> itemses = new List<Items>();

        public FormCreateNewOrder() { InitializeComponent(); }

        public FormCreateNewOrder(List<Product> products)
        {
            InitializeComponent();
            ConnectProducts(products);
        }

        public long Status { get; set; }
        public long TotalPrice { get; set; }
        public long CustomerId { get; set; }
        public Items Items { get; set; }
        public List<Items> Itemses { get; set; }

        public Orders Orders { get; set; }

        private void ConnectProducts(List<Product> products)
        {
            if (bindingSource != null && products != null)
            {
                if (listBoxOrderItems.DataSource == null) listBoxOrderItems.Items.Clear();

                bindingSource.DataSource = products;

                listBoxOrderItems.DataSource = bindingSource;
            }
        }


        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                var product = (Product) listBoxOrderItems.SelectedItem;
                itemses.Add(new Items
                {
                    Count = (long) numericUpDown1.Value,
                    ProductId = product.Id
                });
            }

            Itemses = itemses;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (Itemses != null)
                Orders = new Orders
                {
                    Itemses = Itemses
                };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}