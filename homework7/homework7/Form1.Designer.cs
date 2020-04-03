namespace homework7
{
    partial class Form1
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
            this.draw = new System.Windows.Forms.Button();
            this.depthTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lengTrackBar = new System.Windows.Forms.TrackBar();
            this.per1TrackBar = new System.Windows.Forms.TrackBar();
            this.per2TrackBar = new System.Windows.Forms.TrackBar();
            this.th1TrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.per1Label = new System.Windows.Forms.Label();
            this.per2Label = new System.Windows.Forms.Label();
            this.th1Label = new System.Windows.Forms.Label();
            this.th2TrackBar = new System.Windows.Forms.TrackBar();
            this.th2Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.depthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2TrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(782, 4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(75, 23);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // depthTrackBar
            // 
            this.depthTrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.depthTrackBar.LargeChange = 1;
            this.depthTrackBar.Location = new System.Drawing.Point(758, 33);
            this.depthTrackBar.Maximum = 20;
            this.depthTrackBar.Minimum = 1;
            this.depthTrackBar.Name = "depthTrackBar";
            this.depthTrackBar.Size = new System.Drawing.Size(139, 56);
            this.depthTrackBar.TabIndex = 1;
            this.depthTrackBar.Value = 1;
            this.depthTrackBar.Scroll += new System.EventHandler(this.depthTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // lengTrackBar
            // 
            this.lengTrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lengTrackBar.LargeChange = 1;
            this.lengTrackBar.Location = new System.Drawing.Point(758, 93);
            this.lengTrackBar.Maximum = 200;
            this.lengTrackBar.Minimum = 1;
            this.lengTrackBar.Name = "lengTrackBar";
            this.lengTrackBar.Size = new System.Drawing.Size(139, 56);
            this.lengTrackBar.TabIndex = 1;
            this.lengTrackBar.Value = 1;
            this.lengTrackBar.Scroll += new System.EventHandler(this.lengTrackBar_Scroll);
            // 
            // per1TrackBar
            // 
            this.per1TrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.per1TrackBar.LargeChange = 1;
            this.per1TrackBar.Location = new System.Drawing.Point(758, 153);
            this.per1TrackBar.Maximum = 100;
            this.per1TrackBar.Minimum = 1;
            this.per1TrackBar.Name = "per1TrackBar";
            this.per1TrackBar.Size = new System.Drawing.Size(139, 56);
            this.per1TrackBar.TabIndex = 1;
            this.per1TrackBar.Value = 1;
            this.per1TrackBar.Scroll += new System.EventHandler(this.per1TrackBar_Scroll);
            // 
            // per2TrackBar
            // 
            this.per2TrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.per2TrackBar.LargeChange = 1;
            this.per2TrackBar.Location = new System.Drawing.Point(758, 213);
            this.per2TrackBar.Maximum = 100;
            this.per2TrackBar.Minimum = 1;
            this.per2TrackBar.Name = "per2TrackBar";
            this.per2TrackBar.Size = new System.Drawing.Size(139, 56);
            this.per2TrackBar.TabIndex = 1;
            this.per2TrackBar.Value = 1;
            this.per2TrackBar.Scroll += new System.EventHandler(this.per2TrackBar_Scroll);
            // 
            // th1TrackBar
            // 
            this.th1TrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.th1TrackBar.LargeChange = 1;
            this.th1TrackBar.Location = new System.Drawing.Point(758, 273);
            this.th1TrackBar.Maximum = 90;
            this.th1TrackBar.Name = "th1TrackBar";
            this.th1TrackBar.Size = new System.Drawing.Size(139, 56);
            this.th1TrackBar.TabIndex = 1;
            this.th1TrackBar.Value = 1;
            this.th1TrackBar.Scroll += new System.EventHandler(this.th1TrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度";
            // 
            // per1Label
            // 
            this.per1Label.AutoSize = true;
            this.per1Label.Location = new System.Drawing.Point(655, 175);
            this.per1Label.Name = "per1Label";
            this.per1Label.Size = new System.Drawing.Size(97, 15);
            this.per1Label.TabIndex = 2;
            this.per1Label.Text = "右分支长度比";
            // 
            // per2Label
            // 
            this.per2Label.AutoSize = true;
            this.per2Label.Location = new System.Drawing.Point(655, 234);
            this.per2Label.Name = "per2Label";
            this.per2Label.Size = new System.Drawing.Size(97, 15);
            this.per2Label.TabIndex = 2;
            this.per2Label.Text = "左分支长度比";
            // 
            // th1Label
            // 
            this.th1Label.AutoSize = true;
            this.th1Label.Location = new System.Drawing.Point(670, 293);
            this.th1Label.Name = "th1Label";
            this.th1Label.Size = new System.Drawing.Size(82, 15);
            this.th1Label.TabIndex = 2;
            this.th1Label.Text = "右分支角度";
            // 
            // th2TrackBar
            // 
            this.th2TrackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.th2TrackBar.LargeChange = 1;
            this.th2TrackBar.Location = new System.Drawing.Point(758, 333);
            this.th2TrackBar.Maximum = 90;
            this.th2TrackBar.Name = "th2TrackBar";
            this.th2TrackBar.Size = new System.Drawing.Size(139, 56);
            this.th2TrackBar.TabIndex = 1;
            this.th2TrackBar.Value = 1;
            this.th2TrackBar.Scroll += new System.EventHandler(this.th2TrackBar_Scroll);
            // 
            // th2Label
            // 
            this.th2Label.AutoSize = true;
            this.th2Label.Location = new System.Drawing.Point(670, 352);
            this.th2Label.Name = "th2Label";
            this.th2Label.Size = new System.Drawing.Size(82, 15);
            this.th2Label.TabIndex = 2;
            this.th2Label.Text = "左分支角度";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(714, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Red";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Green";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Blue";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.th2Label);
            this.Controls.Add(this.th1Label);
            this.Controls.Add(this.per2Label);
            this.Controls.Add(this.per1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.th2TrackBar);
            this.Controls.Add(this.th1TrackBar);
            this.Controls.Add(this.per2TrackBar);
            this.Controls.Add(this.per1TrackBar);
            this.Controls.Add(this.lengTrackBar);
            this.Controls.Add(this.depthTrackBar);
            this.Controls.Add(this.draw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.depthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2TrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TrackBar depthTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar lengTrackBar;
        private System.Windows.Forms.TrackBar per1TrackBar;
        private System.Windows.Forms.TrackBar per2TrackBar;
        private System.Windows.Forms.TrackBar th1TrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label per1Label;
        private System.Windows.Forms.Label per2Label;
        private System.Windows.Forms.Label th1Label;
        private System.Windows.Forms.TrackBar th2TrackBar;
        private System.Windows.Forms.Label th2Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

