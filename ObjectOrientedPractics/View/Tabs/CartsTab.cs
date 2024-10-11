using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
            CustomersComboBox.Enabled = true;
            ItemsListBox.DataSource = Items;
            CustomersComboBox.DataSource = Customers;
        }

        private Customer CurrentCustomer;
        public List<Item> Items { get; set; }

        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Обновляет данные на странице.
        /// </summary>
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in Items)
            {
                string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                ItemsListBox.Items.Add(_item);
            }
            CustomersComboBox.Items.Clear();
            foreach (Customer item in Customers)
            {
                string _item = ($"{item.Fullname}").ToString();
                CustomersComboBox.Items.Add(_item);
            }
            CartItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Заполняет список товарами из корзины выбранного покупателя.
        /// </summary>
        private void RefreshCartItemsListBox()
        {
            CartItemsListBox.Items.Clear();
            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                CartItemsListBox.Items.Add(_item);
            }
            CartAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Устанавливает выбранного покупателя.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
                RefreshCartItemsListBox();
            }
            else
            {
                CartItemsListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                RefreshCartItemsListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Remove(CurrentCustomer.Cart.Items[CartItemsListBox.SelectedIndex]);
                RefreshCartItemsListBox();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Clear();
                RefreshCartItemsListBox();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1 && CurrentCustomer.Cart.Items.Count != 0)
            {
                Order order = new Order();
                if (CurrentCustomer.IsPriority == true)
                {
                    order = new PriorityOrder(DateTime.Now, "9:00 - 11:00", CurrentCustomer.Address, CurrentCustomer.Cart.Items);
                }
                else
                {
                    order = new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Orders.Add(order);
                CurrentCustomer.Cart.Items.Clear();
                RefreshCartItemsListBox();
            }
        }
    }
}
