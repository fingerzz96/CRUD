using System.Windows.Forms;

namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogDatabase = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogDatabase = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listBoxAdminOrders = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.listBoxCustomerItemsOrders = new System.Windows.Forms.ListBox();
            this.listBoxCustomerOrders = new System.Windows.Forms.ListBox();
            this.buttonCreateCustomer = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.connectToolStripMenuItem, this.createToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            this.openFileDialogDatabase.FileName = "openFileDialog1";
            this.openFileDialogDatabase.Filter = "Soubory SQLite|*.sqlite";
            this.saveFileDialogDatabase.FileName = "saveFileDialog1";
            this.saveFileDialogDatabase.Filter = "Soubory SQLite|*.sqlite";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(85, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 495);
            this.tabControl1.TabIndex = 2;
            this.tabPage1.Controls.Add(this.buttonTerminate);
            this.tabPage1.Controls.Add(this.buttonSend);
            this.tabPage1.Controls.Add(this.buttonConfirm);
            this.tabPage1.Controls.Add(this.listBoxAdminOrders);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonUpdate);
            this.tabPage1.Controls.Add(this.buttonCreate);
            this.tabPage1.Controls.Add(this.listBoxProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(925, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.buttonTerminate.Location = new System.Drawing.Point(10, 286);
            this.buttonTerminate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(108, 33);
            this.buttonTerminate.TabIndex = 7;
            this.buttonTerminate.Text = "Terminate";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            this.buttonSend.Location = new System.Drawing.Point(10, 247);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(108, 33);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonConfirm.Location = new System.Drawing.Point(10, 208);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(108, 33);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.listBoxAdminOrders.FormattingEnabled = true;
            this.listBoxAdminOrders.ItemHeight = 15;
            this.listBoxAdminOrders.Location = new System.Drawing.Point(125, 208);
            this.listBoxAdminOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxAdminOrders.Name = "listBoxAdminOrders";
            this.listBoxAdminOrders.Size = new System.Drawing.Size(794, 244);
            this.listBoxAdminOrders.TabIndex = 4;
            this.buttonDelete.Location = new System.Drawing.Point(8, 84);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 33);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonUpdate.Location = new System.Drawing.Point(8, 45);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 33);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            this.buttonCreate.Location = new System.Drawing.Point(8, 6);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(108, 33);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(125, 3);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(794, 199);
            this.listBoxProducts.TabIndex = 0;
            this.tabPage2.Controls.Add(this.buttonNewOrder);
            this.tabPage2.Controls.Add(this.listBoxCustomerItemsOrders);
            this.tabPage2.Controls.Add(this.listBoxCustomerOrders);
            this.tabPage2.Controls.Add(this.buttonCreateCustomer);
            this.tabPage2.Controls.Add(this.labelCustomer);
            this.tabPage2.Controls.Add(this.listBoxCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(925, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Location = new System.Drawing.Point(300, 412);
            this.buttonNewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(244, 47);
            this.buttonNewOrder.TabIndex = 5;
            this.buttonNewOrder.Text = "Create new order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            this.listBoxCustomerItemsOrders.FormattingEnabled = true;
            this.listBoxCustomerItemsOrders.ItemHeight = 15;
            this.listBoxCustomerItemsOrders.Location = new System.Drawing.Point(584, 42);
            this.listBoxCustomerItemsOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxCustomerItemsOrders.Name = "listBoxCustomerItemsOrders";
            this.listBoxCustomerItemsOrders.Size = new System.Drawing.Size(300, 349);
            this.listBoxCustomerItemsOrders.TabIndex = 4;
            this.listBoxCustomerOrders.FormattingEnabled = true;
            this.listBoxCustomerOrders.ItemHeight = 15;
            this.listBoxCustomerOrders.Location = new System.Drawing.Point(276, 42);
            this.listBoxCustomerOrders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxCustomerOrders.Name = "listBoxCustomerOrders";
            this.listBoxCustomerOrders.Size = new System.Drawing.Size(300, 349);
            this.listBoxCustomerOrders.TabIndex = 3;
            this.listBoxCustomerOrders.SelectedIndexChanged +=
                new System.EventHandler(this.listBoxCustomerOrders_SelectedIndexChanged);
            this.buttonCreateCustomer.Location = new System.Drawing.Point(4, 412);
            this.buttonCreateCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateCustomer.Name = "buttonCreateCustomer";
            this.buttonCreateCustomer.Size = new System.Drawing.Size(244, 47);
            this.buttonCreateCustomer.TabIndex = 2;
            this.buttonCreateCustomer.Text = "Create new customer";
            this.buttonCreateCustomer.UseVisualStyleBackColor = true;
            this.buttonCreateCustomer.Click += new System.EventHandler(this.buttonCreateCustomer_Click);
            this.labelCustomer.Location = new System.Drawing.Point(4, 16);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(244, 23);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Customers";
            this.labelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 15;
            this.listBoxCustomers.Location = new System.Drawing.Point(4, 42);
            this.listBoxCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(244, 349);
            this.listBoxCustomers.TabIndex = 0;
            this.listBoxCustomers.SelectedIndexChanged +=
                new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPN - CRUD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogDatabase;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDatabase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBoxAdminOrders;
        private System.Windows.Forms.Button buttonCreateCustomer;
        private System.Windows.Forms.ListBox listBoxCustomerItemsOrders;
        private System.Windows.Forms.ListBox listBoxCustomerOrders;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.TabPage tabPage2;
    }
}