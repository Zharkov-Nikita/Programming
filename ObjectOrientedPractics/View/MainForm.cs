using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;

            OrdersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// Заполняет поля данными из выбранного товара.
        /// </summary>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            if (MainTabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
            if (MainTabControl.SelectedIndex == 4)
            {
                PriorityOrdersTab.RefreshData();
            }
        }
    }
}
