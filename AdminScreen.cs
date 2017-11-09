using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheckOut
{
    public partial class AdminScreen : Form
    {
        public LoginScreen RefToLoginScreen { get; internal set; }
        List<string> ProductList;
        List<string> PriceList;
        List<string> OfferList;
        List<string> OfferCountList;
        List<string> OfferPriceList;

        public AdminScreen()
        {
            InitializeComponent();
            //Fill List View
            fillListView();
        }

        //function that removes any items from the list view and refills it with items fromt eh database
        public void fillListView()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string Database = string.Format("{0}Resources\\database.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            productListView.Items.Clear();

            using (var reader = new StreamReader(Database))
            {
                ProductList = new List<string>();
                PriceList = new List<string>();
                OfferList = new List<string>();
                OfferCountList = new List<string>();
                OfferPriceList = new List<string>();

                string[] arr = new string[3];
                ListViewItem itm;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    ProductList.Add(values[0]);
                    arr[0] = values[0];

                    PriceList.Add(values[1]);
                    arr[1] = values[1];

                    OfferList.Add(values[2]);
                    OfferCountList.Add(values[3]);
                    OfferPriceList.Add(values[4]);

                    if (values[2] == "1")
                    {
                        arr[2] = values[3] + " for " + values[4];
                    }

                    itm = new ListViewItem(arr);
                    productListView.Items.Add(itm);
                    arr = new string[3]; //reset arr 
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RefToLoginScreen.Show();
        }//TODO rename this method

        private void button1_Click_1(object sender, EventArgs e)
        {

        }//TODO remove this method

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string Database = string.Format("{0}Resources\\database.csv", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            //ensure product name is valid
            String productName = "";
            if (Regex.IsMatch(productNameTextBox.Text, @"^[a-zA-Z]+$"))
            {
                productName = productNameTextBox.Text;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The product name must contain letters only");
                return;
            }

            //ensure price is valid
            String price = "";
            if (double.TryParse(priceTextBox.Text, out var nprice) && double.Parse(priceTextBox.Text) > 0)
            {
                price = priceTextBox.Text;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The price must be a number");
                return;
            }

            //ensure offerCount is valid
            String offerCount = "";
            if (int.TryParse(offerCountTextBox.Text, out var nofferCount) && int.Parse(offerCountTextBox.Text) > 0)
            {
                offerCount = offerCountTextBox.Text;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The offer count must be a whole number greater than 0");
                return;
            }

            //ensure offerPrice is valid
            String offerPrice = "";
            if (double.TryParse(offerPriceTextBox.Text, out var nofferPrice) && double.Parse(offerPriceTextBox.Text) > 0)
            {
                offerPrice = offerPriceTextBox.Text;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The offer price must be a number greater than 0");
                return;
            }

            //Add product to the database
            if (!ProductList.Contains(productName))
            {
                using (var w = new StreamWriter(Database, append: true))
                {
                    var line = "";
                    if (offerCount == "" || offerPrice == "")
                    {
                        line = string.Format("{0},{1},{2},{3},{4}", productName, price, 0, 0, 0);
                    }
                    else
                    {
                        line = string.Format("{0},{1},{2},{3},{4}", productName, price, 1, offerCount, offerPrice);
                    }
                    w.WriteLine(line);
                    w.Flush();
                }
                fillListView();
                productNameTextBox.Text = "";
                priceTextBox.Text = "";
                offerCountTextBox.Text = "";
                offerPriceTextBox.Text = "";
                System.Windows.Forms.MessageBox.Show("A new product has been added to the database");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Another Product with this name already exists in the database");
            }
        }
    }
}
