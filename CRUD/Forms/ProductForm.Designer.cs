using System.ComponentModel;

namespace CRUD
{
    partial class ProductForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategorieId = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategorieId = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategorieId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderCategorieId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderDescription)).BeginInit();
            this.SuspendLayout();
            this.labelName.Location = new System.Drawing.Point(13, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelCategorieId.Location = new System.Drawing.Point(13, 69);
            this.labelCategorieId.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelCategorieId.Name = "labelCategorieId";
            this.labelCategorieId.Size = new System.Drawing.Size(100, 23);
            this.labelCategorieId.TabIndex = 1;
            this.labelCategorieId.Text = "CategorieId";
            this.labelPrice.Location = new System.Drawing.Point(13, 115);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 23);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            this.labelDescription.Location = new System.Drawing.Point(13, 155);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 23);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            this.textBoxName.Location = new System.Drawing.Point(120, 27);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 23);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Validating += new CancelEventHandler(this.textBoxName_TextChanged);
            this.textBoxCategorieId.Location = new System.Drawing.Point(120, 69);
            this.textBoxCategorieId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCategorieId.Name = "textBoxCategorieId";
            this.textBoxCategorieId.Size = new System.Drawing.Size(230, 23);
            this.textBoxCategorieId.TabIndex = 5;
            this.textBoxCategorieId.Validating += new CancelEventHandler(this.textBoxCategorieId_TextChanged);
            this.textBoxPrice.Location = new System.Drawing.Point(120, 115);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(229, 23);
            this.textBoxPrice.TabIndex = 6;
            this.textBoxPrice.Validating += new CancelEventHandler(this.textBoxDescription_TextChanged);
            this.textBoxDescription.Location = new System.Drawing.Point(120, 152);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(230, 23);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.Validating += new CancelEventHandler(this.textBoxPrice_TextChanged);
            this.buttonOk.Location = new System.Drawing.Point(19, 198);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(10, 3, 50, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(92, 31);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonCancel.Location = new System.Drawing.Point(251, 198);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(50, 3, 10, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 31);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.errorProviderName.ContainerControl = this;
            this.errorProviderCategorieId.ContainerControl = this;
            this.errorProviderPrice.ContainerControl = this;
            this.errorProviderDescription.ContainerControl = this;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCategorieId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategorieId);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductForm";
            this.Text = "EditorProduct";
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderCategorieId)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorProviderDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategorieId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategorieId;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderCategorieId;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.ErrorProvider errorProviderDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}