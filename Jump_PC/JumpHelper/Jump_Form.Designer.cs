namespace JumpHelper
{
    partial class Form_JumpHelper
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_port_switch = new System.Windows.Forms.Button();
            this.label_st = new System.Windows.Forms.Label();
            this.textBox_st = new System.Windows.Forms.TextBox();
            this.textBox_sp = new System.Windows.Forms.TextBox();
            this.label_sp = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label_d = new System.Windows.Forms.Label();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.label_scale = new System.Windows.Forms.Label();
            this.textBox_msg_angle_press = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.textBox_now = new System.Windows.Forms.TextBox();
            this.label1_now = new System.Windows.Forms.Label();
            this.serialPort_jump = new System.IO.Ports.SerialPort(this.components);
            this.timer_jump = new System.Windows.Forms.Timer(this.components);
            this.checkBox_st = new System.Windows.Forms.CheckBox();
            this.checkBox_sp = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_msg_angle_release = new System.Windows.Forms.TextBox();
            this.textBox_msg_ms = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_port_switch
            // 
            this.button_port_switch.BackColor = System.Drawing.Color.Yellow;
            this.button_port_switch.Location = new System.Drawing.Point(410, 12);
            this.button_port_switch.Name = "button_port_switch";
            this.button_port_switch.Size = new System.Drawing.Size(104, 32);
            this.button_port_switch.TabIndex = 1;
            this.button_port_switch.Text = "连接";
            this.button_port_switch.UseVisualStyleBackColor = false;
            this.button_port_switch.Click += new System.EventHandler(this.button_port_switch_Click);
            // 
            // label_st
            // 
            this.label_st.AutoSize = true;
            this.label_st.Location = new System.Drawing.Point(8, 92);
            this.label_st.Name = "label_st";
            this.label_st.Size = new System.Drawing.Size(94, 21);
            this.label_st.TabIndex = 2;
            this.label_st.Text = "起点坐标";
            // 
            // textBox_st
            // 
            this.textBox_st.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_st.Enabled = false;
            this.textBox_st.Location = new System.Drawing.Point(133, 89);
            this.textBox_st.Name = "textBox_st";
            this.textBox_st.Size = new System.Drawing.Size(381, 31);
            this.textBox_st.TabIndex = 3;
            this.textBox_st.Text = "(0000, 0000)";
            this.textBox_st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sp
            // 
            this.textBox_sp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_sp.Enabled = false;
            this.textBox_sp.Location = new System.Drawing.Point(133, 126);
            this.textBox_sp.Name = "textBox_sp";
            this.textBox_sp.Size = new System.Drawing.Size(381, 31);
            this.textBox_sp.TabIndex = 5;
            this.textBox_sp.Text = "(0000, 0000)";
            this.textBox_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sp
            // 
            this.label_sp.AutoSize = true;
            this.label_sp.Location = new System.Drawing.Point(8, 129);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(94, 21);
            this.label_sp.TabIndex = 4;
            this.label_sp.Text = "终点坐标";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_x.Enabled = false;
            this.textBox_x.Location = new System.Drawing.Point(155, 163);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(73, 31);
            this.textBox_x.TabIndex = 7;
            this.textBox_x.Text = "0000";
            this.textBox_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(8, 165);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(94, 21);
            this.label_d.TabIndex = 6;
            this.label_d.Text = "像素距离";
            // 
            // textBox_scale
            // 
            this.textBox_scale.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_scale.Location = new System.Drawing.Point(183, 200);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(148, 31);
            this.textBox_scale.TabIndex = 9;
            this.textBox_scale.Text = "1.000";
            this.textBox_scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_scale_KeyDown);
            // 
            // label_scale
            // 
            this.label_scale.AutoSize = true;
            this.label_scale.Location = new System.Drawing.Point(8, 204);
            this.label_scale.Name = "label_scale";
            this.label_scale.Size = new System.Drawing.Size(94, 21);
            this.label_scale.TabIndex = 8;
            this.label_scale.Text = "算法系数";
            // 
            // textBox_msg_angle_press
            // 
            this.textBox_msg_angle_press.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_angle_press.Location = new System.Drawing.Point(34, 30);
            this.textBox_msg_angle_press.Name = "textBox_msg_angle_press";
            this.textBox_msg_angle_press.Size = new System.Drawing.Size(55, 31);
            this.textBox_msg_angle_press.TabIndex = 11;
            this.textBox_msg_angle_press.Text = "65";
            this.textBox_msg_angle_press.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_angle_press.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_angle_press_KeyDown);
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(390, 35);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(31, 21);
            this.label_ms.TabIndex = 10;
            this.label_ms.Text = "度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "△X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "△Y";
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_y.Enabled = false;
            this.textBox_y.Location = new System.Drawing.Point(282, 163);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(73, 31);
            this.textBox_y.TabIndex = 14;
            this.textBox_y.Text = "0000";
            this.textBox_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "D";
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(388, 163);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(126, 31);
            this.textBox_d.TabIndex = 16;
            this.textBox_d.Text = "00000.000";
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(107, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Scale";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "ms恢复到";
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg.Enabled = false;
            this.textBox_msg.Location = new System.Drawing.Point(12, 357);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(502, 104);
            this.textBox_msg.TabIndex = 20;
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 12);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(386, 29);
            this.comboBox_port.TabIndex = 22;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox_port_SelectedIndexChanged);
            this.comboBox_port.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox_port_MouseDown);
            // 
            // textBox_now
            // 
            this.textBox_now.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_now.Enabled = false;
            this.textBox_now.Location = new System.Drawing.Point(133, 49);
            this.textBox_now.Name = "textBox_now";
            this.textBox_now.Size = new System.Drawing.Size(381, 31);
            this.textBox_now.TabIndex = 24;
            this.textBox_now.Text = "(0000, 0000)";
            this.textBox_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1_now
            // 
            this.label1_now.AutoSize = true;
            this.label1_now.Location = new System.Drawing.Point(8, 52);
            this.label1_now.Name = "label1_now";
            this.label1_now.Size = new System.Drawing.Size(94, 21);
            this.label1_now.TabIndex = 23;
            this.label1_now.Text = "当前坐标";
            // 
            // serialPort_jump
            // 
            this.serialPort_jump.BaudRate = 115200;
            // 
            // timer_jump
            // 
            this.timer_jump.Enabled = true;
            this.timer_jump.Tick += new System.EventHandler(this.timer_jump_Tick);
            // 
            // checkBox_st
            // 
            this.checkBox_st.AutoSize = true;
            this.checkBox_st.Location = new System.Drawing.Point(111, 93);
            this.checkBox_st.Name = "checkBox_st";
            this.checkBox_st.Size = new System.Drawing.Size(15, 14);
            this.checkBox_st.TabIndex = 25;
            this.checkBox_st.UseVisualStyleBackColor = true;
            // 
            // checkBox_sp
            // 
            this.checkBox_sp.AutoSize = true;
            this.checkBox_sp.Location = new System.Drawing.Point(111, 133);
            this.checkBox_sp.Name = "checkBox_sp";
            this.checkBox_sp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sp.TabIndex = 26;
            this.checkBox_sp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_msg_angle_release);
            this.groupBox1.Controls.Add(this.textBox_msg_ms);
            this.groupBox1.Controls.Add(this.textBox_msg_angle_press);
            this.groupBox1.Controls.Add(this.button_test);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_ms);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 77);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "触屏信息";
            // 
            // textBox_msg_angle_release
            // 
            this.textBox_msg_angle_release.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_angle_release.Location = new System.Drawing.Point(346, 30);
            this.textBox_msg_angle_release.Name = "textBox_msg_angle_release";
            this.textBox_msg_angle_release.Size = new System.Drawing.Size(47, 31);
            this.textBox_msg_angle_release.TabIndex = 20;
            this.textBox_msg_angle_release.Text = "75";
            this.textBox_msg_angle_release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_angle_release.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_angle_release_KeyDown);
            // 
            // textBox_msg_ms
            // 
            this.textBox_msg_ms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_ms.Location = new System.Drawing.Point(175, 30);
            this.textBox_msg_ms.Name = "textBox_msg_ms";
            this.textBox_msg_ms.Size = new System.Drawing.Size(64, 31);
            this.textBox_msg_ms.TabIndex = 13;
            this.textBox_msg_ms.Text = "200";
            this.textBox_msg_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_ms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ms_KeyDown);
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.Yellow;
            this.button_test.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_test.Location = new System.Drawing.Point(428, 30);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(60, 32);
            this.button_test.TabIndex = 22;
            this.button_test.Text = "测试";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "以";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "度接触";
            // 
            // textBox_ms
            // 
            this.textBox_ms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_ms.Enabled = false;
            this.textBox_ms.Location = new System.Drawing.Point(238, 237);
            this.textBox_ms.Name = "textBox_ms";
            this.textBox_ms.Size = new System.Drawing.Size(276, 31);
            this.textBox_ms.TabIndex = 14;
            this.textBox_ms.Text = "000.000";
            this.textBox_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "ms = Scale * D + b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(172, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "WeChat_Jump by guo_zhen_jiang@163.com 2018-01-12";
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_b.Location = new System.Drawing.Point(363, 200);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(148, 31);
            this.textBox_b.TabIndex = 31;
            this.textBox_b.Text = "0.000";
            this.textBox_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_b_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(337, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "b";
            // 
            // Form_JumpHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_sp);
            this.Controls.Add(this.checkBox_st);
            this.Controls.Add(this.textBox_now);
            this.Controls.Add(this.label1_now);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_scale);
            this.Controls.Add(this.label_scale);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.textBox_sp);
            this.Controls.Add(this.label_sp);
            this.Controls.Add(this.textBox_st);
            this.Controls.Add(this.label_st);
            this.Controls.Add(this.button_port_switch);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_JumpHelper";
            this.Text = "JumpHelper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_JumpHelper_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_JumpHelper_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_port_switch;
        private System.Windows.Forms.Label label_st;
        private System.Windows.Forms.TextBox textBox_st;
        private System.Windows.Forms.TextBox textBox_sp;
        private System.Windows.Forms.Label label_sp;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.Label label_scale;
        private System.Windows.Forms.TextBox textBox_msg_angle_press;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textBox_now;
        private System.Windows.Forms.Label label1_now;
        private System.IO.Ports.SerialPort serialPort_jump;
        private System.Windows.Forms.Timer timer_jump;
        private System.Windows.Forms.CheckBox checkBox_st;
        private System.Windows.Forms.CheckBox checkBox_sp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_msg_angle_release;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_msg_ms;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.TextBox textBox_ms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label5;
    }
}

