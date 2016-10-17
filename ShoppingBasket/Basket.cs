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

        private void Add_Click(object sender, EventArgs e)
        {

            BasketItem bi = new BasketItem(p1.Text, Convert.ToInt32(q1.Text), Convert.ToDouble(p2.Text));
            basket.Items.Add(bi);
            textBox2.Text = basket.Items.Count.ToString();
            //textBox3.Text = BasketItem.total.ToString();
         
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            basket.Items.Remove(basket.SelectedItem);
          
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            BasketItem bi = (BasketItem)basket.SelectedItem;
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        private void ClearBask_Click(object sender, EventArgs e)
        {
            basket.Items.Clear();
            textBox2.Clear();
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

        private void Save_Click(object sender, EventArgs e)
        {
           

            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(save.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(basket.Text);
                    
                }


            }

            //const string sPath = @"C:\Users\Administrator\Desktop\list.txt";

            //const string sPath = @save;

            //System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            //SaveFile.WriteLine(basket.Items);
            //SaveFile.ToString();
            //SaveFile.Close();

            //MessageBox.Show("Programs saved!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void Product_Click(object sender, EventArgs e)
        {

        }





    }
}
