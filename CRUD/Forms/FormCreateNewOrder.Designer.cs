using System.ComponentModel;

namespace CRUD
{
    partial class FormCreateNewOrder
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.listBoxOrderItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            this.numericUpDown1.Location = new System.Drawing.Point(62, 352);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            this.buttonFinish.Location = new System.Drawing.Point(122, 381);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(100, 48);
            this.buttonFinish.TabIndex = 1;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            this.buttonAddItems.Location = new System.Drawing.Point(188, 352);
            this.buttonAddItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItems.TabIndex = 2;
            this.buttonAddItems.Text = "buttonAdd";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            this.listBoxOrderItems.FormattingEnabled = true;
            this.listBoxOrderItems.ItemHeight = 15;
            this.listBoxOrderItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxOrderItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxOrderItems.Name = "listBoxOrderItems";
            this.listBoxOrderItems.Size = new System.Drawing.Size(330, 334);
            this.listBoxOrderItems.TabIndex = 3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 441);
            this.Controls.Add(this.listBoxOrderItems);
            this.Controls.Add(this.buttonAddItems);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCreateNewOrder";
            this.Text = "FormCreateNewOrder";
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonAddItems;
        private System.Windows.Forms.ListBox listBoxOrderItems;
    }
}