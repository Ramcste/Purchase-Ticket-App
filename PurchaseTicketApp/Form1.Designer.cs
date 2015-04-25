namespace PurchaseTicketApp
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
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noOfTicketTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Location = new System.Drawing.Point(61, 192);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(75, 23);
            this.totalPriceButton.TabIndex = 0;
            this.totalPriceButton.Text = "Total Price";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            this.totalPriceButton.Click += new System.EventHandler(this.totalPriceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. of Tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // noOfTicketTextBox
            // 
            this.noOfTicketTextBox.Location = new System.Drawing.Point(124, 36);
            this.noOfTicketTextBox.Name = "noOfTicketTextBox";
            this.noOfTicketTextBox.Size = new System.Drawing.Size(137, 20);
            this.noOfTicketTextBox.TabIndex = 3;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(124, 85);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(275, 192);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "One ticket 10 Tk.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.noOfTicketTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceButton);
            this.Name = "Form1";
            this.Text = "Purchase Ticket App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button totalPriceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOfTicketTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Label label3;
    }
}

