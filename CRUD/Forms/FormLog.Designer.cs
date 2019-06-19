using System.ComponentModel;

namespace CRUD
{
    partial class FormLog
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
            this.buttonCosLogger = new System.Windows.Forms.Button();
            this.buttonFileLogging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCosLogger
            // 
            this.buttonCosLogger.Location = new System.Drawing.Point(12, 48);
            this.buttonCosLogger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCosLogger.Name = "buttonCosLogger";
            this.buttonCosLogger.Size = new System.Drawing.Size(115, 51);
            this.buttonCosLogger.TabIndex = 0;
            this.buttonCosLogger.Text = "Console logging";
            this.buttonCosLogger.UseVisualStyleBackColor = true;
            this.buttonCosLogger.Click += new System.EventHandler(this.buttonCosLogger_Click);
            // 
            // buttonFileLogging
            // 
            this.buttonFileLogging.Location = new System.Drawing.Point(164, 48);
            this.buttonFileLogging.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFileLogging.Name = "buttonFileLogging";
            this.buttonFileLogging.Size = new System.Drawing.Size(107, 50);
            this.buttonFileLogging.TabIndex = 1;
            this.buttonFileLogging.Text = "File logging";
            this.buttonFileLogging.UseVisualStyleBackColor = true;
            this.buttonFileLogging.Click += new System.EventHandler(this.buttonFileLogging_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.buttonFileLogging);
            this.Controls.Add(this.buttonCosLogger);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonCosLogger;
        private System.Windows.Forms.Button buttonFileLogging;
    }
}