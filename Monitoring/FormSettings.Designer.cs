
namespace Monitoring
{
    partial class FormSettings
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelOPCURL = new System.Windows.Forms.Label();
            this.textBoxOPCURL = new System.Windows.Forms.TextBox();
            this.textBoxRamp1 = new System.Windows.Forms.TextBox();
            this.labelRamp1 = new System.Windows.Forms.Label();
            this.textBoxRandom1 = new System.Windows.Forms.TextBox();
            this.labelRandom1 = new System.Windows.Forms.Label();
            this.textBoxSine1 = new System.Windows.Forms.TextBox();
            this.labelSine1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(197, 232);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelOPCURL
            // 
            this.labelOPCURL.AutoSize = true;
            this.labelOPCURL.Location = new System.Drawing.Point(12, 9);
            this.labelOPCURL.Name = "labelOPCURL";
            this.labelOPCURL.Size = new System.Drawing.Size(54, 13);
            this.labelOPCURL.TabIndex = 1;
            this.labelOPCURL.Text = "OPC URL";
            // 
            // textBoxOPCURL
            // 
            this.textBoxOPCURL.Location = new System.Drawing.Point(15, 25);
            this.textBoxOPCURL.Name = "textBoxOPCURL";
            this.textBoxOPCURL.Size = new System.Drawing.Size(257, 20);
            this.textBoxOPCURL.TabIndex = 2;
            // 
            // textBoxRamp1
            // 
            this.textBoxRamp1.Location = new System.Drawing.Point(15, 80);
            this.textBoxRamp1.Name = "textBoxRamp1";
            this.textBoxRamp1.Size = new System.Drawing.Size(257, 20);
            this.textBoxRamp1.TabIndex = 4;
            // 
            // labelRamp1
            // 
            this.labelRamp1.AutoSize = true;
            this.labelRamp1.Location = new System.Drawing.Point(12, 64);
            this.labelRamp1.Name = "labelRamp1";
            this.labelRamp1.Size = new System.Drawing.Size(44, 13);
            this.labelRamp1.TabIndex = 3;
            this.labelRamp1.Text = "Ramp 1";
            // 
            // textBoxRandom1
            // 
            this.textBoxRandom1.Location = new System.Drawing.Point(15, 122);
            this.textBoxRandom1.Name = "textBoxRandom1";
            this.textBoxRandom1.Size = new System.Drawing.Size(257, 20);
            this.textBoxRandom1.TabIndex = 6;
            // 
            // labelRandom1
            // 
            this.labelRandom1.AutoSize = true;
            this.labelRandom1.Location = new System.Drawing.Point(12, 106);
            this.labelRandom1.Name = "labelRandom1";
            this.labelRandom1.Size = new System.Drawing.Size(56, 13);
            this.labelRandom1.TabIndex = 5;
            this.labelRandom1.Text = "Random 1";
            // 
            // textBoxSine1
            // 
            this.textBoxSine1.Location = new System.Drawing.Point(15, 164);
            this.textBoxSine1.Name = "textBoxSine1";
            this.textBoxSine1.Size = new System.Drawing.Size(257, 20);
            this.textBoxSine1.TabIndex = 8;
            // 
            // labelSine1
            // 
            this.labelSine1.AutoSize = true;
            this.labelSine1.Location = new System.Drawing.Point(12, 148);
            this.labelSine1.Name = "labelSine1";
            this.labelSine1.Size = new System.Drawing.Size(37, 13);
            this.labelSine1.TabIndex = 7;
            this.labelSine1.Text = "Sine 1";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 232);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 267);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSine1);
            this.Controls.Add(this.labelSine1);
            this.Controls.Add(this.textBoxRandom1);
            this.Controls.Add(this.labelRandom1);
            this.Controls.Add(this.textBoxRamp1);
            this.Controls.Add(this.labelRamp1);
            this.Controls.Add(this.textBoxOPCURL);
            this.Controls.Add(this.labelOPCURL);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring :: Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelOPCURL;
        private System.Windows.Forms.TextBox textBoxOPCURL;
        private System.Windows.Forms.TextBox textBoxRamp1;
        private System.Windows.Forms.Label labelRamp1;
        private System.Windows.Forms.TextBox textBoxRandom1;
        private System.Windows.Forms.Label labelRandom1;
        private System.Windows.Forms.TextBox textBoxSine1;
        private System.Windows.Forms.Label labelSine1;
        private System.Windows.Forms.Button buttonOK;
    }
}