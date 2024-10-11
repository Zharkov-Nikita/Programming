﻿using ObjectOrientedPractics.View.Controls;
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
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
        }

        private Model.Customer _currentCustomer; //Текущий покупатель.
        private List<Model.Customer> _customers = new List<Model.Customer>(); //Список с покупателями.
        
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Заполняет поля данными из выбранного покупателя.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
                CustomerFullNameTextBox.Text = _currentCustomer.Fullname;
                CustomerAddressControl.Address = _currentCustomer.Address;
                CustomerIsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                CustomerAddressControl.ShowAddress();
                if (!CustomerFullNameTextBox.Enabled)
                {
                    CustomerFullNameTextBox.Enabled = true;
                    CustomerIsPriorityCheckBox.Enabled = true;
                    CustomerAddressControl.EnableAddressInfo();
                }
            }
            catch { }
        }

        /// <summary>
        /// Меняет ФИО покупателя на введённое
        /// </summary>
        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomersListBox.SelectedIndex != -1)
                {
                    _currentCustomer.Fullname = CustomerFullNameTextBox.Text;
                    CustomerFullNameTextBox.BackColor = Color.White;
                    RefreshCustomersListBoxItem();
                }
            }
            catch
            {
                CustomerFullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Очищение текстбоксов с информацией о выбранном покупателе
        /// </summary>
        private void ClearCustomerInfo()
        {
            CustomersListBox.Items.Clear();
            foreach (Model.Customer item in _customers)
            {
                string _customer = ($"{item.Id}: {item.Fullname}").ToString();
                CustomersListBox.Items.Add(_customer);
            }
            CustomerIdTextBox.Text = null;
            CustomerFullNameTextBox.Text = null;
            CustomerIsPriorityCheckBox.Checked = false;

            CustomerFullNameTextBox.Enabled = false;
            CustomerIsPriorityCheckBox.Enabled = false;

            CustomerFullNameTextBox.BackColor = Color.White;
            CustomerAddressControl.ClearAddressInfo(CustomersListBox.SelectedIndex);
        }

        /// <summary>
        /// Обновление информации в ListBox с покупателями
        /// </summary>
        private void RefreshCustomersListBoxItem()
        {
            string _item = ($"{_currentCustomer.Id}: {_currentCustomer.Fullname}").ToString();
            CustomersListBox.Items[CustomersListBox.SelectedIndex] = _item;
        }

        /// <summary>
        /// Кнопка добавления покупателя
        /// </summary>
        private void CustomerAddButton_Click(object sender, EventArgs e)
        {
            Model.Customer item = new Model.Customer("Фамилия Имя Отчество", new Model.Address(123456, "Страна", "Город", "Улица", "Номер дома", "Квартира"));
            _customers.Add(item);
            ClearCustomerInfo();
        }

        /// <summary>
        /// Кнопка удаления покупателя
        /// </summary>
        private void CustomerRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                ClearCustomerInfo();
            }
            catch { }
        }

        private void CustomerIsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer.IsPriority = CustomerIsPriorityCheckBox.Checked;
            }
        }
    }
}
