using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace JumpHelper
{
    public partial class Form_JumpHelper : Form
    {
        int x_now = 0;      // now 当前光标位置
        int y_now = 0;
        int x_st = 0;       // start 起点光标位置
        int y_st = 0;
        int x_sp = 0;       // stop 终点光标位置
        int y_sp = 0;
        int dx = 0;         // 横向坐标差
        int dy = 0;         // 纵向坐标差


        // ms = scale * d + b
        double ms = 0;
        double scale = 0;    // 1 像素距离 = ？ ms
        double d = 0;          // 起点 和 终点 间的直线距离
        double b = 0;
        
        // Message to Arduino
        int msg_angle_press = 0;
        int msg_ms = 0;
        int msg_angle_release = 0;
        int msg_send_time_left = 0;
        string msg_str = "";

        // 扫描端口
        private void port_scan(SerialPort port, ComboBox combobox)
        {
            // 清除选择列表内容
            combobox.Items.Clear();

            // 获取所有可用端口
            string[] ValidPort = SerialPort.GetPortNames();

            // 如果有可用端口
            if (ValidPort.Length > 0)
            {
                for (int i = 0; i < ValidPort.Length; i++)
                    combobox.Items.Add(ValidPort[i]);

                // 对可选列表进行排序

                // 更新显示内容为第一有效项
                combobox.Text = combobox.Items[0].ToString();

                // 如果此时已经有端口打开
                if ((port.IsOpen) && (ValidPort.Contains(port.PortName)))
                {
                    combobox.Text = port.PortName;
                }
            }
            else
            {
                combobox.Text = "无可用端口";
            }
        }
        
        // 通过端口名称设置端口
        private void port_set_by_name(SerialPort port, string new_name)
        {
            if(port.PortName != new_name)
            {
                try
                {
                    port.Close();
                }
                catch(Exception Err)
                {
                    MessageBox.Show(Err.ToString());
                }

                port.PortName = new_name;
                try
                {
                    port.Open();
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.ToString());
                }
            }
        }

        // 端口打开、关闭按钮
        private void port_switch_clicked(SerialPort port, Button button, ComboBox combobox)
        {
            // 若端口已经连接 断开
            if(port.IsOpen)
            {
                try
                {
                    port.Close();
                    button.Text = "连接";
                    button.BackColor = Color.ForestGreen;
                }
                catch(Exception Err)
                {
                    MessageBox.Show(Err.ToString());
                }
            }
            // 若端口现在连接 断开
            else
            {
                if(port.PortName == combobox.Text)
                {
                    try
                    {
                        port.Open();
                        combobox.Text = port.PortName;
                        button.Text = "断开";
                        button.BackColor = Color.OrangeRed;
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("请选择端口", "操作提示");
                }
            }
        }
        
        // 捕获当前坐标
        private void update_cusor_capture_now()
        {
            x_now = Control.MousePosition.X;
            y_now = Control.MousePosition.Y;

            textBox_now.Text = "(" + x_now.ToString("D4") + ", " + y_now.ToString("D4") + ")";
        }

        // 捕获起点坐标
        private void update_cusor_capture_start()
        {
            checkBox_st.Checked = true;

            x_st = Control.MousePosition.X;
            y_st = Control.MousePosition.Y;

            textBox_st.Text = "(" + x_st.ToString("D4") + ", " + y_st.ToString("D4") + ")";
            textBox_st.BackColor = Color.PaleGreen;
        }

        // 捕获终点坐标
        private void update_cusor_capture_stop()
        {
            checkBox_sp.Checked = true;

            x_sp = Control.MousePosition.X;
            y_sp = Control.MousePosition.Y;

            textBox_sp.Text = "(" + x_sp.ToString("D4") + ", " + y_sp.ToString("D4") + ")";
            textBox_sp.BackColor = Color.PaleGreen;
        }

        // 计算起点终点之间距离
        private void update_calculate_distance()
        {
            if (checkBox_st.Checked && checkBox_sp.Checked)
            {
                dx = Math.Abs(x_st - x_sp);
                dy = Math.Abs(y_st - y_sp);
            }
            else if (checkBox_st.Checked)
            {
                dx = Math.Abs(x_st - x_now);
                dy = Math.Abs(y_st - y_now);
            }
            else if (checkBox_sp.Checked)
            {
                dx = Math.Abs(x_sp - x_now);
                dy = Math.Abs(y_sp - y_now);
            }
            else
            {
                dx = 0;
                dy = 0;
                d = 0;
            }

            d = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
            
            textBox_x.Text = dx.ToString("D4");
            textBox_y.Text = dy.ToString("D4");
            textBox_d.Text = d.ToString("F3");
        }

        // 获取输入的比例系数
        private void update_input_scale()
        {
            double scale_cache;

            if (double.TryParse(textBox_scale.Text, out scale_cache))
            {
                scale = scale_cache;
            }
            else
            {
                scale = (float)1.00;
                MessageBox.Show("请输入[浮点型]数据(已设置为默认值)", "输入错误");
            }

            textBox_scale.Text = scale.ToString("F3");
        }

        // 获取输入的偏移量
        private void update_input_b()
        {
            double b_cache;

            if (double.TryParse(textBox_b.Text, out b_cache))
            {
                b = b_cache;
            }
            else
            {
                b = 0.00;
                MessageBox.Show("请输入[浮点型]数据(已设置为默认值)", "输入错误");
            }

            textBox_b.Text = b.ToString("F3");
        }

        // 计算触屏时间
        private void update_calculate_ms()
        {
            ms = d * scale + b;
            textBox_ms.Text = ms.ToString("F3");
        }

        private void update_msg_ms()
        {
            if (checkBox_st.Checked && checkBox_sp.Checked)
            {
                msg_ms = (int)ms;

                textBox_msg_ms.Text = msg_ms.ToString();
                textBox_msg_ms.BackColor = Color.PaleGreen;
            }
        }

        private void update_msg_send_time_left()
        {
            if (checkBox_st.Checked && checkBox_sp.Checked)
            {
                msg_send_time_left -= 100;
            }
        }

        // 获取输入的按压角度
        private void update_input_angle_press()
        {
            int angle_press_cache = 0;

            if (int.TryParse(textBox_msg_angle_press.Text, out angle_press_cache))
            {
                msg_angle_press = angle_press_cache;
            }
            else
            {
                msg_angle_press = 65;
                MessageBox.Show("请输入[整型]数据(已设置为默认值)", "输入错误");
            }

            textBox_msg_angle_press.Text = msg_angle_press.ToString();
        }

        // 获取输入的按压时间
        private void update_input_msg_ms()
        {
            int msg_ms_cache;

            if (int.TryParse(textBox_msg_ms.Text, out msg_ms_cache))
            {
                msg_ms = msg_ms_cache;
            }
            else
            {
                msg_ms = 200;
                MessageBox.Show("请输入[整型]数据(已设置为默认值)", "输入错误");
            }

            textBox_msg_ms.Text = msg_ms.ToString();
        }

        // 获取输入的释放角度
        private void update_input_angle_release()
        {
            int angle_release_cache = 0;

            if (int.TryParse(textBox_msg_angle_release.Text, out angle_release_cache))
            {
                msg_angle_release = angle_release_cache;
            }
            else
            {
                msg_angle_release = 75;
                MessageBox.Show("请输入[整型]数据(已设置为默认值)", "输入错误");
            }

            textBox_msg_angle_release.Text = msg_angle_release.ToString();
        }

        // 重置 还有多长时间发出控制命令
        private void ms_to_send_cnt_reset()
        {
            msg_send_time_left = 500;
        }

        // 发送控制命令
        private void update_send_msg_to_arduino()
        {
            if (checkBox_st.Checked && checkBox_sp.Checked && (msg_send_time_left < 0))
            {
                msg_str = textBox_msg_angle_press.Text
                                    + ","
                                    + textBox_msg_ms.Text
                                    + ","
                                    + textBox_msg_angle_release.Text;

                if (serialPort_jump.IsOpen)
                {
                    try
                    {
                        serialPort_jump.WriteLine(msg_str);
                    }
                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.ToString());
                    }
                }

                textBox_st.Text = "";
                textBox_sp.Text = "";

                textBox_st.BackColor = Color.PaleTurquoise;
                textBox_sp.BackColor = Color.PaleTurquoise;
                textBox_msg_ms.BackColor = Color.PaleTurquoise;

                checkBox_st.Checked = false;
                checkBox_sp.Checked = false;
            }
        }

        // 主窗口 创建
        public Form_JumpHelper()
        {
            InitializeComponent();
        }

        // 主窗口 加载
        private void Form_JumpHelper_Load(object sender, EventArgs e)
        {
            port_scan(serialPort_jump, comboBox_port);

            update_input_scale();
            update_input_b();
            update_input_angle_press();
            update_input_msg_ms();
            update_input_angle_release();

            ms_to_send_cnt_reset();
        }

        // 定时器中断处理
        private void timer_jump_Tick(object sender, EventArgs e)
        {
            update_cusor_capture_now();
            update_calculate_distance();
            update_calculate_ms();
            update_msg_ms();
            update_msg_send_time_left();

            update_send_msg_to_arduino();
        }

        // 鼠标点下端口选择控件瞬间 更新可用端口列表
        private void comboBox_port_MouseDown(object sender, MouseEventArgs e)
        {
            port_scan(serialPort_jump, comboBox_port);
        }

        // 通过端口名 切换端口
        private void comboBox_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            port_set_by_name(serialPort_jump, comboBox_port.Text);
        }

        // 通过按钮打开、关闭端口
        private void button_port_switch_Click(object sender, EventArgs e)
        {
            port_switch_clicked(serialPort_jump, button_port_switch, comboBox_port);
        }

        // 通过键盘上的 ← → 按键获取 起点、终点坐标
        private void Form_JumpHelper_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ms_to_send_cnt_reset();
                update_cusor_capture_start();

                e.Handled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                ms_to_send_cnt_reset();
                update_cusor_capture_stop();

                e.Handled = true;
            }
        }

        private void textBox_scale_KeyDown(object sender, KeyEventArgs e)
        {
            if(Keys.Enter == e.KeyCode)
            {
                update_input_scale();
                e.Handled = true;
            }
        }

        private void textBox_b_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                update_input_b();
                e.Handled = true;
            }
        }

        private void textBox_angle_press_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                update_input_angle_press();
                e.Handled = true;
            }
        }

        private void textBox_ms_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                update_input_msg_ms();
                e.Handled = true;
            }
        }

        private void textBox_angle_release_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                update_input_angle_release();
                e.Handled = true;
            }
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            msg_str = textBox_msg_angle_press.Text
                                + ","
                                + textBox_msg_ms.Text
                                + ","
                                + textBox_msg_angle_release.Text;

            if (serialPort_jump.IsOpen)
            {
                try
                {
                    serialPort_jump.WriteLine(msg_str);
                }
                catch (Exception Err)
                {
                    MessageBox.Show(Err.ToString());
                }
            }

            textBox_st.BackColor = Color.PaleTurquoise;
            textBox_sp.BackColor = Color.PaleTurquoise;
            textBox_msg_ms.BackColor = Color.PaleTurquoise;

            checkBox_st.Checked = false;
            checkBox_sp.Checked = false;
        }
    }
}
