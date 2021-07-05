
namespace MultiThreadingExample
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
            this.btnTimeConsumingWork = new System.Windows.Forms.Button();
            this.btnPrintNumbers = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTimeConsumingWork
            // 
            this.btnTimeConsumingWork.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimeConsumingWork.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeConsumingWork.Location = new System.Drawing.Point(250, 50);
            this.btnTimeConsumingWork.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeConsumingWork.Name = "btnTimeConsumingWork";
            this.btnTimeConsumingWork.Padding = new System.Windows.Forms.Padding(10);
            this.btnTimeConsumingWork.Size = new System.Drawing.Size(300, 50);
            this.btnTimeConsumingWork.TabIndex = 0;
            this.btnTimeConsumingWork.Text = "Do Time Consuming Work";
            this.btnTimeConsumingWork.UseVisualStyleBackColor = false;
            this.btnTimeConsumingWork.Click += new System.EventHandler(this.btnTimeConsumingWork_Click);
            // 
            // btnPrintNumbers
            // 
            this.btnPrintNumbers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintNumbers.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintNumbers.Location = new System.Drawing.Point(250, 125);
            this.btnPrintNumbers.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintNumbers.Name = "btnPrintNumbers";
            this.btnPrintNumbers.Padding = new System.Windows.Forms.Padding(10);
            this.btnPrintNumbers.Size = new System.Drawing.Size(300, 50);
            this.btnPrintNumbers.TabIndex = 1;
            this.btnPrintNumbers.Text = "Print Numbers";
            this.btnPrintNumbers.UseVisualStyleBackColor = false;
            this.btnPrintNumbers.Click += new System.EventHandler(this.btnPrintNumbers_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.ItemHeight = 20;
            this.listBoxNumbers.Location = new System.Drawing.Point(250, 205);
            this.listBoxNumbers.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(300, 204);
            this.listBoxNumbers.TabIndex = 2;
            this.listBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.listBoxNumbers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.btnPrintNumbers);
            this.Controls.Add(this.btnTimeConsumingWork);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeConsumingWork;
        private System.Windows.Forms.Button btnPrintNumbers;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}

