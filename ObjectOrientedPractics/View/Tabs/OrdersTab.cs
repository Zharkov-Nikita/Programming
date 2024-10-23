using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
            OrderStatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus)); //Заполнение Combobox статусами заказов.
        }

        private PriorityOrder _currentPriorityOrder; //Текущий приоритетный заказ.
        private Order _currentOrder = new Order(); //Текущий заказ.
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        /// <summary>
        /// Обновляет данные на странице.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет списки заказов.
        /// </summary>
        private void UpdateOrders()
        {
            OrdersDataGridView.Rows.Clear();
            Orders.Clear();
            foreach (Customer customer in Customers)
            {
                foreach (Order order in customer.Orders)
                {
                    Orders.Add(order);
                    int index = Orders.Count - 1;
                    OrdersDataGridView.Rows.Add();
                    OrdersDataGridView[0, index].Value = order.Id;
                    OrdersDataGridView[1, index].Value = order.CreateDate;
                    OrdersDataGridView[2, index].Value = order.Status;
                    OrdersDataGridView[3, index].Value = customer.Fullname;
                    OrdersDataGridView[4, index].Value = $"{customer.Address.City}, улица {customer.Address.Street}, дом {customer.Address.Building}, кв. {customer.Address.Apartment}";
                    OrdersDataGridView[5, index].Value = order.Amount;
                    OrdersDataGridView[6, index].Value = order.Total;
                }
            }
        }

        int currentRow;
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            currentRow = OrdersDataGridView.CurrentCell.RowIndex;

            if (currentRow != -1)
            {
                _currentOrder = Orders[currentRow];
                if (_currentOrder.GetType() == typeof(PriorityOrder))
                {
                    _currentPriorityOrder = (PriorityOrder)_currentOrder;
                    OrderDeliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DesiredTime;
                    PriorityOrderPanel.Visible = true;
                }
                else
                {
                    _currentPriorityOrder = null;
                    PriorityOrderPanel.Visible = false;
                }
                OrderIdTextBox.Text = _currentOrder.Id.ToString();
                OrderCreatedTextBox.Text = _currentOrder.CreateDate.ToString();
                OrderStatusComboBox.SelectedIndex = Convert.ToInt32(_currentOrder.Status);
                OrderAddressControl.Address = _currentOrder.Address;
                OrderAddressControl.ShowAddress();
                OrderItemsListBox.Items.Clear();
                foreach (Item item in _currentOrder.Items)
                {
                    string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                    OrderItemsListBox.Items.Add(_item);
                }
                OrderAmountLabel.Text = _currentOrder.Amount.ToString();
                OrderTotalLabel.Text = _currentOrder.Total.ToString();
            }
            else
            {
                OrderIdTextBox.Text = null;
                OrderCreatedTextBox.Text = null;
                OrderStatusComboBox.SelectedIndex = -1;
                OrderAddressControl.ClearAddressInfo(currentRow);
                OrderItemsListBox.Items.Clear();
                OrderAmountLabel.Text = "0";
                OrderTotalLabel.Text = "0";
            }
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (currentRow != -1)
                {
                    _currentOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;
                    OrdersDataGridView[2, currentRow].Value = (OrderStatus)OrderStatusComboBox.SelectedItem;
                }
            }
            catch { }
        }

        private void OrderDeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DesiredTime = OrderDeliveryTimeComboBox.Text;
        }
    }
}
