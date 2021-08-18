using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_c_sharp
{
    public partial class Information : UserControl
    {
        private static Information _instance;
        public static Information Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Information();
                }
                return _instance;
            }
        }
        public Information()
        {
            InitializeComponent();
        }
    }
}
