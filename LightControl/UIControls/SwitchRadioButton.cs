using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightControl.UIControls
{
    public class SwitchRadioButton : RadioButton
    {
        public SwitchRadioButton(int tabIndex) : base()
        {
            AutoSize = true;
            TabIndex = tabIndex;
            TabStop = true;
            UseVisualStyleBackColor = true;
            FlatStyle = FlatStyle.Flat;
            /*this.Height = 5;
            this.Left = 40;*/
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            // Make the cursor the Hand cursor when the mouse moves 
            // over the button.
            Cursor = Cursors.Hand;

            // Call MyBase.OnMouseMove to activate the delegate.
            base.OnMouseMove(e);
        }
    }
}
