﻿using Practice_02._10.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_02._10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 Form1 = new Form1();
            this.Owner = Form1;
            
        }
        public string Label1_text 
        {  
          set
            { label1.Text = value; }
        }
    }
}
