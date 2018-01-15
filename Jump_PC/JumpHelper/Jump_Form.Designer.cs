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
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.textBox_msg_angle_press = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.textBox_now = new System.Windows.Forms.TextBox();
            this.label1_now = new System.Windows.Forms.Label();
            this.serialPort_jump = new System.IO.Ports.SerialPort(this.components);
            this.timer_jump = new System.Windows.Forms.Timer(this.components);
            this.checkBox_st = new System.Windows.Forms.CheckBox();
            this.checkBox_sp = new System.Windows.Forms.CheckBox();
            this.groupBox_msg = new System.Windows.Forms.GroupBox();
            this.textBox_msg_angle_release = new System.Windows.Forms.TextBox();
            this.textBox_msg_ms = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_jumped_land = new System.Windows.Forms.CheckBox();
            this.textBox_jumped_land = new System.Windows.Forms.TextBox();
            this.textBox_jumped_sp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox_jumped_sp = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox_msg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_port_switch
            // 
            this.button_port_switch.BackColor = System.Drawing.Color.Yellow;
            this.button_port_switch.Location = new System.Drawing.Point(528, 9);
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
            this.label_st.Location = new System.Drawing.Point(27, 26);
            this.label_st.Name = "label_st";
            this.label_st.Size = new System.Drawing.Size(95, 21);
            this.label_st.TabIndex = 2;
            this.label_st.Text = "起点[←]";
            // 
            // textBox_st
            // 
            this.textBox_st.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_st.Enabled = false;
            this.textBox_st.Location = new System.Drawing.Point(163, 19);
            this.textBox_st.Name = "textBox_st";
            this.textBox_st.Size = new System.Drawing.Size(139, 31);
            this.textBox_st.TabIndex = 3;
            this.textBox_st.Text = "(0000, 0000)";
            this.textBox_st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sp
            // 
            this.textBox_sp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_sp.Enabled = false;
            this.textBox_sp.Location = new System.Drawing.Point(475, 19);
            this.textBox_sp.Name = "textBox_sp";
            this.textBox_sp.Size = new System.Drawing.Size(139, 31);
            this.textBox_sp.TabIndex = 5;
            this.textBox_sp.Text = "(0000, 0000)";
            this.textBox_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sp
            // 
            this.label_sp.AutoSize = true;
            this.label_sp.Location = new System.Drawing.Point(353, 22);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(95, 21);
            this.label_sp.TabIndex = 4;
            this.label_sp.Text = "目标[→]";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_x.Enabled = false;
            this.textBox_x.Location = new System.Drawing.Point(163, 56);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(74, 31);
            this.textBox_x.TabIndex = 7;
            this.textBox_x.Text = "0000";
            this.textBox_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(27, 59);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(52, 21);
            this.label_d.TabIndex = 6;
            this.label_d.Text = "距离";
            // 
            // textBox_k
            // 
            this.textBox_k.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_k.Location = new System.Drawing.Point(217, 23);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(125, 31);
            this.textBox_k.TabIndex = 9;
            this.textBox_k.Text = "1.000";
            this.textBox_k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_k.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_scale_KeyDown);
            // 
            // textBox_msg_angle_press
            // 
            this.textBox_msg_angle_press.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_angle_press.Location = new System.Drawing.Point(64, 27);
            this.textBox_msg_angle_press.Name = "textBox_msg_angle_press";
            this.textBox_msg_angle_press.Size = new System.Drawing.Size(45, 31);
            this.textBox_msg_angle_press.TabIndex = 11;
            this.textBox_msg_angle_press.Text = "65";
            this.textBox_msg_angle_press.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_angle_press.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_angle_press_KeyDown);
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(526, 30);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(31, 21);
            this.label_ms.TabIndex = 10;
            this.label_ms.Text = "度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "△x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "△y";
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_y.Enabled = false;
            this.textBox_y.Location = new System.Drawing.Point(331, 56);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(74, 31);
            this.textBox_y.TabIndex = 14;
            this.textBox_y.Text = "0000";
            this.textBox_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "d";
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(475, 56);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(139, 31);
            this.textBox_d.TabIndex = 16;
            this.textBox_d.Text = "0000.000";
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "ms后恢复到";
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg.Enabled = false;
            this.textBox_msg.Location = new System.Drawing.Point(12, 435);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_msg.Size = new System.Drawing.Size(620, 92);
            this.textBox_msg.TabIndex = 20;
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 12);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(510, 29);
            this.comboBox_port.TabIndex = 22;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox_port_SelectedIndexChanged);
            this.comboBox_port.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox_port_MouseDown);
            // 
            // textBox_now
            // 
            this.textBox_now.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_now.Enabled = false;
            this.textBox_now.Location = new System.Drawing.Point(175, 47);
            this.textBox_now.Name = "textBox_now";
            this.textBox_now.Size = new System.Drawing.Size(457, 31);
            this.textBox_now.TabIndex = 24;
            this.textBox_now.Text = "(0000, 0000)";
            this.textBox_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1_now
            // 
            this.label1_now.AutoSize = true;
            this.label1_now.Location = new System.Drawing.Point(18, 50);
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
            this.checkBox_st.Location = new System.Drawing.Point(142, 26);
            this.checkBox_st.Name = "checkBox_st";
            this.checkBox_st.Size = new System.Drawing.Size(15, 14);
            this.checkBox_st.TabIndex = 25;
            this.checkBox_st.UseVisualStyleBackColor = true;
            // 
            // checkBox_sp
            // 
            this.checkBox_sp.AutoSize = true;
            this.checkBox_sp.Location = new System.Drawing.Point(454, 26);
            this.checkBox_sp.Name = "checkBox_sp";
            this.checkBox_sp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sp.TabIndex = 26;
            this.checkBox_sp.UseVisualStyleBackColor = true;
            // 
            // groupBox_msg
            // 
            this.groupBox_msg.Controls.Add(this.textBox_msg_angle_release);
            this.groupBox_msg.Controls.Add(this.textBox_msg_ms);
            this.groupBox_msg.Controls.Add(this.textBox_msg_angle_press);
            this.groupBox_msg.Controls.Add(this.button_test);
            this.groupBox_msg.Controls.Add(this.label2);
            this.groupBox_msg.Controls.Add(this.label1);
            this.groupBox_msg.Controls.Add(this.label_ms);
            this.groupBox_msg.Controls.Add(this.label11);
            this.groupBox_msg.Location = new System.Drawing.Point(12, 257);
            this.groupBox_msg.Name = "groupBox_msg";
            this.groupBox_msg.Size = new System.Drawing.Size(620, 65);
            this.groupBox_msg.TabIndex = 27;
            this.groupBox_msg.TabStop = false;
            this.groupBox_msg.Text = "... 秒后控制舵机:";
            // 
            // textBox_msg_angle_release
            // 
            this.textBox_msg_angle_release.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_angle_release.Location = new System.Drawing.Point(475, 27);
            this.textBox_msg_angle_release.Name = "textBox_msg_angle_release";
            this.textBox_msg_angle_release.Size = new System.Drawing.Size(45, 31);
            this.textBox_msg_angle_release.TabIndex = 20;
            this.textBox_msg_angle_release.Text = "75";
            this.textBox_msg_angle_release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_angle_release.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_angle_release_KeyDown);
            // 
            // textBox_msg_ms
            // 
            this.textBox_msg_ms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg_ms.Location = new System.Drawing.Point(217, 27);
            this.textBox_msg_ms.Name = "textBox_msg_ms";
            this.textBox_msg_ms.Size = new System.Drawing.Size(125, 31);
            this.textBox_msg_ms.TabIndex = 13;
            this.textBox_msg_ms.Text = "200";
            this.textBox_msg_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_msg_ms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ms_KeyDown);
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.Yellow;
            this.button_test.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_test.Location = new System.Drawing.Point(554, 24);
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
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "以";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "度触屏";
            // 
            // textBox_ms
            // 
            this.textBox_ms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_ms.Enabled = false;
            this.textBox_ms.Location = new System.Drawing.Point(31, 24);
            this.textBox_ms.Name = "textBox_ms";
            this.textBox_ms.Size = new System.Drawing.Size(101, 31);
            this.textBox_ms.TabIndex = 14;
            this.textBox_ms.Text = "0000.000";
            this.textBox_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(289, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "WeChat_Jump by guo_zhen_jiang@163.com 2018-01-12";
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_b.Location = new System.Drawing.Point(475, 23);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(139, 31);
            this.textBox_b.TabIndex = 31;
            this.textBox_b.Text = "0.000";
            this.textBox_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_b_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_st);
            this.groupBox1.Controls.Add(this.checkBox_st);
            this.groupBox1.Controls.Add(this.label_d);
            this.groupBox1.Controls.Add(this.textBox_d);
            this.groupBox1.Controls.Add(this.textBox_st);
            this.groupBox1.Controls.Add(this.textBox_x);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_sp);
            this.groupBox1.Controls.Add(this.label_sp);
            this.groupBox1.Controls.Add(this.textBox_y);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox_sp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 98);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "起跳之前";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBox_jumped_land);
            this.groupBox2.Controls.Add(this.textBox_jumped_land);
            this.groupBox2.Controls.Add(this.textBox_jumped_sp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.checkBox_jumped_sp);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 101);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "跳跃之后";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "落点[↓]";
            // 
            // checkBox_jumped_land
            // 
            this.checkBox_jumped_land.AutoSize = true;
            this.checkBox_jumped_land.Location = new System.Drawing.Point(142, 31);
            this.checkBox_jumped_land.Name = "checkBox_jumped_land";
            this.checkBox_jumped_land.Size = new System.Drawing.Size(15, 14);
            this.checkBox_jumped_land.TabIndex = 25;
            this.checkBox_jumped_land.UseVisualStyleBackColor = true;
            // 
            // textBox_jumped_land
            // 
            this.textBox_jumped_land.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_jumped_land.Enabled = false;
            this.textBox_jumped_land.Location = new System.Drawing.Point(163, 24);
            this.textBox_jumped_land.Name = "textBox_jumped_land";
            this.textBox_jumped_land.Size = new System.Drawing.Size(139, 31);
            this.textBox_jumped_land.TabIndex = 3;
            this.textBox_jumped_land.Text = "(0000, 0000)";
            this.textBox_jumped_land.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_jumped_sp
            // 
            this.textBox_jumped_sp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_jumped_sp.Enabled = false;
            this.textBox_jumped_sp.Location = new System.Drawing.Point(475, 24);
            this.textBox_jumped_sp.Name = "textBox_jumped_sp";
            this.textBox_jumped_sp.Size = new System.Drawing.Size(139, 31);
            this.textBox_jumped_sp.TabIndex = 5;
            this.textBox_jumped_sp.Text = "(0000, 0000)";
            this.textBox_jumped_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "目标[↑]";
            // 
            // checkBox_jumped_sp
            // 
            this.checkBox_jumped_sp.AutoSize = true;
            this.checkBox_jumped_sp.Location = new System.Drawing.Point(454, 31);
            this.checkBox_jumped_sp.Name = "checkBox_jumped_sp";
            this.checkBox_jumped_sp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_jumped_sp.TabIndex = 26;
            this.checkBox_jumped_sp.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox_ms);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_k);
            this.groupBox3.Controls.Add(this.textBox_b);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 63);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ms = k * d + b";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(383, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "* d +";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "系数收敛信息：(Xn, Yn) = ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(331, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 31);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "(0000, 0000)";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_JumpHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox_msg);
            this.Controls.Add(this.textBox_now);
            this.Controls.Add(this.label1_now);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.button_port_switch);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_JumpHelper";
            this.Text = "JumpHelper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_JumpHelper_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_JumpHelper_KeyDown);
            this.groupBox_msg.ResumeLayout(false);
            this.groupBox_msg.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.TextBox textBox_msg_angle_press;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textBox_now;
        private System.Windows.Forms.Label label1_now;
        private System.IO.Ports.SerialPort serialPort_jump;
        private System.Windows.Forms.Timer timer_jump;
        private System.Windows.Forms.CheckBox checkBox_st;
        private System.Windows.Forms.CheckBox checkBox_sp;
        private System.Windows.Forms.GroupBox groupBox_msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_msg_angle_release;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_msg_ms;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.TextBox textBox_ms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_jumped_land;
        private System.Windows.Forms.TextBox textBox_jumped_land;
        private System.Windows.Forms.TextBox textBox_jumped_sp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_jumped_sp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}

