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
    public partial class TagPanel : UserControl
    {
        private string _PanelTitle;
        private string _RampTitle;
        private string _RandomTitle;
        private string _SinTitle;

        private double _RampValue;
        private double _RandomValue;
        private double _SinValue;

        public string PanelTitle
        {
            get { return _PanelTitle; }
            set
            {
                _PanelTitle = value;
                groupBoxTitle.Text = _PanelTitle;
            }
        }

        public string RampTitle
        {
            get { return _RampTitle; }
            set
            {
                _RampTitle = value;
                labelRamp.Text = _RampTitle;
            }
        }

        public string RandomTitle
        {
            get { return _RandomTitle; }
            set
            {
                _RandomTitle = value;
                labelRandom.Text = _RandomTitle;
            }
        }

        public string SinTitle
        {
            get { return _SinTitle; }
            set
            {
                _SinTitle = value;
                labelSin.Text = _SinTitle;
            }
        }

        public double RampValue
        {
            get { return _RampValue; }
            set
            {
                _RampValue = value;
                textBoxRamp.Text = _RampValue.ToString("0.00");
            }
        }

        public double RandomValue
        {
            get { return _RandomValue; }
            set
            {
                _RandomValue = value;
                textBoxRandom.Text = _RandomValue.ToString("0.00");
            }
        }

        public double SinValue
        {
            get { return _SinValue; }
            set
            {
                _SinValue = value;
                textBoxSin.Text = _SinValue.ToString("0.00");
            }
        }

        public TagPanel()
        {
            InitializeComponent();

            PanelTitle = "DEVICE";
            RampTitle = "Ramp";
            RandomTitle = "Random";
            SinTitle = "Sin";

            RampValue = 0;
            RandomValue = 0;
            SinValue = 0;
        }
    }
}
