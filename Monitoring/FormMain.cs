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

using System.Data.SQLite;

namespace Monitoring
{
    public partial class FormMain : Form
    {
        Settings appSet;
        private EasyDAClient client;
        string connectionString;
        SQLiteConnection sqliteConnection;


        public FormMain()
        {
            InitializeComponent();
            appSet = new Settings();
            client = new EasyDAClient();
            client.ItemChanged += Client_ItemChanged;

            connectionString = String.Format("Data Source={0};Version=3;", System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "mag2022.db"));
        }

        private void Client_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            var itemID = e.Arguments.ItemDescriptor.ItemId; // Tag Name
            var itemValue = e.Vtq.DisplayValue(); // Tag Value
            double value;
            Double.TryParse(itemValue, out value);

            using (SQLiteCommand sql = sqliteConnection.CreateCommand())
            {
                sql.CommandText = "INSERT INTO [tbTagValue] (tagName, tagValue) VALUES (@pName, @pValue)";
                sql.CommandType = CommandType.Text;
                sql.Parameters.Add(new SQLiteParameter("@pName", itemID.ToString()));
                sql.Parameters.Add(new SQLiteParameter("@pValue", itemValue.ToString()));
                sql.ExecuteNonQuery();
            }

            var state = (int)e.Arguments.State; // ID

            switch (state)
            {
                case 1:
                    tagPanel1.Invoke((MethodInvoker)delegate {
                        tagPanel1.RampValue = value;
                    });
                    break;
                case 2:
                    tagPanel1.Invoke((MethodInvoker)delegate {
                        tagPanel1.RandomValue = value;
                    });
                    break;
                case 3:
                    tagPanel1.Invoke((MethodInvoker)delegate {
                        tagPanel1.SinValue = value;
                    });
                    break;

                case 4:
                    tagPanel2.Invoke((MethodInvoker)delegate {
                        tagPanel2.RampValue = value;
                    });
                    break;
                case 5:
                    tagPanel2.Invoke((MethodInvoker)delegate {
                        tagPanel2.RandomValue = value;
                    });
                    break;
                case 6:
                    tagPanel2.Invoke((MethodInvoker)delegate {
                        tagPanel2.SinValue = value;
                    });
                    break;

                case 7:
                    tagPanel3.Invoke((MethodInvoker)delegate {
                        tagPanel3.RampValue = value;
                    });
                    break;
                case 8:
                    tagPanel3.Invoke((MethodInvoker)delegate {
                        tagPanel3.RandomValue = value;
                    });
                    break;
                case 9:
                    tagPanel3.Invoke((MethodInvoker)delegate {
                        tagPanel3.SinValue = value;
                    });
                    break;

                case 10:
                    tagPanel4.Invoke((MethodInvoker)delegate {
                        tagPanel4.RampValue = value;
                    });
                    break;
                case 11:
                    tagPanel4.Invoke((MethodInvoker)delegate {
                        tagPanel4.RandomValue = value;
                    });
                    break;
                case 12:
                    tagPanel4.Invoke((MethodInvoker)delegate {
                        tagPanel4.SinValue = value;
                    });
                    break;
            }
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

            try
            {
                sqliteConnection = new SQLiteConnection(connectionString);
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you ant to close?",
                "Question",
                icon: MessageBoxIcon.Question,
                buttons: MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                appSet.Save();

                try
                {
                    if (sqliteConnection != null)
                    {
                        if (sqliteConnection.State == ConnectionState.Open)
                        {
                            sqliteConnection.Close();
                        }

                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            tagPanel1.ClearData();
            tagPanel2.ClearData();
            tagPanel3.ClearData();
            tagPanel4.ClearData();

            int sampleTime = 1000;
            var argumentArray = new DAItemGroupArguments[12];

            #region DEVICE 1
            argumentArray[0] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Ramp1",
                sampleTime,
                1);

            argumentArray[1] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Random1",
                sampleTime,
                2);

            argumentArray[2] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Sine1",
                sampleTime,
                3);
            #endregion

            #region DEVICE 2
            argumentArray[3] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Ramp2",
                sampleTime,
                4);

            argumentArray[4] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Random2",
                sampleTime,
                5);

            argumentArray[5] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Sine2",
                sampleTime,
                6);
            #endregion

            #region DEVICE 3
            argumentArray[6] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Ramp3",
                sampleTime,
                7);

            argumentArray[7] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Random3",
                sampleTime,
                8);

            argumentArray[8] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Sine3",
                sampleTime,
                9);
            #endregion

            #region DEVICE 4
            argumentArray[9] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Ramp4",
                sampleTime,
                10);

            argumentArray[10] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Random4",
                sampleTime,
                11);

            argumentArray[11] = new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                "Simulation Examples.Functions.Sine4",
                sampleTime,
                12);
            #endregion

            client.SubscribeMultipleItems(argumentArray);
        }

        private void UnSubscribe_Click(object sender, EventArgs e)
        {
            client.UnsubscribeAllItems();
        }
    }
}
