using Logic;
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
        private List<Bitmap> steps = new List<Bitmap>();

        public MainForm()
        {
            InitializeComponent();

            AlgorithmComboBox.Items.Add("К-средних");
            AlgorithmComboBox.Items.Add("Максимин");
            AlgorithmComboBox.SelectedIndex = 0;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            steps.Clear();
            StepListBox.Items.Clear();

            if (AlgorithmComboBox.SelectedIndex == 0)
            {
                K_means logicKmeans = new K_means(MainPictureBox.Width, MainPictureBox.Height);
                int countDot  = Convert.ToInt32(DotCountTextBox.Text);
                int countCore = Convert.ToInt32(CoreCountTextBox.Text);

                if (countDot <= 1000 && countDot >= 100000)
                {
                    MessageBox.Show("Количество точек должно быть в диапазоне от 1000 до 100000");
                    return;
                } 

                if (countCore <= 2 && countCore >= 20)
                {
                    MessageBox.Show("Количество ядер должно быть в диапазоне от 1 до 20");
                    return;
                }


                int i = 0;
                string str = "Шаг №";
                Bitmap bmp;

                foreach (List<Logic.Region> regions in logicKmeans.Process(countCore, countDot))
                {
                    bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);

                    logicKmeans.DrawRegions(Graphics.FromImage(bmp), regions);
                    steps.Add(bmp);
                    StepListBox.Items.Add(str + i);
                    StepListBox.SelectedIndex = i++;
                }
            }
            else if (AlgorithmComboBox.SelectedIndex == 1)
            {
                Maxmin logicMaxmin = new Maxmin(MainPictureBox.Width, MainPictureBox.Height);
                int countDot = Convert.ToInt32(DotCountTextBox.Text);

                if (countDot <= 1000 && countDot >= 100000)
                {
                    MessageBox.Show("Количество точек должно быть в диапазоне от 1000 до 100000");
                    return;
                }

                int i = 0;
                string str = "Шаг №";
                Bitmap bmp;
                List<Logic.Region> maxminRegions = null;

                foreach (List<Logic.Region> regions in logicMaxmin.Process(countDot))
                {
                    bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);

                    logicMaxmin.DrawRegions(Graphics.FromImage(bmp), regions);
                    steps.Add(bmp);
                    StepListBox.Items.Add(str + i + "(Максимин)");
                    StepListBox.SelectedIndex = i++;
                    maxminRegions = regions;
                }

                K_means logicKmeans = new K_means(MainPictureBox.Width, MainPictureBox.Height);

                foreach (List<Logic.Region> regions in logicKmeans.Process(maxminRegions))
                {
                    bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);

                    logicKmeans.DrawRegions(Graphics.FromImage(bmp), regions);
                    steps.Add(bmp);
                    StepListBox.Items.Add(str + i + "(К-средних)");
                    StepListBox.SelectedIndex = i++;
                }
            }
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void StepListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int step = StepListBox.SelectedIndex;
            if (step < steps.Count)
            {
                MainPictureBox.Image = steps[step];
            }
        }

        private void AlogorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlgorithmComboBox.SelectedIndex == 0)
            {
                DotCountLabel.Visible    = true;
                DotCountTextBox.Visible  = true;
                CoreCountLabel.Visible   = true;
                CoreCountTextBox.Visible = true;
            }
            else if (AlgorithmComboBox.SelectedIndex == 1)
            {
                DotCountLabel.Visible = true;
                DotCountTextBox.Visible = true;
                CoreCountLabel.Visible = false;
                CoreCountTextBox.Visible = false;
            }
        }
    }
}
