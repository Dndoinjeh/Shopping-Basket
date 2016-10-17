namespace ShoppingBasket
{
    partial class ShoppingBasketForm
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
            this.p1 = new System.Windows.Forms.TextBox();
            this.basket = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.q1 = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.ClearBask = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(34, 44);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 20);
            this.p1.TabIndex = 0;
            this.p1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // basket
            // 
            this.basket.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basket.FormattingEnabled = true;
            this.basket.ItemHeight = 16;
            this.basket.Location = new System.Drawing.Point(34, 112);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(399, 244);
            this.basket.TabIndex = 1;
            this.basket.SelectedIndexChanged += new System.EventHandler(this.basket_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(333, 376);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Latest Price";
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(333, 45);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 20);
            this.p2.TabIndex = 9;
            this.p2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.p2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // q1
            // 
            this.q1.Location = new System.Drawing.Point(172, 45);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(120, 20);
            this.q1.TabIndex = 11;
            this.q1.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(467, 42);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(467, 112);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(86, 23);
            this.Remove.TabIndex = 13;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(467, 163);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 23);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ClearBask
            // 
            this.ClearBask.Location = new System.Drawing.Point(467, 214);
            this.ClearBask.Name = "ClearBask";
            this.ClearBask.Size = new System.Drawing.Size(86, 23);
            this.ClearBask.TabIndex = 15;
            this.ClearBask.Text = "Clear Basket";
            this.ClearBask.UseVisualStyleBackColor = true;
            this.ClearBask.Click += new System.EventHandler(this.ClearBask_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(467, 269);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(467, 373);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 23);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item Quantity:";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(31, 87);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(47, 13);
            this.Product.TabIndex = 19;
            this.Product.Text = "Product:";
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Unit Price:";
            // 
            // ShoppingBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 419);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ClearBask);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShoppingBasketForm";
            this.Text = "Shopping Basket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.q1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.ListBox basket;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.NumericUpDown q1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ClearBask;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

