using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;

namespace Monitoring
{
    public partial class FormMain : Form
    {
        Settings appSet;
        private EasyDAClient client;
        private SQLiteConnection connection;

        List<TagPanel> Panels = new List<TagPanel>();

        public FormMain()
        {
            InitializeComponent();
            appSet = new Settings();
            client = new EasyDAClient();
            client.ItemChanged += Client_ItemChanged;
        }

        private void Client_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            var itemID = e.Arguments.ItemDescriptor.ItemId; // Tag Name
            var itemValue = e.Vtq.DisplayValue(); // Tag Value
            double value;
            Double.TryParse(itemValue, out value);

            var state = (int)e.Arguments.State; // ID

            foreach (var panel in Panels) {
                if (panel.OwnsState(state)) {
                    panel.ApplyState(state, value);
                    WriteToDb(panel, state, value);
                    break;
                }
            }
        }

        private void WriteToDb(TagPanel panel, int state, double value)
        {
            try
            {
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    var tableName = panel.GetTableName(state);
                    command.CommandText = $"INSERT INTO [{tableName}] (serial_number, value, date) VALUES (@serialNumber, @value, @date)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add(new SQLiteParameter("@serialNumber", panel.SerialNumber));
                    command.Parameters.Add(new SQLiteParameter("@value", value));
                    command.Parameters.Add(new SQLiteParameter("@date", DateTime.Now.ToFileTime()));
                    command.ExecuteNonQuery();
                }
            } catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            appSet.Load();
            ConnectToDatabase();
            RememberPanels();
            InitializePanelsWithDefaultTitle();
        }

        private void FormMain_Close()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void ConnectToDatabase()
        {
            string connectionString = String.Format("Data Source={0};Version=3;",
                System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "test_db.db"));
            try
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            } catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void InitializePanelsWithDefaultTitle()
        {
            foreach (var panel in Panels) {
                var serialNumber = panel.SerialNumber.ToString();
                panel.RampTitle = $"RAMP {serialNumber}";
                tagPanel1.RandomTitle = $"RANDOM {serialNumber}";
                tagPanel1.SinTitle = $"SIN {serialNumber}";
            }
        }

        private void RememberPanels()
        {
            foreach (var control in Controls) {
                if (control is TagPanel) {
                    Panels.Add((TagPanel) control);
                }
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

            foreach (var panel in Panels) {
                panel.RampValue = Math.PI;
                panel.RandomValue = random.NextDouble();
                panel.SinValue = Math.Sin(random.NextDouble());
            }
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
            ClearPanelsData();


            int sampleTime = 100;
            var count = 3 * Panels.Count;
            var argumentArray = new DAItemGroupArguments[count];

            foreach (var panel in Panels) {

                var serialNumber = panel.SerialNumber.ToString();
                var argumentIndex = panel.SerialNumber * 3 - 3;

                argumentArray[argumentIndex] = createArgument(sampleTime, argumentIndex + 1, $"Simulation Examples.Functions.Ramp{serialNumber}");
                argumentIndex++;

                argumentArray[argumentIndex] = createArgument(sampleTime, argumentIndex + 1, $"Simulation Examples.Functions.Random{serialNumber}");
                argumentIndex++;

                argumentArray[argumentIndex] = createArgument(sampleTime, argumentIndex + 1, $"Simulation Examples.Functions.Sine{serialNumber}");
            }

            client.SubscribeMultipleItems(argumentArray);
        }

        private static DAItemGroupArguments createArgument(int sampleTime, int state, string itemId)
        {
            return new DAItemGroupArguments(
                "localhost",
                "Kepware.KEPServerEX.V6",
                itemId,
                sampleTime,
                state
            );
        }

        private void ClearPanelsData()
        {
            foreach (var panel in Panels) {
                panel.ClearData();
            }
        }

        private void UnSubscribe_Click(object sender, EventArgs e)
        {
            client.UnsubscribeAllItems();
        }
    }
}
