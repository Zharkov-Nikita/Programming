using ObjectOrientedPractics.Model;
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

        public List<Model.Customer> Customers { get; set; }
        public List<Model.Order> Orders { get; set; } = new List<Model.Order>();

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
                    OrdersDataGridView[4, index].Value = $"{customer.Address.Country}, {customer.Address.City}, дом {customer.Address.Building}, кв. {customer.Address.Apartment}";
                    OrdersDataGridView[5, index].Value = order.Amount;
                }
            }
        }

        int currentRow;
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            currentRow = OrdersDataGridView.CurrentCell.RowIndex;

            if (currentRow != -1)
            {
                OrderIdTextBox.Text = Orders[currentRow].Id.ToString();
                OrderCreatedTextBox.Text = Orders[currentRow].CreateDate.ToString();
                OrderStatusComboBox.SelectedIndex = Convert.ToInt32(Orders[currentRow].Status);
                OrderAddressControl.Address = Orders[currentRow].Address;
                OrderAddressControl.ShowAddress();
                OrderItemsListBox.Items.Clear();
                foreach (Item item in Orders[currentRow].Items)
                {
                    string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                    OrderItemsListBox.Items.Add(_item);
                }
                OrderAmountLabel.Text = Orders[currentRow].Amount.ToString();
            }
            else
            {
                OrderIdTextBox.Text = null;
                OrderCreatedTextBox.Text = null;
                OrderStatusComboBox.SelectedIndex = -1;
                OrderAddressControl.ClearAddressInfo();
                OrderItemsListBox.Items.Clear();
                OrderAmountLabel.Text = "0";
            }
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (currentRow != -1)
                {
                    Orders[currentRow].Status = (OrderStatus)OrderStatusComboBox.SelectedItem;
                    OrdersDataGridView[2, currentRow].Value = (OrderStatus)OrderStatusComboBox.SelectedItem;
                }
            }
            catch { }
        }
    }
}
