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
    public partial class jestimate : UserControl
    {
        private static jestimate _instance;
        public static jestimate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new jestimate();
                return _instance;
            }
        }
        public jestimate()
        {
            InitializeComponent();
        }

        private void estimate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
