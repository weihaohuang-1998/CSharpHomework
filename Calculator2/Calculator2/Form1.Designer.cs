namespace Calculator
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
            this.Operator = new System.Windows.Forms.ComboBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operator.Location = new System.Drawing.Point(200, 166);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(121, 23);
            this.Operator.TabIndex = 0;
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(51, 166);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 25);
            this.input1.TabIndex = 1;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(369, 164);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 25);
            this.input2.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(600, 166);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(188, 25);
            this.output.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.equalClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.Operator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
    }
}

