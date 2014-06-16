namespace TestServer
{
    partial class HelloServerForm
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
            this.lblSay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSay
            // 
            this.lblSay.AutoSize = true;
            this.lblSay.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSay.Location = new System.Drawing.Point(67, 57);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(135, 48);
            this.lblSay.TabIndex = 0;
            this.lblSay.Text = "aaaaa";
            // 
            // HelloServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSay);
            this.Name = "HelloServerForm";
            this.Text = "Hello Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelloServerForm_FormClosed);
            this.Load += new System.EventHandler(this.HelloServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSay;
    }
}

