﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            viewBox.Image = new Bitmap(viewBox.Width, viewBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        private void render_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD:warmup/warmup/Form1.cs
            Graphics gr = Graphics.FromImage(viewBox.Image);
            Random random = new Random();
            Pen pen = new Pen ( Color.FromArgb(random.Next(255),random.Next(255),random.Next(255)) );
            gr.DrawEllipse ( pen, random.Next(viewBox.Width-10),random.Next(viewBox.Height-10),10,10);
            viewBox.Invalidate();
=======
            
            
>>>>>>> origin/master:warmup/warmup/Form1.cs
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
