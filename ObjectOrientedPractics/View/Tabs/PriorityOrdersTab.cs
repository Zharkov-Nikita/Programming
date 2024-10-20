using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
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
    public partial class PriorityOrdersTab : UserControl
    {
        public PriorityOrdersTab()
        {
            InitializeComponent();
            OrderStatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus)); //Заполнение Combobox статусами заказов.
        }

        Random rnd = new Random();
        public PriorityOrder PriorityOrder = new PriorityOrder(DateTime.Now, "9:00 - 11:00", new Address(123456, "Страна", "Город", "Улица", "Номер дома", "Квартира"), new List<Item>());

        private void UpdateOrder()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in PriorityOrder.Items)
            {
                string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                OrderItemsListBox.Items.Add(_item);
            }
            OrderAmountLabel.Text = PriorityOrder.Amount.ToString();
        }

        public void RefreshData()
        {
            OrderIdTextBox.Text = PriorityOrder.Id.ToString();
            OrderCreatedTextBox.Text = PriorityOrder.CreateDate.ToString();
            OrderStatusComboBox.SelectedIndex = Convert.ToInt32(PriorityOrder.Status);
            OrderDeliveryTimeComboBox.SelectedItem = PriorityOrder.DesiredTime;
            OrderAddressControl.Address = PriorityOrder.Address;
            OrderAddressControl.ShowAddress();
            UpdateOrder();
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.Status = (OrderStatus)OrderStatusComboBox.SelectedItem;
        }

        private void OrderDeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.DesiredTime = OrderDeliveryTimeComboBox.Text;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Model.Item item = new Model.Item("Название", "Описание", rnd.Next(5, 101), Category.Cereals);
            PriorityOrder.Items.Add(item);
            UpdateOrder();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                PriorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                UpdateOrder();
            }
            catch { }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrder = null;
            PriorityOrder = new PriorityOrder(DateTime.Now, "9:00 - 11:00", new Model.Address(123456, "Страна", "Город", "Улица", "Номер дома", "Квартира"), new List<Item>());
            RefreshData();
        }
    }
}
