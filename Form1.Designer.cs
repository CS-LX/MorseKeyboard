namespace MorseKeyboard
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
            this.dotBt = new System.Windows.Forms.Button();
            this.barBt = new System.Windows.Forms.Button();
            this.gBt = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dotBt
            // 
            this.dotBt.Font = new System.Drawing.Font("黑体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dotBt.Location = new System.Drawing.Point(13, 43);
            this.dotBt.Name = "dotBt";
            this.dotBt.Size = new System.Drawing.Size(139, 52);
            this.dotBt.TabIndex = 0;
            this.dotBt.Text = "·";
            this.dotBt.UseVisualStyleBackColor = true;
            this.dotBt.Click += new System.EventHandler(this.dotBt_Click);
            // 
            // barBt
            // 
            this.barBt.Font = new System.Drawing.Font("黑体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barBt.Location = new System.Drawing.Point(13, 101);
            this.barBt.Name = "barBt";
            this.barBt.Size = new System.Drawing.Size(139, 52);
            this.barBt.TabIndex = 1;
            this.barBt.Text = "-";
            this.barBt.UseVisualStyleBackColor = true;
            this.barBt.Click += new System.EventHandler(this.barBt_Click);
            // 
            // gBt
            // 
            this.gBt.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gBt.Location = new System.Drawing.Point(13, 159);
            this.gBt.Name = "gBt";
            this.gBt.Size = new System.Drawing.Size(139, 52);
            this.gBt.TabIndex = 2;
            this.gBt.Text = "/";
            this.gBt.UseVisualStyleBackColor = true;
            this.gBt.Click += new System.EventHandler(this.gBt_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "对照表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 25);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 237);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gBt);
            this.Controls.Add(this.barBt);
            this.Controls.Add(this.dotBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "输入键盘";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dotBt;
        private System.Windows.Forms.Button barBt;
        private System.Windows.Forms.Button gBt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

