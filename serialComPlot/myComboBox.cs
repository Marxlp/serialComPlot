using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyComponent
{
    /// <summary>
    /// ClassName:myComboBox
    /// Author:LP
    /// Date:7/12/2017
    /// </summary>
    /// <remarks>
    /// This class was used to create a easy-use module
    /// </remarks>
    class myComboBox:ComboBox
    {
        public override Color BackColor
        {
            get
            {
                return Color.WhiteSmoke;
            }

            set
            {
                base.BackColor = value;
            }
        }
        /// <summary>
        /// the number of channels include in the list
        /// </summary>
        private int _channels;
        public int Channels
        {
            get
            {
                return _channels;
            }
            set
            {
                _channels = value;
            }

        }
        /// <summary>
        /// current choose
        /// </summary>
        private int _choice;
        public int Choice
        {
            get
            {
                return _choice;
            }
            set
            {
                _choice = value;
            }
        }
        /// <summary>
        /// Using property Channels to update the list
        /// </summary>
        public void updateItems()
        {

            this.Items.Clear();
            if(Channels > 0)
            {
                for (int i = 1; i <= Channels; i++)
                    this.Items.Add(Convert.ToString(i));

            }
           
        }
        /// <summary>
        /// reload the SelectedIndexChanged
        /// </summary>
                 
        
    }
}
