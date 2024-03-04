using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.FlatLights
{
    // Receiver
    internal class MyRoomLight : PictureBox
    {
        private LightStates state;
        public LightStates LightState { get { return state; } }

        private string lightOnPicPath;
        public string LightOnPicPath { get { return lightOnPicPath; } }

        private string lightOffPicPath;
        public string LightOffPicPath { get { return lightOffPicPath; } }

        public MyRoomLight(string lightOffPicPath, string lightOnPicPath)
        {
            this.lightOnPicPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Split("bin")[0] + lightOnPicPath;
            this.lightOffPicPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Split("bin")[0] + lightOffPicPath;
        }

        public virtual void On()
        {
            this.state = LightStates.On;
            this.ImageLocation = lightOnPicPath;
        }

        public virtual void Off()
        {
            this.state = LightStates.Off;
            this.ImageLocation = lightOffPicPath;
        }
    }
}
