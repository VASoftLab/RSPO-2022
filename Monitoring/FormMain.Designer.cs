
namespace Monitoring
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tagPanel4 = new Monitoring.TagPanel();
            this.tagPanel3 = new Monitoring.TagPanel();
            this.tagPanel2 = new Monitoring.TagPanel();
            this.tagPanel1 = new Monitoring.TagPanel();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Location = new System.Drawing.Point(12, 326);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(100, 23);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(497, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagPanel4
            // 
            this.tagPanel4.Location = new System.Drawing.Point(420, 12);
            this.tagPanel4.Name = "tagPanel4";
            this.tagPanel4.PanelTitle = "DEVICE 4";
            this.tagPanel4.RampTitle = "Ramp";
            this.tagPanel4.RampValue = 0D;
            this.tagPanel4.RandomTitle = "Random";
            this.tagPanel4.RandomValue = 0D;
            this.tagPanel4.SinTitle = "Sin";
            this.tagPanel4.SinValue = 0D;
            this.tagPanel4.Size = new System.Drawing.Size(130, 150);
            this.tagPanel4.TabIndex = 5;
            // 
            // tagPanel3
            // 
            this.tagPanel3.Location = new System.Drawing.Point(284, 12);
            this.tagPanel3.Name = "tagPanel3";
            this.tagPanel3.PanelTitle = "DEVICE 3";
            this.tagPanel3.RampTitle = "Ramp";
            this.tagPanel3.RampValue = 0D;
            this.tagPanel3.RandomTitle = "Random";
            this.tagPanel3.RandomValue = 0D;
            this.tagPanel3.SinTitle = "Sin";
            this.tagPanel3.SinValue = 0D;
            this.tagPanel3.Size = new System.Drawing.Size(130, 150);
            this.tagPanel3.TabIndex = 4;
            // 
            // tagPanel2
            // 
            this.tagPanel2.Location = new System.Drawing.Point(148, 12);
            this.tagPanel2.Name = "tagPanel2";
            this.tagPanel2.PanelTitle = "DEVICE 2";
            this.tagPanel2.RampTitle = "Ramp";
            this.tagPanel2.RampValue = 0D;
            this.tagPanel2.RandomTitle = "Random";
            this.tagPanel2.RandomValue = 0D;
            this.tagPanel2.SinTitle = "Sin";
            this.tagPanel2.SinValue = 0D;
            this.tagPanel2.Size = new System.Drawing.Size(130, 150);
            this.tagPanel2.TabIndex = 3;
            // 
            // tagPanel1
            // 
            this.tagPanel1.Location = new System.Drawing.Point(12, 12);
            this.tagPanel1.Name = "tagPanel1";
            this.tagPanel1.PanelTitle = "DEVICE 1";
            this.tagPanel1.RampTitle = "Ramp";
            this.tagPanel1.RampValue = 0D;
            this.tagPanel1.RandomTitle = "Random";
            this.tagPanel1.RandomValue = 0D;
            this.tagPanel1.SinTitle = "Sin";
            this.tagPanel1.SinValue = 0D;
            this.tagPanel1.Size = new System.Drawing.Size(130, 150);
            this.tagPanel1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tagPanel4);
            this.Controls.Add(this.tagPanel3);
            this.Controls.Add(this.tagPanel2);
            this.Controls.Add(this.tagPanel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSettings);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonClose;
        private TagPanel tagPanel1;
        private TagPanel tagPanel2;
        private TagPanel tagPanel3;
        private TagPanel tagPanel4;
        private System.Windows.Forms.Button button1;
    }
}

