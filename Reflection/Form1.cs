﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = texttypename.Text;
            Type T = Type.GetType(TypeName);

            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo method in methods)
            {
                listMethods.Items.Add(method.Name);
            }

        }
    }
}
