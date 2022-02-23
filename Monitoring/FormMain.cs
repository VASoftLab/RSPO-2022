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
    }
}
