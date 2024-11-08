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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }

        private Address _address;
        public int _selectedIndex;

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public void Address_AddressChanged(object sender, EventArgs args)
        {
            Console.WriteLine("Адрес изменился");
        }

        public void ShowAddress()
        {
            AddressIndexTextBox.Text = Address.Index.ToString();
            AddressCountryTextBox.Text = Address.Country;
            AddressCityTextBox.Text = Address.City;
            AddressStreetTextBox.Text = Address.Street;
            AddressBuildingTextBox.Text = Address.Building;
            AddressApartmentTextBox.Text = Address.Apartment;
        }

        public void ClearAddressInfo(int selectedIndex)
        {
            _selectedIndex = selectedIndex;
            AddressIndexTextBox.Text = null;
            AddressCountryTextBox.Text = null;
            AddressCityTextBox.Text = null;
            AddressStreetTextBox.Text = null;
            AddressBuildingTextBox.Text = null;
            AddressApartmentTextBox.Text = null;

            AddressIndexTextBox.Enabled = false;
            AddressCountryTextBox.Enabled = false;
            AddressCityTextBox.Enabled = false;
            AddressStreetTextBox.Enabled = false;
            AddressBuildingTextBox.Enabled = false;
            AddressApartmentTextBox.Enabled = false;

            AddressIndexTextBox.BackColor = Color.White;
            AddressCountryTextBox.BackColor = Color.White;
            AddressCityTextBox.BackColor = Color.White;
            AddressStreetTextBox.BackColor = Color.White;
            AddressBuildingTextBox.BackColor = Color.White;
            AddressApartmentTextBox.BackColor = Color.White;
        }

        public void EnableAddressInfo()
        {
            AddressIndexTextBox.Enabled = true;
            AddressCountryTextBox.Enabled = true;
            AddressCityTextBox.Enabled = true;
            AddressStreetTextBox.Enabled = true;
            AddressBuildingTextBox.Enabled = true;
            AddressApartmentTextBox.Enabled = true;
        }

        private void AddressIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.Index = Convert.ToInt32(AddressIndexTextBox.Text);
                    AddressIndexTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressIndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.Country = AddressCountryTextBox.Text;
                    AddressCountryTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressCountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressCityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.City = AddressCityTextBox.Text;
                    AddressCityTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressCityTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.Street = AddressStreetTextBox.Text;
                    AddressStreetTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressStreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.Building = AddressBuildingTextBox.Text;
                    AddressBuildingTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressBuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedIndex != -1)
                {
                    Address.Apartment = AddressApartmentTextBox.Text;
                    AddressApartmentTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
