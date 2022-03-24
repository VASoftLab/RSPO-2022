using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;

namespace OPCTest
{
    public partial class Form1 : Form
    {
        private EasyDAClient client;

        public Form1()
        {
            InitializeComponent();

            client = new EasyDAClient();
            client.ItemChanged += Client_ItemChanged;
        }

        private void Client_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            var itemID = e.Arguments.ItemDescriptor.ItemId; // Tag Name
            var itemValue = e.Vtq.DisplayValue(); // Tag Value

            // TODO: Make switch-case
            var state = (int)e.Arguments.State; // ID

            switch (state)
            {
                case 1:
                    textBox1.Invoke((MethodInvoker)delegate {
                        textBox1.Text = itemValue;
                    });
                    break;
                case 2:
                    textBox2.Invoke((MethodInvoker)delegate {
                        textBox2.Text = itemValue;
                    });
                    break;
                case 3:
                    textBox1.Invoke((MethodInvoker)delegate {
                        textBox3.Text = itemValue;
                    });
                    break;
            }

            //if (itemID == "Simulation Examples.Functions.Ramp1")
            //{
            //    textBox1.Invoke((MethodInvoker)delegate {
            //        textBox1.Text = itemValue;
            //    });
            //}

            //if (itemID == "Simulation Examples.Functions.Random1")
            //{
            //    textBox2.Invoke((MethodInvoker)delegate {
            //        textBox2.Text = itemValue;
            //    });
            //}

            //if (itemID == "Simulation Examples.Functions.Sine1")
            //{
            //    textBox1.Invoke((MethodInvoker)delegate {
            //        textBox3.Text = itemValue;
            //    });
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var argumentArray = new DAItemGroupArguments[3];
            argumentArray[0] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Ramp1",
                1000,
                1);

            argumentArray[1] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Random1",
                1000,
                2);

            argumentArray[2] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Sine1",
                1000,
                3);

            client.SubscribeMultipleItems(argumentArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.UnsubscribeAllItems();
        }
    }
}
