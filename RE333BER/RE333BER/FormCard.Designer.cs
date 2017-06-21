namespace RE333BER
{
    partial class FormCard
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ask = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.btnrem = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // ask
            // 
            this.ask.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ask.Location = new System.Drawing.Point(84, 70);
            this.ask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(578, 81);
            this.ask.TabIndex = 6;
            this.ask.Text = "asteroid";
            this.ask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncheck.Location = new System.Drawing.Point(237, 371);
            this.btncheck.Margin = new System.Windows.Forms.Padding(2);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(78, 28);
            this.btncheck.TabIndex = 7;
            this.btncheck.Text = "待複習";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ans.Location = new System.Drawing.Point(71, 242);
            this.ans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(591, 48);
            this.ans.TabIndex = 6;
            this.ans.Text = "小行星";
            this.ans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrem
            // 
            this.btnrem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnrem.Location = new System.Drawing.Point(408, 371);
            this.btnrem.Margin = new System.Windows.Forms.Padding(2);
            this.btnrem.Name = "btnrem";
            this.btnrem.Size = new System.Drawing.Size(78, 28);
            this.btnrem.TabIndex = 7;
            this.btnrem.Text = "已記住";
            this.btnrem.UseVisualStyleBackColor = true;
            this.btnrem.Click += new System.EventHandler(this.btnrem_Click);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnshow.Location = new System.Drawing.Point(408, 371);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(78, 28);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "看答案";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 433);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnrem);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ask;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button btnrem;
        private System.Windows.Forms.Button btnshow;
    }
}

