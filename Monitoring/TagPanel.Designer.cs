
namespace Monitoring
{
    partial class TagPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.textBoxSin = new System.Windows.Forms.TextBox();
            this.labelSin = new System.Windows.Forms.Label();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Controls.Add(this.chart);
            this.groupBoxTitle.Controls.Add(this.textBoxSin);
            this.groupBoxTitle.Controls.Add(this.labelSin);
            this.groupBoxTitle.Controls.Add(this.textBoxRandom);
            this.groupBoxTitle.Controls.Add(this.labelRandom);
            this.groupBoxTitle.Controls.Add(this.textBoxRamp);
            this.groupBoxTitle.Controls.Add(this.labelRamp);
            this.groupBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(124, 246);
            this.groupBoxTitle.TabIndex = 0;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "DEVICE";
            // 
            // textBoxSin
            // 
            this.textBoxSin.Location = new System.Drawing.Point(20, 111);
            this.textBoxSin.Name = "textBoxSin";
            this.textBoxSin.Size = new System.Drawing.Size(86, 20);
            this.textBoxSin.TabIndex = 5;
            // 
            // labelSin
            // 
            this.labelSin.AutoSize = true;
            this.labelSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSin.Location = new System.Drawing.Point(20, 95);
            this.labelSin.Name = "labelSin";
            this.labelSin.Size = new System.Drawing.Size(22, 13);
            this.labelSin.TabIndex = 4;
            this.labelSin.Text = "Sin";
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(20, 74);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(86, 20);
            this.textBoxRandom.TabIndex = 3;
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(20, 58);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(47, 13);
            this.labelRandom.TabIndex = 2;
            this.labelRandom.Text = "Random";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(20, 36);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(86, 20);
            this.textBoxRamp.TabIndex = 1;
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRamp.Location = new System.Drawing.Point(20, 20);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(35, 13);
            this.labelRamp.TabIndex = 0;
            this.labelRamp.Text = "Ramp";
            // 
            // chart
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Location = new System.Drawing.Point(8, 137);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series3";
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(109, 100);
            this.chart.TabIndex = 6;
            this.chart.Text = "Data";
            // 
            // TagPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTitle);
            this.Name = "TagPanel";
            this.Size = new System.Drawing.Size(130, 252);
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.TextBox textBoxSin;
        private System.Windows.Forms.Label labelSin;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
