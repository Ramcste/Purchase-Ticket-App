using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketApp
{
    public partial class Form1 : Form
    {
        private int noOfTickets = 0;
        private double unitPrice = 10;
        private string customerName = "";
        private double totalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            noOfTickets = int.Parse(noOfTicketTextBox.Text);
            totalPrice = unitPrice*noOfTickets;
            customerName = customerNameTextBox.Text;

            MessageBox.Show(customerName + ", Please Pay " + totalPrice + " Taka to Purchase " + noOfTickets + " Ticket(s)"); 
         

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Customer Name: " + customerName + "\nUnit Price: " + unitPrice + "\nTotal Price: " + totalPrice);


        }
    }
}
