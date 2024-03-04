using LightControl.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.BL
{
    // Client
    internal class Client
    {
        public void Run()
        {
            Light light = new Light();  // Receiver

            LightOnCommand lightOnCmd = new LightOnCommand(light);
            LightOffCommand lightOffCmd = new LightOffCommand(light);

            RemoteControl remoteControl = new RemoteControl();  // Invoker
            remoteControl.SetCommands(lightOnCmd, lightOffCmd);

            remoteControl.PressButtonOn();
        }
    }
}
