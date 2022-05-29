
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
            this.buttonSubscribe = new System.Windows.Forms.Button();
            this.UnSubscribe = new System.Windows.Forms.Button();
            this.tagPanel4 = new Monitoring.TagPanel();
            this.tagPanel3 = new Monitoring.TagPanel();
            this.tagPanel2 = new Monitoring.TagPanel();
            this.tagPanel1 = new Monitoring.TagPanel();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.Location = new System.Drawing.Point(18, 812);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(150, 35);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1110, 812);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(112, 35);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(504, 812);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "MANUAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSubscribe.Location = new System.Drawing.Point(177, 812);
            this.buttonSubscribe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(154, 35);
            this.buttonSubscribe.TabIndex = 7;
            this.buttonSubscribe.Text = "SUBSCRIBE";
            this.buttonSubscribe.UseVisualStyleBackColor = true;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // UnSubscribe
            // 
            this.UnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnSubscribe.Location = new System.Drawing.Point(340, 812);
            this.UnSubscribe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnSubscribe.Name = "UnSubscribe";
            this.UnSubscribe.Size = new System.Drawing.Size(154, 35);
            this.UnSubscribe.TabIndex = 8;
            this.UnSubscribe.Text = "UNSUBSCRIBE";
            this.UnSubscribe.UseVisualStyleBackColor = true;
            this.UnSubscribe.Click += new System.EventHandler(this.UnSubscribe_Click);
            // 
            // tagPanel4
            // 
            this.tagPanel4.Location = new System.Drawing.Point(630, 18);
            this.tagPanel4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tagPanel4.Name = "tagPanel4";
            this.tagPanel4.PanelTitle = "DEVICE 4";
            this.tagPanel4.RampTitle = "Ramp";
            this.tagPanel4.RampValue = 0D;
            this.tagPanel4.RandomTitle = "Random";
            this.tagPanel4.RandomValue = 0D;
            this.tagPanel4.SerialNumber = 4;
            this.tagPanel4.SinTitle = "Sin";
            this.tagPanel4.SinValue = 0D;
            this.tagPanel4.Size = new System.Drawing.Size(195, 385);
            this.tagPanel4.TabIndex = 5;
            // 
            // tagPanel3
            // 
            this.tagPanel3.Location = new System.Drawing.Point(426, 18);
            this.tagPanel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tagPanel3.Name = "tagPanel3";
            this.tagPanel3.PanelTitle = "DEVICE 3";
            this.tagPanel3.RampTitle = "Ramp";
            this.tagPanel3.RampValue = 0D;
            this.tagPanel3.RandomTitle = "Random";
            this.tagPanel3.RandomValue = 0D;
            this.tagPanel3.SerialNumber = 3;
            this.tagPanel3.SinTitle = "Sin";
            this.tagPanel3.SinValue = 0D;
            this.tagPanel3.Size = new System.Drawing.Size(195, 385);
            this.tagPanel3.TabIndex = 4;
            // 
            // tagPanel2
            // 
            this.tagPanel2.Location = new System.Drawing.Point(222, 18);
            this.tagPanel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tagPanel2.Name = "tagPanel2";
            this.tagPanel2.PanelTitle = "DEVICE 2";
            this.tagPanel2.RampTitle = "Ramp";
            this.tagPanel2.RampValue = 0D;
            this.tagPanel2.RandomTitle = "Random";
            this.tagPanel2.RandomValue = 0D;
            this.tagPanel2.SerialNumber = 2;
            this.tagPanel2.SinTitle = "Sin";
            this.tagPanel2.SinValue = 0D;
            this.tagPanel2.Size = new System.Drawing.Size(195, 385);
            this.tagPanel2.TabIndex = 3;
            // 
            // tagPanel1
            // 
            this.tagPanel1.Location = new System.Drawing.Point(18, 18);
            this.tagPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tagPanel1.Name = "tagPanel1";
            this.tagPanel1.PanelTitle = "DEVICE 1";
            this.tagPanel1.RampTitle = "Ramp";
            this.tagPanel1.RampValue = 0D;
            this.tagPanel1.RandomTitle = "Random";
            this.tagPanel1.RandomValue = 0D;
            this.tagPanel1.SerialNumber = 1;
            this.tagPanel1.SinTitle = "Sin";
            this.tagPanel1.SinValue = 0D;
            this.tagPanel1.Size = new System.Drawing.Size(195, 385);
            this.tagPanel1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 866);
            this.Controls.Add(this.UnSubscribe);
            this.Controls.Add(this.buttonSubscribe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tagPanel4);
            this.Controls.Add(this.tagPanel3);
            this.Controls.Add(this.tagPanel2);
            this.Controls.Add(this.tagPanel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonSubscribe;
        private System.Windows.Forms.Button UnSubscribe;
    }
}

