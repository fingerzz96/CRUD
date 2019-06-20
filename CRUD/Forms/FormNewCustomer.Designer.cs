using System.ComponentModel;
using System.Windows.Forms;

namespace CRUD
{
    partial class FormNewCustomer
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(13, 9);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name and Surname";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.Location = new System.Drawing.Point(13, 58);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(126, 23);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(147, 12);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(147, 58);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(285, 23);
            this.textBoxAddress.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(104, 104);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 104);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 42);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 158);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAddress;
    }
}