using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpHelper
{
    public partial class Form_JumpHelper : Form
    {
        int x_st = 0;
        int y_st = 0;
        int x_sp = 0;
        int y_sp = 0;
        int dx = 0;
        int dy = 0;
        int d = 0;
        float scale = 0;
        UInt16 ms = 0;

        public Form_JumpHelper()
        {
            InitializeComponent();
        }

        private void Form_JumpHelper_Load(object sender, EventArgs e)
        {

        }

        private void serialPort_jump_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void timer_jump_Tick(object sender, EventArgs e)
        {
            textBox_now.Text = "(" + Control.MousePosition.X.ToString("D4") + ", " + Control.MousePosition.Y.ToString("D4") + ")";

            if (checkBox_st.Checked && checkBox_sp.Checked)
            {
                dx = Math.Abs(x_st - x_sp);
                dy = Math.Abs(y_st - y_sp);
                d = (int)Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

                textBox_x.Text = dx.ToString("D4");
                textBox_y.Text = dy.ToString("D4");
                textBox_d.Text = d.ToString("D4");
            }

            float Scale;

            if (float.TryParse(textBox_scale.Text, out Scale))
            {
                scale = Scale;

                ms = (UInt16)(d * scale);
            }
            else
            {
                ms = 0;
            }

            textBox_ms.Text = ms.ToString("D5");
        }

        private void Form_JumpHelper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ',')
            {
                checkBox_st.Checked = true;
                x_st = Control.MousePosition.X;
                y_st = Control.MousePosition.Y;

                textBox_st.Text = "(" + x_st.ToString("D4") + ", " + y_st.ToString("D4") + ")";

                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                checkBox_sp.Checked = true;
                x_sp = Control.MousePosition.X;
                y_sp = Control.MousePosition.Y;

                textBox_sp.Text = "(" + x_sp.ToString("D4") + ", " + y_sp.ToString("D4") + ")";

                e.Handled = true;
            }

            if (e.KeyChar == ' ')
            {
                checkBox_st.Checked = false;
                checkBox_sp.Checked = false;

                x_st = 0;
                y_st = 0;
                x_sp = 0;
                y_sp = 0;

                textBox_st.Text = "";
                textBox_sp.Text = "";

                e.Handled = true;
            }
        }

        private void comboBox_port_MouseDown(object sender, MouseEventArgs e)
        {
            // 鼠标按下时 更新可用端口
        }
    }
}
