using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyComponent
{
    class myTextBox:TextBox
    {
        public override Color   BackColor
        {
            
            get
            {
                Color backcolor = Color.WhiteSmoke;
                return backcolor;
            }
        }
    }
}
