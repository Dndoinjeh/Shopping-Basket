using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingBasket
{
    public partial class Edit : Form
    {
        public string EditName { get; set; }
        public string EditQuant { get; set; }
        public string EditPri { get; set; }

        public Edit(BasketItem itemtoedit)
        {
            InitializeComponent();
            textBox2.Text = itemtoedit.product;
            num1.Text = itemtoedit.quantity.ToString();
            textBox3.Text = itemtoedit.price.ToString();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || num1.Value == 0 || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter a product that has a Name, Quantity and Price!");
            }
            else
            {
                //gets values from edit form and stores them
                this.EditName = this.textBox2.Text;
                this.EditQuant = this.num1.Value.ToString();
                this.EditPri = this.textBox3.Text;
                this.Close();
            }
        }
    }
}
