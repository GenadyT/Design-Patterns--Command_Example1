using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightControl.FlatLights;

namespace LightControl.Commands
{
    internal class LightOffCommand : ICommand
    {
        private MyRoomLight _light;
        public LightOffCommand(MyRoomLight light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
        public void Redo()
        {
            _light.Off();
        }
    }
}
