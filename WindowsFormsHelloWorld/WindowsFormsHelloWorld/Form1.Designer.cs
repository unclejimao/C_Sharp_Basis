namespace WindowsFormsHelloWorld
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
            this.textBoxShowHello = new System.Windows.Forms.TextBox();
            this.ButtonSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowHello
            // 
            this.textBoxShowHello.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxShowHello.Location = new System.Drawing.Point(37, 12);
            this.textBoxShowHello.Name = "textBoxShowHello";
            this.textBoxShowHello.Size = new System.Drawing.Size(500, 34);
            this.textBoxShowHello.TabIndex = 0;
            this.textBoxShowHello.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // ButtonSayHello
            // 
            this.ButtonSayHello.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonSayHello.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSayHello.Location = new System.Drawing.Point(37, 52);
            this.ButtonSayHello.Name = "ButtonSayHello";
            this.ButtonSayHello.Size = new System.Drawing.Size(500, 60);
            this.ButtonSayHello.TabIndex = 1;
            this.ButtonSayHello.Text = "Click Me";
            this.ButtonSayHello.UseVisualStyleBackColor = false;
            this.ButtonSayHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.ButtonSayHello);
            this.Controls.Add(this.textBoxShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowHello;
        private System.Windows.Forms.Button ButtonSayHello;
    }
}

