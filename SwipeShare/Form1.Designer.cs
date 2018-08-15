namespace SwipeShare
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.panelSendForm = new System.Windows.Forms.Panel();
            this.panelReceiveForm = new System.Windows.Forms.Panel();
            this.btnReceiveFormBack = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnSetDestination = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentIPAddress = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.panelMainPanel.SuspendLayout();
            this.panelSendForm.SuspendLayout();
            this.panelReceiveForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(88, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(88, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 89);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.Controls.Add(this.panelSendForm);
            this.panelMainPanel.Controls.Add(this.button1);
            this.panelMainPanel.Controls.Add(this.button2);
            this.panelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(384, 561);
            this.panelMainPanel.TabIndex = 3;
            this.panelMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainPanel_Paint_1);
            // 
            // panelSendForm
            // 
            this.panelSendForm.Controls.Add(this.panelReceiveForm);
            this.panelSendForm.Controls.Add(this.button4);
            this.panelSendForm.Controls.Add(this.button3);
            this.panelSendForm.Controls.Add(this.label1);
            this.panelSendForm.Controls.Add(this.txtIP);
            this.panelSendForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSendForm.Location = new System.Drawing.Point(0, 0);
            this.panelSendForm.Name = "panelSendForm";
            this.panelSendForm.Size = new System.Drawing.Size(384, 561);
            this.panelSendForm.TabIndex = 2;
            // 
            // panelReceiveForm
            // 
            this.panelReceiveForm.Controls.Add(this.btnReceiveFormBack);
            this.panelReceiveForm.Controls.Add(this.btnReceive);
            this.panelReceiveForm.Controls.Add(this.btnSetDestination);
            this.panelReceiveForm.Controls.Add(this.label3);
            this.panelReceiveForm.Controls.Add(this.txtCurrentIPAddress);
            this.panelReceiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReceiveForm.Location = new System.Drawing.Point(0, 0);
            this.panelReceiveForm.Name = "panelReceiveForm";
            this.panelReceiveForm.Size = new System.Drawing.Size(384, 561);
            this.panelReceiveForm.TabIndex = 11;
            this.panelReceiveForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReceiveForm_Paint);
            // 
            // btnReceiveFormBack
            // 
            this.btnReceiveFormBack.Location = new System.Drawing.Point(297, 510);
            this.btnReceiveFormBack.Name = "btnReceiveFormBack";
            this.btnReceiveFormBack.Size = new System.Drawing.Size(59, 39);
            this.btnReceiveFormBack.TabIndex = 10;
            this.btnReceiveFormBack.Text = "Back";
            this.btnReceiveFormBack.UseVisualStyleBackColor = true;
            this.btnReceiveFormBack.Click += new System.EventHandler(this.btnReceiveFormBack_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(97, 371);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(188, 76);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnSetDestination
            // 
            this.btnSetDestination.BackColor = System.Drawing.Color.White;
            this.btnSetDestination.Location = new System.Drawing.Point(97, 202);
            this.btnSetDestination.Name = "btnSetDestination";
            this.btnSetDestination.Size = new System.Drawing.Size(188, 76);
            this.btnSetDestination.TabIndex = 6;
            this.btnSetDestination.Text = "Set Destinantion";
            this.btnSetDestination.UseVisualStyleBackColor = false;
            this.btnSetDestination.Click += new System.EventHandler(this.btnSetDestination_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current IP Accress";
            // 
            // txtCurrentIPAddress
            // 
            this.txtCurrentIPAddress.Location = new System.Drawing.Point(129, 94);
            this.txtCurrentIPAddress.Name = "txtCurrentIPAddress";
            this.txtCurrentIPAddress.ReadOnly = true;
            this.txtCurrentIPAddress.Size = new System.Drawing.Size(227, 20);
            this.txtCurrentIPAddress.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(151, 69);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(125, 20);
            this.txtIP.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panelMainPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMainPanel.ResumeLayout(false);
            this.panelSendForm.ResumeLayout(false);
            this.panelSendForm.PerformLayout();
            this.panelReceiveForm.ResumeLayout(false);
            this.panelReceiveForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.Panel panelSendForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelReceiveForm;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnSetDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentIPAddress;
        private System.Windows.Forms.Button btnReceiveFormBack;
    }
}

