using LightControl.BL;
using LightControl.Commands;

namespace LightControl
{
    public partial class frmLightControl : Form
    {
        private EventHandler evtOff;
        private EventHandler evtOn;

        ICommand commandOff;
        ICommand commandOn;
        ICommand macroCommand;

        RemoteControl remoteControl;

        public frmLightControl()
        {
            InitializeComponent();
            MyInitializeComponent();
            InitializeComponentAddition();
        }

        private void InitializeComponentAddition()
        {
            commandOff = new LightOffCommand(pictureBox2);
            commandOn = new LightOnCommand(pictureBox2);
            macroCommand = new MacroCommand(new List<ICommand> { commandOff, commandOn, commandOff, commandOn });

            remoteControl = new RemoteControl();
            remoteControl.SetCommands(commandOff, commandOn, macroCommand);
        }

        private void rdbOff_Check(object sender, EventArgs e)
        {
            remoteControl.PressButtonOff();
        }

        private void rdbOn_Check(object sender, EventArgs e)
        {
            remoteControl.PressButtonOn();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            remoteControl.PressButtonUndo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            remoteControl.PressButtonRedo();
        }

        private void btnMacro_Click(object sender, EventArgs e)
        {
            remoteControl.PressButtonMacro();
        }
        



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}