using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
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

        private Customer _currentCustomer;
        public List<Item> Items { get; set; }
        private double _discount = 0;
        private double _total = 0;

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
            CartDiscountsCheckedListBox.Items.Clear();
            _discount = 0;
            _total = 0;
            CartDiscountAmountLabel.Text = _discount.ToString();
            CartTotalLabel.Text = _total.ToString();
            CartAmountLabel.Text = "0";
        }

        /// <summary>
        /// Заполняет список товарами из корзины выбранного покупателя.
        /// </summary>
        private void RefreshCartItemsListBox()
        {
            CartItemsListBox.Items.Clear();
            foreach (Item item in _currentCustomer.Cart.Items)
            {
                string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                CartItemsListBox.Items.Add(_item);
            }
            CartAmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            RefreshCartDiscountsCheckedListBox();
        }

        /// <summary>
        /// Заполняет список скидками выбранного покупателя.
        /// </summary>
        private void RefreshCartDiscountsCheckedListBox()
        {
            _discount = 0;
            CartDiscountsCheckedListBox.Items.Clear();
            foreach (IDiscount item in _currentCustomer.Discounts)
            {
                CartDiscountsCheckedListBox.Items.Add(item.Info);
                CartDiscountsCheckedListBox.SetItemChecked(_currentCustomer.Discounts.IndexOf(item), true);
            }
        }

        /// <summary>
        /// Устанавливает выбранного покупателя.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                RefreshCartItemsListBox();
                RefreshCartDiscountsCheckedListBox();
            }
            else
            {
                CartItemsListBox.Items.Clear();
                CartDiscountsCheckedListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                RefreshCartItemsListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Remove(_currentCustomer.Cart.Items[CartItemsListBox.SelectedIndex]);
                RefreshCartItemsListBox();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Clear();
                RefreshCartItemsListBox();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1 && _currentCustomer.Cart.Items.Count != 0)
            {
                Order order = new Order();
                if (_currentCustomer.IsPriority == true)
                {
                    order = new PriorityOrder(DateTime.Now, "9:00 - 11:00", _currentCustomer.Address, _currentCustomer.Cart.Items);
                }
                else
                {
                    order = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items);
                }
                order.DiscountAmount = _discount;
                foreach (int index in CartDiscountsCheckedListBox.CheckedIndices)
                {
                    _currentCustomer.Discounts[index].Apply(order.Items);
                }
                foreach (IDiscount item in _currentCustomer.Discounts)
                {
                    item.Update(order.Items);
                }
                _currentCustomer.Orders.Add(order);
                _currentCustomer.Cart.Items.Clear();
                RefreshCartItemsListBox();
                _discount = 0;
                _total = 0;
                CartDiscountAmountLabel.Text = _discount.ToString();
                CartTotalLabel.Text = _total.ToString();
            }
        }

        private void CartDiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _discount += _currentCustomer.Discounts[e.Index].Calculate(_currentCustomer.Cart.Items);
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                _discount -= _currentCustomer.Discounts[e.Index].Calculate(_currentCustomer.Cart.Items);
            }
            _total = _currentCustomer.Cart.Amount - _discount;
            CartDiscountAmountLabel.Text = _discount.ToString();
            CartTotalLabel.Text = _total.ToString();
        }

        private void CreateCloneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cart cloneCart = (Cart)_currentCustomer.Cart.Clone();
                Order order = new Order();
                if (_currentCustomer.IsPriority == true)
                {
                    order = new PriorityOrder(DateTime.Now, "9:00 - 11:00", _currentCustomer.Address, _currentCustomer.Cart.Items);
                }
                else
                {
                    order = new Order(_currentCustomer.Address, cloneCart.Items);
                }
                order.DiscountAmount = _discount;
                foreach (int index in CartDiscountsCheckedListBox.CheckedIndices)
                {
                    _currentCustomer.Discounts[index].Apply(order.Items);
                }
                foreach (IDiscount item in _currentCustomer.Discounts)
                {
                    item.Update(order.Items);
                }
                _currentCustomer.Orders.Add(order);
            }
            catch { }
        }
    }
}
