using LightControl.FlatLights;
using LightControl.UIControls;
using System.Windows.Forms;
using System.Reflection;

namespace LightControl
{
    partial class frmLightControl
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            
        }

        private void MyInitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();

            gpbLightSwitch = new OnOffGroupBox(
                rdbOff_Check, 
                rdbOn_Check,
                btnUndo_Click,
                btnRedo_Click,
                btnMacro_Click
            );

            panel1.SuspendLayout();
            gpbLightSwitch.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            //panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BackColor = ColorTranslator.FromHtml("#545454");
            panel1.BorderStyle = BorderStyle.Fixed3D;

            PictureBox pbHouse = new PictureBox();
            pbHouse.Left = 0;
            pbHouse.Top = 0;
            pbHouse.ImageLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Split("bin")[0] + "\\images\\House.png";
            pbHouse.SizeMode = PictureBoxSizeMode.Zoom;
            //pbHouse.Size = new System.Drawing.Size(150, 150);
            pbHouse.Size = new System.Drawing.Size(176, 123);
            panel1.Controls.Add(pbHouse);

            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(350, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 430);
            panel1.TabIndex = 2;
            panel1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "my room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "room light (Receiver)";
            label2.Click += label2_Click;
            

            gpbLightSwitch.Location = new Point(27, 24);
            gpbLightSwitch.Name = "gpbLightSwitch";
            gpbLightSwitch.Size = new Size(200, 100);
            gpbLightSwitch.TabIndex = 3;
            gpbLightSwitch.TabStop = false;
            gpbLightSwitch.Text = "Remote Control (Invoker)";
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 540);
            Controls.Add(gpbLightSwitch);
            Controls.Add(panel1);
            Name = "frmRemoteLightControl";
            Text = "Remote Light Control (by Command Pattern)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpbLightSwitch.ResumeLayout(false);
            gpbLightSwitch.PerformLayout();
            ResumeLayout(false);


            pictureBox2 = new MyRoomLight("\\images\\light_off.png", "\\images\\light_on.png");            
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(130, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Size = new Size(Convert.ToInt32(510*0.45), Convert.ToInt32(665 * 0.45));
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(672, 506);
            panel1.Controls.Add(pictureBox2);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

            this.Width += 80;
            this.Height += 70;
        }

        #endregion

        private OnOffGroupBox gpbLightSwitch;

        private Panel panel1;
        private Label label2;
        private Label label1;

        private MyRoomLight pictureBox2;
    }
}