using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
            AddDiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(Category)); //Заполнение Combobox категориями товаров.
        }

        public Category Category { get; set; }
        public bool IsOk = false;

        private void AddDiscountOkButton_Click(object sender, EventArgs e)
        {
            Category = (Category)AddDiscountCategoryComboBox.SelectedItem;
            IsOk = true;
            this.Close();
        }

        private void AddDiscountCancelButton_Click(object sender, EventArgs e)
        {
            IsOk = false;
            this.Close();
        }
    }
}
