using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightControl.Commands;

namespace LightControl.BL
{
    // Invoker
    internal class RemoteControl
    {
        private ICommand commandOn;
        private ICommand commandOff;
        private ICommand currentCommand;

        private ICommand macroCommand;

        public void SetCommands(ICommand commandOff, ICommand commandOn, ICommand macroCommand)
        {
            this.commandOn = commandOn;
            this.commandOff = commandOff;
            this.macroCommand = macroCommand;
        }

        public void PressButtonOn()
        {
            commandOn.Execute();
            currentCommand = commandOn;
        }
        public void PressButtonOff()
        {
            commandOff.Execute();
            currentCommand = commandOff;
        }

        public void PressButtonUndo()
        {
            currentCommand.Undo();
        }
        public void PressButtonRedo()
        {
            currentCommand.Redo();
        }
        public void PressButtonMacro()
        {
            macroCommand.Execute();
        }

    }
}
