using Car_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store mystore = new Store();
        BindingSource carInventoryBindSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            //MessageBox.Show(c.ToString());
            mystore.CarList.Add(c);
            carInventoryBindSource.ResetBindings(false);
            txt_make.Text = " ";
            txt_model.Text = " ";
            txt_price.Text = " ";
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            //get the selected item from inventory
            Car selected = (Car) lst_inventory.SelectedItem;
            //add that item to the cart
            mystore.ShoppingList.Add(selected);
            //update the list box control
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = mystore.CheckOut();
            lbl_total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindSource.DataSource = mystore.CarList;

            cartBindingSource.DataSource = mystore.ShoppingList;

            lst_inventory.DataSource = carInventoryBindSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }
    }
}
