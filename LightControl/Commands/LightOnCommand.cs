using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightControl.FlatLights;

namespace LightControl.Commands
{
    internal class LightOnCommand : ICommand
    {
        private MyRoomLight _light;
        public LightOnCommand(MyRoomLight light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
        public void Redo()
        {
            _light.On();
        }
    }
}
