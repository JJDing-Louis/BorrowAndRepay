﻿namespace BorrowAndRepay
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNameInput = new System.Windows.Forms.TextBox();
            this.friendNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.myMoneyLabel = new System.Windows.Forms.Label();
            this.friendMoneyLabel = new System.Windows.Forms.Label();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.repayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "清輸入我的名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "清輸入朋友的名字:";
            // 
            // myNameInput
            // 
            this.myNameInput.Location = new System.Drawing.Point(181, 25);
            this.myNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myNameInput.Name = "myNameInput";
            this.myNameInput.Size = new System.Drawing.Size(76, 22);
            this.myNameInput.TabIndex = 2;
            // 
            // friendNameInput
            // 
            this.friendNameInput.Location = new System.Drawing.Point(181, 61);
            this.friendNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.friendNameInput.Name = "friendNameInput";
            this.friendNameInput.Size = new System.Drawing.Size(76, 22);
            this.friendNameInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "我的名字:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(38, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "我的$$:";
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myNameLabel.Location = new System.Drawing.Point(137, 107);
            this.myNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(56, 16);
            this.myNameLabel.TabIndex = 6;
            this.myNameLabel.Text = "無名氏";
            // 
            // myMoneyLabel
            // 
            this.myMoneyLabel.AutoSize = true;
            this.myMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myMoneyLabel.Location = new System.Drawing.Point(137, 141);
            this.myMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.myMoneyLabel.Name = "myMoneyLabel";
            this.myMoneyLabel.Size = new System.Drawing.Size(16, 16);
            this.myMoneyLabel.TabIndex = 7;
            this.myMoneyLabel.Text = "0";
            // 
            // friendMoneyLabel
            // 
            this.friendMoneyLabel.AutoSize = true;
            this.friendMoneyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendMoneyLabel.Location = new System.Drawing.Point(323, 141);
            this.friendMoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.friendMoneyLabel.Name = "friendMoneyLabel";
            this.friendMoneyLabel.Size = new System.Drawing.Size(56, 16);
            this.friendMoneyLabel.TabIndex = 11;
            this.friendMoneyLabel.Text = "200000";
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.friendNameLabel.Location = new System.Drawing.Point(323, 107);
            this.friendNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(56, 16);
            this.friendNameLabel.TabIndex = 10;
            this.friendNameLabel.Text = "無名氏";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(224, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "朋友的$$:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(224, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "朋友的名字:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submitButton.Location = new System.Drawing.Point(283, 25);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 58);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "確認";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.borrowButton.Location = new System.Drawing.Point(38, 176);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(360, 32);
            this.borrowButton.TabIndex = 13;
            this.borrowButton.Text = "跟 XXX 借 1000 $";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // repayButton
            // 
            this.repayButton.Enabled = false;
            this.repayButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.repayButton.Location = new System.Drawing.Point(38, 214);
            this.repayButton.Name = "repayButton";
            this.repayButton.Size = new System.Drawing.Size(360, 32);
            this.repayButton.TabIndex = 14;
            this.repayButton.Text = "還給 XXX 1000 $";
            this.repayButton.UseVisualStyleBackColor = true;
            this.repayButton.Click += new System.EventHandler(this.repayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 265);
            this.Controls.Add(this.repayButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.friendMoneyLabel);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.myMoneyLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.friendNameInput);
            this.Controls.Add(this.myNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " 借還錢程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myNameInput;
        private System.Windows.Forms.TextBox friendNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label myMoneyLabel;
        private System.Windows.Forms.Label friendMoneyLabel;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button repayButton;
    }
}

