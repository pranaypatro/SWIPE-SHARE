using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwipeShare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //var myForm = new SendForm();
            //myForm.Show();
            panelReceiveForm.Visible = false;
            panelMainPanel.Visible = true;
            panelSendForm.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //var myForm = new ReceiveForm();
            //myForm.Show();
            panelSendForm.Visible = true;
          //  panelMainPanel.Visible = false;
            panelReceiveForm.Visible = true;

        }


        private void SetBackgroundImage()
        {
            this.BackgroundImage = Properties.Resources.background_ui;
            panelMainPanel.BackgroundImage = Properties.Resources.background_ui;
            panelReceiveForm.BackgroundImage = Properties.Resources.background_ui;
            panelSendForm.BackgroundImage = Properties.Resources.background_ui;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetBackgroundImage();
            this.Size = new Size(400, 600);

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 153, 51, 255);
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 1;
            panelMainPanel.Visible = true;
            panelSendForm.Visible = false;

        }

        private void instructionsToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("The reveiver Need to press Receive and The Sender needs to Press Send");
        }

        private void instructionsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show("The reveiver Need to press Receive and The Sender needs to Press Send");
        }

        private void PanelMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSendForm.Visible = false;
            panelMainPanel.Visible = true;
        }

        private void btnReceiveFormBack_Click(object sender, EventArgs e)
        {
            panelReceiveForm.Visible = false;
            panelSendForm.Visible = false;
            panelMainPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sender sendObj = new Sender(txtIP.Text);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            receiver.PerformOperations(9518);
        }

        private void btnSetDestination_Click(object sender, EventArgs e)
        {
            receiver.SetPath();
        }


        Receiver receiver = new Receiver();

        private void panelReceiveForm_Paint(object sender, PaintEventArgs e)
        {
            txtCurrentIPAddress.Text =  receiver.GetIPAddress();
        }
    }
}