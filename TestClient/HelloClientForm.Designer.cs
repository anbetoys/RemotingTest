namespace TestClient
{
    partial class HelloClientForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textSay = new System.Windows.Forms.TextBox();
            this.cmdSay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Say";
            // 
            // textSay
            // 
            this.textSay.Location = new System.Drawing.Point(45, 90);
            this.textSay.Name = "textSay";
            this.textSay.Size = new System.Drawing.Size(100, 19);
            this.textSay.TabIndex = 1;
            // 
            // cmdSay
            // 
            this.cmdSay.Location = new System.Drawing.Point(141, 132);
            this.cmdSay.Name = "cmdSay";
            this.cmdSay.Size = new System.Drawing.Size(75, 23);
            this.cmdSay.TabIndex = 2;
            this.cmdSay.Text = "Say";
            this.cmdSay.UseVisualStyleBackColor = true;
            this.cmdSay.Click += new System.EventHandler(this.cmdSay_Click);
            // 
            // HelloClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdSay);
            this.Controls.Add(this.textSay);
            this.Controls.Add(this.label1);
            this.Name = "HelloClientForm";
            this.Text = "Hello Client";
            this.Load += new System.EventHandler(this.HelloClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSay;
        private System.Windows.Forms.Button cmdSay;
    }
}

