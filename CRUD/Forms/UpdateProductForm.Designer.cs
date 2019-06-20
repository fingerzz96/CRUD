using System.ComponentModel;

namespace CRUD
{
    partial class UpdateProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCategorieId = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategorieId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProviderId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategorieId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderCategorieId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(13, 29);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 23);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategorieId
            // 
            this.labelCategorieId.Location = new System.Drawing.Point(13, 115);
            this.labelCategorieId.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelCategorieId.Name = "labelCategorieId";
            this.labelCategorieId.Size = new System.Drawing.Size(100, 23);
            this.labelCategorieId.TabIndex = 2;
            this.labelCategorieId.Text = "CategorieId";
            this.labelCategorieId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(13, 158);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 23);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(121, 29);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(230, 23);
            this.textBoxId.TabIndex = 4;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(121, 69);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 23);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCategorieId
            // 
            this.textBoxCategorieId.Location = new System.Drawing.Point(121, 115);
            this.textBoxCategorieId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCategorieId.Name = "textBoxCategorieId";
            this.textBoxCategorieId.Size = new System.Drawing.Size(230, 23);
            this.textBoxCategorieId.TabIndex = 6;
            this.textBoxCategorieId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCategorieId.TextChanged += new System.EventHandler(this.textBoxCategorieId_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(121, 158);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(230, 23);
            this.textBoxPrice.TabIndex = 7;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(121, 202);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(230, 23);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(13, 201);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 23);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 3, 50, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 258);
            this.button2.Margin = new System.Windows.Forms.Padding(50, 3, 10, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProviderId
            // 
            this.errorProviderId.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderCategorieId
            // 
            this.errorProviderCategorieId.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // errorProviderDescription
            // 
            this.errorProviderDescription.ContainerControl = this;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCategorieId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategorieId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelId);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderCategorieId)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCategorieId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategorieId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProviderId;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderCategorieId;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.ErrorProvider errorProviderDescription;
        private System.Windows.Forms.Label labelPrice;
    }
}