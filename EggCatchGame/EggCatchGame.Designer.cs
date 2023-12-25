namespace EggCatchGame
{
    partial class frmEggCatchGame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEggCatchGame));
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.lblCatcher = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEgg = new System.Windows.Forms.Label();
            this.lblCrushedEgg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnBegin.Location = new System.Drawing.Point(677, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(111, 43);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "開始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnReset.Location = new System.Drawing.Point(677, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 43);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("游ゴシック", 14F);
            this.btnRight.Location = new System.Drawing.Point(476, 321);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(123, 44);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("游ゴシック", 14F);
            this.btnLeft.Location = new System.Drawing.Point(218, 321);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(123, 44);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Font = new System.Drawing.Font("游ゴシック", 14F);
            this.btnCenter.Location = new System.Drawing.Point(347, 321);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(123, 44);
            this.btnCenter.TabIndex = 4;
            this.btnCenter.Text = "●";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // lblCatcher
            // 
            this.lblCatcher.BackColor = System.Drawing.Color.GreenYellow;
            this.lblCatcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCatcher.Location = new System.Drawing.Point(347, 236);
            this.lblCatcher.Margin = new System.Windows.Forms.Padding(3);
            this.lblCatcher.Name = "lblCatcher";
            this.lblCatcher.Size = new System.Drawing.Size(123, 23);
            this.lblCatcher.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 30);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "ゲーム開始前";
            // 
            // lblEgg
            // 
            this.lblEgg.BackColor = System.Drawing.Color.White;
            this.lblEgg.Image = ((System.Drawing.Image)(resources.GetObject("lblEgg.Image")));
            this.lblEgg.Location = new System.Drawing.Point(382, 12);
            this.lblEgg.Margin = new System.Windows.Forms.Padding(3);
            this.lblEgg.Name = "lblEgg";
            this.lblEgg.Size = new System.Drawing.Size(50, 50);
            this.lblEgg.TabIndex = 8;
            // 
            // lblCrushedEgg
            // 
            this.lblCrushedEgg.BackColor = System.Drawing.Color.White;
            this.lblCrushedEgg.Image = ((System.Drawing.Image)(resources.GetObject("lblCrushedEgg.Image")));
            this.lblCrushedEgg.Location = new System.Drawing.Point(738, 318);
            this.lblCrushedEgg.Margin = new System.Windows.Forms.Padding(3);
            this.lblCrushedEgg.Name = "lblCrushedEgg";
            this.lblCrushedEgg.Size = new System.Drawing.Size(50, 50);
            this.lblCrushedEgg.TabIndex = 9;
            this.lblCrushedEgg.Visible = false;
            // 
            // frmEggCatchGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.lblCrushedEgg);
            this.Controls.Add(this.lblEgg);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCatcher);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBegin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 416);
            this.Name = "frmEggCatchGame";
            this.Text = "エッグキャッチゲーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Label lblCatcher;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEgg;
        private System.Windows.Forms.Label lblCrushedEgg;
    }
}

