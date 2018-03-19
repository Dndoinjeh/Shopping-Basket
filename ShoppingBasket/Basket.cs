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

namespace ShoppingBasket
{
    public partial class ShoppingBasketForm : Form
    {
        public ShoppingBasketForm()
        {
            InitializeComponent();
            //Sets No. of items  & total price to 0 from start
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void basket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Adds Users Input to basket & Change Overall Basket price and quantity, Makes sure user is entering valid data
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(p1.Text) || q1.Value == 0 || string.IsNullOrEmpty(p2.Text))
            {
                MessageBox.Show("Please enter a product that has a Name, Quantity and Price!");
            }
            else
            {
                BasketItem bi = new BasketItem(p1.Text, Convert.ToInt32(q1.Text), Convert.ToDouble(p2.Text), ((Convert.ToDouble(q1.Text))*(Convert.ToDouble(q1.Text))));
                basket.Items.Add(bi);
                textBox2.Text = (int.Parse(textBox2.Text) + BasketItem.quant).ToString();
                textBox3.Text = (double.Parse(textBox3.Text) + bi.tPrice).ToString();
            }
        }

        //If item is selected from basket, remove it from list and subtract is price and quantity from total price and No. of items
        private void Remove_Click(object sender, EventArgs e)
        {
            if (basket.SelectedItem != null)
            {
                BasketItem bi = (BasketItem)basket.SelectedItem;
                textBox3.Text = (double.Parse(textBox3.Text) - bi.tPrice).ToString();
                textBox2.Text = (double.Parse(textBox2.Text) - bi.quantity).ToString();
                basket.Items.Remove(basket.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (basket.SelectedItem != null)
            {
                BasketItem bi = (BasketItem)basket.SelectedItem;
                textBox3.Text = (double.Parse(textBox3.Text) - bi.tPrice).ToString();
                textBox2.Text = (double.Parse(textBox2.Text) - bi.quantity).ToString();
                basket.Items.Remove(basket.SelectedItem);
        
                using (var edit = new Edit(bi))
                {
                    var result = edit.ShowDialog();

                    string prod = edit.EditName;            //values preserved after close
                    string quant = edit.EditQuant;
                    string pri = edit.EditPri;

                    //Add new values to basket list
                    BasketItem editReturn = new BasketItem(prod, Convert.ToInt32(quant), Convert.ToDouble(pri), ((Convert.ToDouble(quant)) * (Convert.ToDouble(pri))));
                    basket.Items.Add(editReturn);
                    textBox3.Text = (double.Parse(textBox3.Text) + editReturn.tPrice).ToString();
                    textBox2.Text = (double.Parse(textBox2.Text) + editReturn.quantity).ToString();
                }
            }
            else
            {
                MessageBox.Show("No item selected!");
            }
        }

        //Clears Basket and resets Total price & No. of Items Values
        private void ClearBask_Click(object sender, EventArgs e)
        {
            if (basket.Items.Count == 0)
            {
                MessageBox.Show("Basket is Empty!");
            }
            else
            {
                basket.Items.Clear();
                textBox2.Text = "0";
                textBox3.Text = "0";
            }
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Creates new text file then runs through each item in basket and writes to file.
        private void Save_Click(object sender, EventArgs e)
        {
            if (basket.Items.Count == 0)
            {
                MessageBox.Show("Basket is Empty!");
            }
            else
            {
                string sPath = System.Environment.GetFolderPath(Environment.SpecialFolder.D‌​esktop);
                //Path for my work personal PC as it works on a network
                //const string sPath = @"\\ukdfs.mintecglobal.com\User\Redirect\david.ndoinjeh\Desktop\ShoppingBasket.txt";


                StreamWriter SaveFile = new StreamWriter(sPath);
                SaveFile.WriteLine("Product Name      Quantity   Price   Total Price");
                SaveFile.WriteLine("\n");
                foreach (var item in basket.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.WriteLine("\n");
                SaveFile.WriteLine("Number of items: " + textBox2.Text + "          Total Price: £" + textBox3.Text);

                SaveFile.Close();
                MessageBox.Show("Shopping Basket saved!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Product_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
