using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRelative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //初始化
            InitResizeWindow();
        }

        private float x, y;//定义窗体宽高

        /// <summary>
        /// 缩放的初始化
        /// </summary>
        private void InitResizeWindow()
        {
            x = this.Width;
            y = this.Height;
            TestRelative.AutoSize.SetTag(this);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            TestRelative.AutoSize.SetControls(newx, newy, this);
        }
    }
}
