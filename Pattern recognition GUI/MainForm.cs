using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern_recognition_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // добавить в comboBox алгоритмы
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // посмотреть какой алгоритм

            // запустить процедуру согласно алгоритму
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StepListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // поменять картинку на панели
        }

        private void AlogorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // поменять входные параметры
        }
    }
}
