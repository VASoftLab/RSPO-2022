using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class FormMain : Form
    {
        Settings appSet;

        public FormMain()
        {
            InitializeComponent();
            appSet = new Settings();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            appSet.Load();

            tagPanel1.RampTitle = "RAMP 1";
            tagPanel1.RandomTitle = "RANDOM 1";
            tagPanel1.SinTitle = "SIN 1";

            tagPanel2.RampTitle = "RAMP 2";
            tagPanel2.RandomTitle = "RANDOM 2";
            tagPanel2.SinTitle = "SIN 2";

            tagPanel3.RampTitle = "RAMP 3";
            tagPanel3.RandomTitle = "RANDOM 3";
            tagPanel3.SinTitle = "SIN 3";

            tagPanel4.RampTitle = "RAMP 4";
            tagPanel4.RandomTitle = "RANDOM 4";
            tagPanel4.SinTitle = "SIN 4";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you ant to close?",
                "Question",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                appSet.Save();
                Close();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();

            formSettings.appSet = appSet;

            if (formSettings.ShowDialog() == DialogResult.OK)
            {
                appSet = formSettings.appSet;
                appSet.Save();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tagPanel1.RampValue = Math.PI;
            tagPanel1.RandomValue = random.NextDouble();
            tagPanel1.SinValue = Math.Sin(random.NextDouble());

            tagPanel2.RampValue = Math.PI;
            tagPanel2.RandomValue = random.NextDouble();
            tagPanel2.SinValue = Math.Sin(random.NextDouble());

            tagPanel3.RampValue = Math.PI;
            tagPanel3.RandomValue = random.NextDouble();
            tagPanel3.SinValue = Math.Sin(random.NextDouble());

            tagPanel4.RampValue = Math.PI;
            tagPanel4.RandomValue = random.NextDouble();
            tagPanel4.SinValue = Math.Sin(random.NextDouble());
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                button1.PerformClick();
                e.Handled = true;
            }
        }
    }
}
