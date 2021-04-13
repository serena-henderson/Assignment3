using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        //4-9-20 SH NEW 1L: Create a Queue to store the customers
        Queue<Customer> customerQueue = new Queue<Customer>();

        //4-9-20 SH NEW 1L: Define a path for the to be saved to
        public static string path = @"resturantline.txt";

        public static FileInfo fi;
        
        Stream stream;
        IFormatter formatter = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //4-9-20 SH NEW 2L:Open the program and give the program the ablility to read it
            fi = new FileInfo(path);
            stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

            //4-9-20 SH NEW 4L: deserialize and read the info from the file
            if (new FileInfo(path).Length != 0)
            {
                customerQueue = (Queue<Customer>)formatter.Deserialize(stream);
            }

            //4-9-20 SH NEW 1L: Close the file and stop reading
            stream.Close();

            //4-9-20 SH NEW 1L: Refrsh the GUI to show the correct information
            RefreshForm();
        }

        //4-9-20 SH NEW 6L: save form
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stream = new FileStream(path, FileMode.Open, FileAccess.Write);
            formatter.Serialize(stream, customerQueue);
            stream.Close();
        }

        //4-9-20 SH NEW 4L: call AddCustomer method
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        //4-9-20 SH NEW 13L: remove customer from queue
        private void buttonReady_Click(object sender, EventArgs e)
        {
            Customer readyCustomer = customerQueue.Dequeue();

            foreach (Customer customer in customerQueue)
            {
                customer.Posision--;
            }

            RemoveAlert<string>(readyCustomer.Name);

            RefreshForm();
        }

        //4-9-20 SH NEW 7L: allow enter to call method
        private void inputFood_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCustomer();
            }
        }

        //4-9-20 SH NEW 21L: update form with added or removed customer
        private void RefreshForm()
        {
            labelPosition.Text = (customerQueue.Count + 1).ToString();
            inputName.Text = "";
            inputFood.Text = "";
            labelOutput.Text = "";

            foreach (Customer customer in customerQueue)
            {
                labelOutput.Text += customer.Posision + " - " + customer.Name + " ordered " + customer.Order + "\n";
            }

            if (customerQueue.Count > 0)
            {
                buttonReady.Enabled = true;
            }
            else
            {
                buttonReady.Enabled = false;
            }
        }

        //4-9-20 SH NEW 16L: add customer to queue + call RefreshForm
        private void AddCustomer()
        {
            if (inputName.Text != "" && inputFood.Text != "")
            {
                customerQueue.Enqueue(new Customer
                {
                    Posision = Int32.Parse(labelPosition.Text),
                    Name = inputName.Text.Trim(),
                    Order = inputFood.Text.Trim()
                });

                AddAlert<string>(inputName.Text);

                RefreshForm();
            }
        }

        //4-9-20 SH NEW 4L: alert the user when customer is added
        private void AddAlert<T>(T data)
        {
            MessageBox.Show($"{data} is waiting to be served", "New customer arriving", MessageBoxButtons.OK);
        }

        //4-9-20 SH NEW 4L: alert the user when customer is removed
        private void RemoveAlert<T>(T data)
        {
            MessageBox.Show($"{data}'s order has been served", "Customer leaving", MessageBoxButtons.OK);
        }
    }
}
