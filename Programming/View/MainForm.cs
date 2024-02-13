using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            switch (EnumsListBox.SelectedIndex) //find the index of the selected string
            {
                case 0:
                    ValuesListBox.Items.AddRange(typeof(Model.Color).GetEnumNames());
                    break;
                case 1:
                    ValuesListBox.Items.AddRange(typeof(Model.EducationForm).GetEnumNames());
                    break;
                case 2:
                    ValuesListBox.Items.AddRange(typeof(Model.Genre).GetEnumNames());
                    break;
                case 3:
                    ValuesListBox.Items.AddRange(typeof(Model.Manufactures).GetEnumNames());
                    break;
                case 4:
                    ValuesListBox.Items.AddRange(typeof(Model.Season).GetEnumNames());
                    break;
                case 5:
                    ValuesListBox.Items.AddRange(typeof(Model.Weekday).GetEnumNames());
                    break;
            }
        }
    }
}
