using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LightControl.Commands
{
    internal class CommandTimer
    {
        private System.Timers.Timer aTimer;
        //ElapsedEventHandler onTimedEvent;
        private List<ICommand> commands;
        private int executeCount;

        //public CommandTimer(ElapsedEventHandler onTimedEvent, double interval = 5000)
        public CommandTimer(List<ICommand> commands, double interval = 5000)
        {
            this.commands = commands;
            executeCount = 0;

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = interval;

            //aTimer.Enabled = true;
        }

        public void Execute()
        {
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (executeCount < commands.Count)
            {
                ICommand command = commands[executeCount];
                command.Execute();
                executeCount++;
            }
            else
            {
                aTimer.Enabled = false;
            }
        }
    }
}
