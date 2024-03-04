using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LightControl.Commands
{
    internal class MacroCommand : ICommand
    {
        //private List<ICommand> commands;
        CommandTimer timer;

        public MacroCommand(List<ICommand> commands)
        {
            //this.commands = commands;
            timer = new CommandTimer(commands, 1500);
        }
        public void Execute()
        {
            /*foreach (var command in commands)
            {
                //command.Execute();
                timer.ExecuteCommand(command);
            }*/
            timer.Execute();
        }

        /*private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }*/

        public void Undo()
        {
            
        }
        public void Redo()
        {
            
        }
    }
}
