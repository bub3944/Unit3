using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit_3
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private string user;
        private string password;
        private string server;
        private string database;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "BRYSBIGRIG";
            textBox4.Text = "Northwind";
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            database = textBox4.Text;

            if(user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter user name, password, server, and database values");

            }
            if (isValid)
            {
                controller = new Controller("Server = " + server + "\\SQLEXPRESS;" +
                                            "Database = " + database + ";" +
                                            "User Id = " + user + ";" +
                                            "Password = " + password + ";"
                                            );

                MessageBox.Show("Connection information sent");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer count");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string names = controller.getEmployeeNames();
            MessageBox.Show(names, "Employee names");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderCount();
            MessageBox.Show(count, "Order count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = controller.getShipNames();
            MessageBox.Show(names, "Order ship names");
        }
    }
}
