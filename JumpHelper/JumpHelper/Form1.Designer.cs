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
            this.textBox_ms = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.label1_msg = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.textBox_now = new System.Windows.Forms.TextBox();
            this.label1_now = new System.Windows.Forms.Label();
            this.serialPort_jump = new System.IO.Ports.SerialPort(this.components);
            this.timer_jump = new System.Windows.Forms.Timer(this.components);
            this.checkBox_st = new System.Windows.Forms.CheckBox();
            this.checkBox_sp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_port_switch
            // 
            this.button_port_switch.BackColor = System.Drawing.Color.Yellow;
            this.button_port_switch.Location = new System.Drawing.Point(267, 12);
            this.button_port_switch.Name = "button_port_switch";
            this.button_port_switch.Size = new System.Drawing.Size(104, 31);
            this.button_port_switch.TabIndex = 1;
            this.button_port_switch.Text = "连接";
            this.button_port_switch.UseVisualStyleBackColor = false;
            // 
            // label_st
            // 
            this.label_st.AutoSize = true;
            this.label_st.Location = new System.Drawing.Point(12, 106);
            this.label_st.Name = "label_st";
            this.label_st.Size = new System.Drawing.Size(94, 21);
            this.label_st.TabIndex = 2;
            this.label_st.Text = "起点坐标";
            // 
            // textBox_st
            // 
            this.textBox_st.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_st.Enabled = false;
            this.textBox_st.Location = new System.Drawing.Point(133, 103);
            this.textBox_st.Name = "textBox_st";
            this.textBox_st.Size = new System.Drawing.Size(238, 31);
            this.textBox_st.TabIndex = 3;
            this.textBox_st.Text = "(0000, 0000)";
            this.textBox_st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_sp
            // 
            this.textBox_sp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_sp.Enabled = false;
            this.textBox_sp.Location = new System.Drawing.Point(133, 140);
            this.textBox_sp.Name = "textBox_sp";
            this.textBox_sp.Size = new System.Drawing.Size(238, 31);
            this.textBox_sp.TabIndex = 5;
            this.textBox_sp.Text = "(0000, 0000)";
            this.textBox_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_sp
            // 
            this.label_sp.AutoSize = true;
            this.label_sp.Location = new System.Drawing.Point(12, 143);
            this.label_sp.Name = "label_sp";
            this.label_sp.Size = new System.Drawing.Size(94, 21);
            this.label_sp.TabIndex = 4;
            this.label_sp.Text = "终点坐标";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_x.Enabled = false;
            this.textBox_x.Location = new System.Drawing.Point(133, 177);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(51, 31);
            this.textBox_x.TabIndex = 7;
            this.textBox_x.Text = "0000";
            this.textBox_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(12, 180);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(94, 21);
            this.label_d.TabIndex = 6;
            this.label_d.Text = "像素距离";
            // 
            // textBox_scale
            // 
            this.textBox_scale.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_scale.Location = new System.Drawing.Point(192, 214);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(141, 31);
            this.textBox_scale.TabIndex = 9;
            this.textBox_scale.Text = "5.00";
            this.textBox_scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_scale
            // 
            this.label_scale.AutoSize = true;
            this.label_scale.Location = new System.Drawing.Point(12, 217);
            this.label_scale.Name = "label_scale";
            this.label_scale.Size = new System.Drawing.Size(94, 21);
            this.label_scale.TabIndex = 8;
            this.label_scale.Text = "换算公式";
            // 
            // textBox_ms
            // 
            this.textBox_ms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_ms.Enabled = false;
            this.textBox_ms.Location = new System.Drawing.Point(133, 251);
            this.textBox_ms.Name = "textBox_ms";
            this.textBox_ms.Size = new System.Drawing.Size(200, 31);
            this.textBox_ms.TabIndex = 11;
            this.textBox_ms.Text = "00000";
            this.textBox_ms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.Location = new System.Drawing.Point(12, 254);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(94, 21);
            this.label_ms.TabIndex = 10;
            this.label_ms.Text = "触屏时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y";
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_y.Enabled = false;
            this.textBox_y.Location = new System.Drawing.Point(223, 177);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(51, 31);
            this.textBox_y.TabIndex = 14;
            this.textBox_y.Text = "0000";
            this.textBox_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "D";
            // 
            // textBox_d
            // 
            this.textBox_d.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_d.Enabled = false;
            this.textBox_d.Location = new System.Drawing.Point(320, 177);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(51, 31);
            this.textBox_d.TabIndex = 16;
            this.textBox_d.Text = "0000";
            this.textBox_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "1像素=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "ms";
            // 
            // textBox_msg
            // 
            this.textBox_msg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_msg.Enabled = false;
            this.textBox_msg.Location = new System.Drawing.Point(16, 324);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(359, 90);
            this.textBox_msg.TabIndex = 20;
            // 
            // label1_msg
            // 
            this.label1_msg.AutoSize = true;
            this.label1_msg.Location = new System.Drawing.Point(12, 300);
            this.label1_msg.Name = "label1_msg";
            this.label1_msg.Size = new System.Drawing.Size(94, 21);
            this.label1_msg.TabIndex = 21;
            this.label1_msg.Text = "提示信息";
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(12, 12);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(249, 29);
            this.comboBox_port.TabIndex = 22;
            this.comboBox_port.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox_port_MouseDown);
            // 
            // textBox_now
            // 
            this.textBox_now.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox_now.Enabled = false;
            this.textBox_now.Location = new System.Drawing.Point(133, 66);
            this.textBox_now.Name = "textBox_now";
            this.textBox_now.Size = new System.Drawing.Size(238, 31);
            this.textBox_now.TabIndex = 24;
            this.textBox_now.Text = "(0000, 0000)";
            this.textBox_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1_now
            // 
            this.label1_now.AutoSize = true;
            this.label1_now.Location = new System.Drawing.Point(12, 69);
            this.label1_now.Name = "label1_now";
            this.label1_now.Size = new System.Drawing.Size(94, 21);
            this.label1_now.TabIndex = 23;
            this.label1_now.Text = "当前坐标";
            // 
            // serialPort_jump
            // 
            this.serialPort_jump.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_jump_DataReceived);
            // 
            // timer_jump
            // 
            this.timer_jump.Enabled = true;
            this.timer_jump.Tick += new System.EventHandler(this.timer_jump_Tick);
            // 
            // checkBox_st
            // 
            this.checkBox_st.AutoSize = true;
            this.checkBox_st.Location = new System.Drawing.Point(112, 110);
            this.checkBox_st.Name = "checkBox_st";
            this.checkBox_st.Size = new System.Drawing.Size(15, 14);
            this.checkBox_st.TabIndex = 25;
            this.checkBox_st.UseVisualStyleBackColor = true;
            // 
            // checkBox_sp
            // 
            this.checkBox_sp.AutoSize = true;
            this.checkBox_sp.Location = new System.Drawing.Point(112, 147);
            this.checkBox_sp.Name = "checkBox_sp";
            this.checkBox_sp.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sp.TabIndex = 26;
            this.checkBox_sp.UseVisualStyleBackColor = true;
            // 
            // Form_JumpHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 424);
            this.Controls.Add(this.checkBox_sp);
            this.Controls.Add(this.checkBox_st);
            this.Controls.Add(this.textBox_now);
            this.Controls.Add(this.label1_now);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label1_msg);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ms);
            this.Controls.Add(this.label_ms);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_JumpHelper";
            this.Text = "JumpHelper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_JumpHelper_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_JumpHelper_KeyPress);
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
        private System.Windows.Forms.TextBox textBox_ms;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Label label1_msg;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textBox_now;
        private System.Windows.Forms.Label label1_now;
        private System.IO.Ports.SerialPort serialPort_jump;
        private System.Windows.Forms.Timer timer_jump;
        private System.Windows.Forms.CheckBox checkBox_st;
        private System.Windows.Forms.CheckBox checkBox_sp;
    }
}

