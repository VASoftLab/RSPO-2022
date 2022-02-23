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
    public partial class FormSettings : Form
    {
        public Settings appSet;

        public FormSettings()
        {
            InitializeComponent();
            appSet = new Settings();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (appSet != null)
            {
                textBoxOPCURL.Text = appSet.OPCURL;
                textBoxRamp1.Text = appSet.TagRamp1;
                textBoxRandom1.Text = appSet.TagRandom1;
                textBoxSine1.Text = appSet.TagSine1;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (appSet != null)
            {
                appSet.OPCURL = textBoxOPCURL.Text;
                appSet.TagRamp1 = textBoxRamp1.Text;
                appSet.TagRandom1 = textBoxRandom1.Text;
                appSet.TagSine1 = textBoxSine1.Text;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
