using BuildingsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
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

            LoadSaves();
        }

        private List<Building> _buildings = new List<Building>(); //Список со зданиями
        private Building _currentBuilding; //Выбранное здание
        public string[] _category = Enum.GetNames(typeof(Model.Enums.Category)); //Перечисление категорий
        string path = Directory.GetCurrentDirectory() + "/saves.txt"; //Путь файла с сохранениями

        /// <summary>
        /// Функция загрузки сохранений.
        /// </summary>
        private void LoadSaves()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] strBuilding = line.Split(';');
                        Building building = new Building(strBuilding[0], strBuilding[1], strBuilding[2], Convert.ToDouble(strBuilding[3]));
                        _buildings.Add(building);
                        line = sr.ReadLine();
                    }
                }
                ClearBuildingInfo();
            }
            catch { }
        }

        /// <summary>
        /// Функция очистки текстбоксов.
        /// </summary>
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

        /// <summary>
        /// Добавление здания.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Building building = new Building("Название", "Адрес", "Municipal", 0);
            _buildings.Add(building);
            ClearBuildingInfo();
        }

        /// <summary>
        /// Удаление здания.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _buildings.RemoveAt(BuildingsListBox.SelectedIndex);
                ClearBuildingInfo();
            }
            catch { }
        }

        /// <summary>
        /// Сортировка списка зданий.
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            ClearBuildingInfo();
        }

        /// <summary>
        /// Заполняет поля данными из выбранного здания.
        /// </summary>
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

        /// <summary>
        /// Заполнение текстбоксов информацией о прямоугольнике.
        /// </summary>
        /// <param name="building">Выбранное здание.</param>
        private void UpdateBuildingInfo(Model.Building building)
        {
            _currentBuilding = building;
            NameTextBox.Text = _currentBuilding.Name.ToString();
            AddressTextBox.Text = _currentBuilding.Address.ToString();
            CategoryComboBox.SelectedItem = _currentBuilding.Category.ToString();
            RatingTextBox.Text = _currentBuilding.Rating.ToString();
        }

        /// <summary>
        /// Обновление информации о здании в листбоксе.
        /// </summary>
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
                    NameErrorLabel.Visible = false;
                    RefreshBuildingsListBoxItem();
                }
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
                NameErrorLabel.Visible = true;
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
                    AddressErrorLabel.Visible = false;
                }
            }
            catch
            {
                AddressTextBox.BackColor = Color.LightPink;
                AddressErrorLabel.Visible = true;
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
                    if (RatingTextBox.Text.Length > 3)
                    {
                        throw new ArgumentException();
                    }
                    _currentBuilding.Rating = Convert.ToDouble(RatingTextBox.Text);
                    RatingTextBox.BackColor = Color.White;
                    RatingErrorLabel.Visible = false;
                }
            }
            catch
            {
                RatingTextBox.BackColor = Color.LightPink;
                RatingErrorLabel.Visible = true;
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 59) // Запрет на ввод символа ";"
            {
                e.Handled = true;
            }
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 59) // Запрет на ввод символа ";"
            {
                e.Handled = true;
            }
        }

        private void RatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // Цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Сохранение данных при закрытии приложения.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < _buildings.Count; i++)
                {
                    sw.WriteLine(_buildings[i].Name + ";" + _buildings[i].Address + ";" + _buildings[i].Category + ";" + _buildings[i].Rating);
                }
            }
        } 
    }
}
