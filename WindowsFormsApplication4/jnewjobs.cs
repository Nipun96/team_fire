﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class jnewjobs : UserControl
    {
        private static jnewjobs _instance;
        public static jnewjobs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new jnewjobs();
                return _instance;
            }
        }
        public jnewjobs()
        {
            InitializeComponent();
        }
    }
}
