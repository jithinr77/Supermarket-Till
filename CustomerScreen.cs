using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckOut
{
    public partial class CustomerScreen : Form
    {
        public LoginScreen RefToLoginScreen { get; internal set; }

        public CustomerScreen()
        {
            InitializeComponent();
            fillDataGridView();

        }

        private void backToLoginScreenButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            RefToLoginScreen.Show();
        }

        public void fillDataGridView()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string Database = string.Format("{0}Resources\\database.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            using (var reader = new StreamReader(Database))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var offer = "";

                    ComboBox range = new ComboBox();
                    for (int i = 0; i < 100; i++)
                    {
                        range.Items.Add("B");
                    }

                    if (values[2]=="1")
                    {
                        offer = values[3] + " for £" + values[4];
                    }

                    customerDataGridView.Rows.Add(values[0], values[1], offer,"0");
                }
            }
        }

        private void proceedToCheckoutButton_Click(object sender, EventArgs e)
        {
            var subtotal = 0.0;
            var savings = 0.0;
            for (int i =0;i< customerDataGridView.Rows.Count;i++)
            {
                //If the quantity column has a number that is greater than -1
                if (int.TryParse(customerDataGridView[3, i].Value.ToString(), out var nofferCount) && int.Parse(customerDataGridView[3, i].Value.ToString()) > -1)
                {
                    var quantity = double.Parse(customerDataGridView[3, i].Value.ToString());
                    var price = double.Parse(customerDataGridView[1, i].Value.ToString());
                    //add price to subtotal
                    var subPrice = quantity * price;
                    subtotal+= subPrice;
                    //if there is an offer, add it to savings
                    if (customerDataGridView[2, i].Value.ToString()!="")
                    {                       
                        //var values = customerDataGridView[2, i].Value.ToString().Split(' for £ ');
                        var offers = Regex.Split(customerDataGridView[2, i].Value.ToString(), " for £");
                        if (double.Parse(offers[0]) <= quantity)
                        {
                            var savingCount=Math.Floor(quantity/(double.Parse(offers[0])));
                            Console.WriteLine(savingCount);
                            savings += (savingCount * double.Parse(offers[0]) * price) -(savingCount * double.Parse(offers[1]));
                        }
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The quantity must be a non negative whole number");
                    return;
                }
                
            }

            subtotalLabel.Text = "Subtotal: £"+subtotal.ToString();
            savingsLabel.Text  = "Savings: £" + savings.ToString();
            totalToPayLabel.Text = "Total to Pay: £" + (subtotal - savings).ToString();
        }

        private void finishAndPayButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Thankyou for visiting");
            Application.Restart();
        }
    }
}
