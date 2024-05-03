using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BuildingsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CategoryComboBox.Items.AddRange(_category);
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            NameTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            CategoryComboBox.Enabled = false;
            RatingTextBox.Enabled = false;
        }

        private List<Model.Building> _buildings = new List<Model.Building>(); //Список со зданиями
        private Model.Building _currentBuilding; //Выбранное здание
        public string[] _category = Enum.GetNames(typeof(Model.Enums.Category)); //Перечисление категорий

        private void ClearBuildingInfo()
        {
            _buildings = _buildings.OrderBy(x => x.Category + x.Name).ToList();
            BuildingsListBox.Items.Clear();
            foreach (Model.Building item in _buildings)
            {
                string _item = ($"{item.Category} - {item.Name}").ToString();
                BuildingsListBox.Items.Add(_item);
            }
            NameTextBox.Text = null;
            AddressTextBox.Text = null;
            CategoryComboBox.SelectedIndex = -1;
            RatingTextBox.Text = null;

            NameTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            CategoryComboBox.Enabled = false;
            RatingTextBox.Enabled = false;

            NameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
            CategoryComboBox.BackColor = Color.White;
            RatingTextBox.BackColor = Color.White;
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Model.Building building = new Model.Building("Название", "Адрес", Enum.GetName(typeof(Model.Enums.Category), Model.Enums.Category.Municipal), 0);
            _buildings.Add(building);
            ClearBuildingInfo();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _buildings.RemoveAt(BuildingsListBox.SelectedIndex);
                ClearBuildingInfo();
            }
            catch { }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            ClearBuildingInfo();
        }

        private void BuildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateBuildingInfo(_buildings[BuildingsListBox.SelectedIndex]);
                if (!NameTextBox.Enabled)
                {
                    NameTextBox.Enabled = true;
                    AddressTextBox.Enabled = true;
                    CategoryComboBox.Enabled = true;
                    RatingTextBox.Enabled = true;
                }
            }
            catch { }
        }

        private void UpdateBuildingInfo(Model.Building building)
        {
            _currentBuilding = building;
            NameTextBox.Text = _currentBuilding.Name.ToString();
            AddressTextBox.Text = _currentBuilding.Address.ToString();
            CategoryComboBox.SelectedItem = _currentBuilding.Category.ToString();
            RatingTextBox.Text = _currentBuilding.Rating.ToString();
        }

        private void RefreshBuildingsListBoxItem()
        {
            string _item = ($"{_currentBuilding.Category} - {_currentBuilding.Name}").ToString();
            BuildingsListBox.Items[BuildingsListBox.SelectedIndex] = _item;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BuildingsListBox.SelectedIndex != -1)
                {
                    _currentBuilding.Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                    RefreshBuildingsListBoxItem();
                }
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BuildingsListBox.SelectedIndex != -1)
                {
                    _currentBuilding.Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }

        private void CategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BuildingsListBox.SelectedIndex != -1)
                {
                    _currentBuilding.Category = CategoryComboBox.Text;
                    CategoryComboBox.BackColor = Color.White;
                    RefreshBuildingsListBoxItem();
                }
            }
            catch
            {
                CategoryComboBox.BackColor = Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BuildingsListBox.SelectedIndex != -1)
                {
                    _currentBuilding.Rating = Convert.ToDouble(RatingTextBox.Text);
                    RatingTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                RatingTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
