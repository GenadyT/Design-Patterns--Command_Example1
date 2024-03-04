using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.UIControls
{
    internal class OnOffGroupBox : GroupBox
    {
        //--------------------------------
        private event EventHandler evtOff;
        private SwitchRadioButton rdbOff;
        private event EventHandler evtOn;
        private SwitchRadioButton rdbOn;
        //--------------------------------
        private SwitchButton btnUndo;
        private event EventHandler evtUndo;
        private SwitchButton btnRedo;
        private event EventHandler evtRedo;
        private SwitchButton btnMacro;
        private event EventHandler evtMacro;

        private void InitControls()
        {
            rdbOn = new SwitchRadioButton(1);
            rdbOn.Name = "rdbOn";
            rdbOn.Text = "Light On";
            rdbOn.CheckedChanged += radioButton_CheckedChanged;
            this.Controls.Add(rdbOn);

            rdbOff = new SwitchRadioButton(2);
            rdbOff.Name = "rdbOff";
            rdbOff.Text = "Light Off";
            rdbOff.CheckedChanged += radioButton_CheckedChanged;
            this.Controls.Add(rdbOff);

            btnUndo = new SwitchButton(3);
            btnUndo.Name = "btnUndo";
            btnUndo.Text = "Undo";
            btnUndo.Click += undoReduButton_Click;
            this.Controls.Add(btnUndo);

            btnRedo = new SwitchButton(4);
            btnRedo.Name = "btnRedo";
            btnRedo.Text = "Redo";
            btnRedo.Click += undoReduButton_Click;
            this.Controls.Add(btnRedo);

            btnMacro = new SwitchButton(5);
            btnMacro.Name = "btnMacro";
            btnMacro.Text = "Macro";
            btnMacro.Click += macroButton_Click;
            this.Controls.Add(btnMacro);           

            this.AutoSize = true;
            this.Height += 70;
            this.BackColor = ColorTranslator.FromHtml("#FFFECD");
            //this.Font = new Font(this.Font.Name, 8.0f);
        }

        private void PositionControls()
        {
            // -- Radio Buttons ----------------
            const int iRdbLocLeft = 15;
            const int iRdbLocTop = 45;
            const int iRdbWidth = 100;
            const int iRdbHeight = 20;            
            //--------
            rdbOff.Location = new Point(iRdbLocLeft, iRdbLocTop);            
            rdbOff.Size = new Size(iRdbWidth, iRdbHeight);
            //--------
            rdbOn.Location = new Point(iRdbLocLeft, iRdbLocTop + 35);
            rdbOn.Size = new Size(iRdbWidth, iRdbHeight);

            // -- Buttons ----------------------
            const int iBtnLocLeft = 105;
            const int iBtnLocTop = 27;
            const int iBtnWidth = 80;
            const int iBtnHeight = 15;
            //--------            
            btnUndo.Location = new Point(iBtnLocLeft, iBtnLocTop);
            btnUndo.Size = new Size(iBtnWidth, iBtnHeight);
            //--------            
            btnRedo.Location = new Point(iBtnLocLeft, iBtnLocTop + 36);
            btnRedo.Size = new Size(iBtnWidth, iBtnHeight);
            //--------            
            btnMacro.Location = new Point(iBtnLocLeft, iBtnLocTop + 36 + 36);
            btnMacro.Size = new Size(iBtnWidth, iBtnHeight);
        }

        public OnOffGroupBox()
        {
            InitControls();
            PositionControls();
        }

        public OnOffGroupBox(
            EventHandler evtOff, EventHandler evtOn, EventHandler evtUndo, 
            EventHandler evtRedo, EventHandler evtMacro
        ) : this() { 
            //--------------------
            this.evtOff = evtOff;
            this.evtOn = evtOn;
            //--------------------            
            this.evtUndo = evtUndo;            
            this.evtRedo = evtRedo;
            //--------------------
            this.evtMacro = evtMacro;
        }

        private void radioButton_CheckedChanged(Object sender,
                                         EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            bool checkedOff = rdb.Name.Contains("Off");

            if (checkedOff)
            {
                evtOff?.Invoke(this, e);
            }
            else
            {
                evtOn?.Invoke(this, e);
            }
        }

        private void undoReduButton_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            bool clickedUndo = btn.Name.Contains("Undo");

            if (clickedUndo)
            {
                evtUndo?.Invoke(this, e);
            }
            else
            {
                evtRedo?.Invoke(this, e);
            }

            rdbSwitch();
        }

        private void rdbSwitch()
        {
            if (rdbOff.Checked)
            {
                rdbOn.Checked = true;
            }
            else
            {
                rdbOff.Checked = true;
            }
        }

        private void macroButton_Click(Object sender, EventArgs e)
        {
            evtMacro?.Invoke(this, e);
        }
    }
}
