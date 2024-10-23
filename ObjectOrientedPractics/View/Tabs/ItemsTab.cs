using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category)); //Заполнение Combobox категориями товаров.
        }

        private Item _currentItem; //Текущий товар.
        List<Item> _items = new List<Item>(); //Список с товарами.

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        Random rnd = new Random();

        /// <summary>
        /// Заполняет поля данными из выбранного товара.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                ItemIdTextBox.Text = _currentItem.Id.ToString();
                ItemCostTextBox.Text = _currentItem.Cost.ToString();
                ItemNameTextBox.Text = _currentItem.Name;
                ItemDescriptionTextBox.Text = _currentItem.Info;
                ItemCategoryComboBox.SelectedIndex = Convert.ToInt32(_currentItem.Category);
                if (!ItemCostTextBox.Enabled)
                {
                    ItemCostTextBox.Enabled = true;
                    ItemNameTextBox.Enabled = true;
                    ItemDescriptionTextBox.Enabled = true;
                    ItemCategoryComboBox.Enabled = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Меняет цену товара на введённую.
        /// </summary>
        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex != -1)
                {
                    _currentItem.Cost = Convert.ToDouble(ItemCostTextBox.Text);
                    ItemCostTextBox.BackColor = Color.White;
                    RefreshItemsListBoxItem();
                }
            }
            catch
            {
                ItemCostTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Меняет название товара на введённое.
        /// </summary>
        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex != -1)
                {
                    _currentItem.Name = ItemNameTextBox.Text;
                    ItemNameTextBox.BackColor = Color.White;
                    RefreshItemsListBoxItem();
                }
            }
            catch
            {
                ItemNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Меняет описание товара на введённое.
        /// </summary>
        private void ItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex != -1)
                {
                    _currentItem.Info = ItemDescriptionTextBox.Text;
                    ItemDescriptionTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                ItemDescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Очищение текстбоксов с информацией о выбранном товаре.
        /// </summary>
        private void ClearItemInfo()
        {
            ItemsListBox.Items.Clear();
            foreach (Model.Item item in _items)
            {
                string _item = ($"{item.Id}: {item.Name}, цена = {item.Cost}").ToString();
                ItemsListBox.Items.Add(_item);
            }
            ItemIdTextBox.Text = null;
            ItemCostTextBox.Text = null;
            ItemNameTextBox.Text = null;
            ItemDescriptionTextBox.Text = null;
            ItemCategoryComboBox.SelectedIndex = -1;

            ItemCostTextBox.Enabled = false;
            ItemNameTextBox.Enabled = false;
            ItemDescriptionTextBox.Enabled = false;
            ItemCategoryComboBox.Enabled = false;

            ItemCostTextBox.BackColor = Color.White;
            ItemNameTextBox.BackColor = Color.White;
            ItemDescriptionTextBox.BackColor = Color.White;
            ItemCategoryComboBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновление информации в ListBox с товарами.
        /// </summary>
        private void RefreshItemsListBoxItem()
        {
            string _item = ($"{_currentItem.Id}: {_currentItem.Name}, цена = {_currentItem.Cost}").ToString();
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = _item;
        }

        /// <summary>
        /// Кнопка добавления товара.
        /// </summary>
        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            Model.Item item = new Model.Item("Название", "Описание", rnd.Next(100, 1001), Category.Cereals);
            _items.Add(item);
            ClearItemInfo();
        }

        /// <summary>
        /// Кнопка удаления товара.
        /// </summary>
        private void ItemRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ClearItemInfo();
            }
            catch { }
        }

        /// <summary>
        /// Изменение категории товара.
        /// </summary>
        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex != -1)
                {
                    _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;
                }
            }
            catch{}
        }
    }
}
