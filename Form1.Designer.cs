namespace TestComponent
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlDraw1 = new SpectrumDraw.UserControlDraw();
            this.userControlDraw2 = new SpectrumDraw.UserControlDraw();
            this.SuspendLayout();
            // 
            // userControlDraw1
            // 
            this.userControlDraw1.AutoSize = true;
            this.userControlDraw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlDraw1.INIT_RULING_X_END = 100F;
            this.userControlDraw1.INIT_RULING_X_INTERVAL = 5F;
            this.userControlDraw1.INIT_RULING_X_START = 0F;
            this.userControlDraw1.INIT_RULING_Y_END = 100F;
            this.userControlDraw1.INIT_RULING_Y_INTERVAL = 10F;
            this.userControlDraw1.INIT_RULING_Y_START = 0F;
            this.userControlDraw1.Location = new System.Drawing.Point(12, 12);
            this.userControlDraw1.Name = "userControlDraw1";
            this.userControlDraw1.Size = new System.Drawing.Size(889, 380);
            this.userControlDraw1.TabIndex = 0;
            this.userControlDraw1.X_LABEL = "时间";
            this.userControlDraw1.Y_LABEL = "强度";
            // 
            // userControlDraw2
            // 
            this.userControlDraw2.AutoSize = true;
            this.userControlDraw2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlDraw2.INIT_RULING_X_END = 100F;
            this.userControlDraw2.INIT_RULING_X_INTERVAL = 10F;
            this.userControlDraw2.INIT_RULING_X_START = 0F;
            this.userControlDraw2.INIT_RULING_Y_END = 100F;
            this.userControlDraw2.INIT_RULING_Y_INTERVAL = 10F;
            this.userControlDraw2.INIT_RULING_Y_START = 0F;
            this.userControlDraw2.Location = new System.Drawing.Point(13, 400);
            this.userControlDraw2.Name = "userControlDraw2";
            this.userControlDraw2.Size = new System.Drawing.Size(665, 271);
            this.userControlDraw2.TabIndex = 1;
            this.userControlDraw2.X_LABEL = "强度";
            this.userControlDraw2.Y_LABEL = "核质比";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 681);
            this.Controls.Add(this.userControlDraw2);
            this.Controls.Add(this.userControlDraw1);
            this.Name = "Form1";
            this.Text = "SpectrumDraw测试程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpectrumDraw.UserControlDraw userControlDraw1;
        private SpectrumDraw.UserControlDraw userControlDraw2;


    }
}

