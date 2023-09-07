namespace Game
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayButton = new System.Windows.Forms.Button();
            this.StatisticButton = new System.Windows.Forms.Button();
            this.PlayerstableButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerRating = new System.Windows.Forms.Label();
            this.AllHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(174, 56);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(346, 49);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.Text = "Грати";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StatisticButton
            // 
            this.StatisticButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatisticButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StatisticButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticButton.Location = new System.Drawing.Point(174, 132);
            this.StatisticButton.Name = "StatisticButton";
            this.StatisticButton.Size = new System.Drawing.Size(346, 49);
            this.StatisticButton.TabIndex = 7;
            this.StatisticButton.Text = "Моя статистика";
            this.StatisticButton.UseVisualStyleBackColor = false;
            this.StatisticButton.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // PlayerstableButton
            // 
            this.PlayerstableButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerstableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayerstableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerstableButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerstableButton.Location = new System.Drawing.Point(174, 206);
            this.PlayerstableButton.Name = "PlayerstableButton";
            this.PlayerstableButton.Size = new System.Drawing.Size(346, 49);
            this.PlayerstableButton.TabIndex = 8;
            this.PlayerstableButton.Text = "Таблиця гравців";
            this.PlayerstableButton.UseVisualStyleBackColor = false;
            this.PlayerstableButton.Click += new System.EventHandler(this.PlayerstableButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(174, 355);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(346, 49);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Form_FormClosed);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerName.Location = new System.Drawing.Point(12, 9);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(0, 25);
            this.PlayerName.TabIndex = 10;
            // 
            // PlayerRating
            // 
            this.PlayerRating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerRating.AutoSize = true;
            this.PlayerRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerRating.Location = new System.Drawing.Point(595, 9);
            this.PlayerRating.Name = "PlayerRating";
            this.PlayerRating.Size = new System.Drawing.Size(0, 25);
            this.PlayerRating.TabIndex = 11;
            this.PlayerRating.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AllHistory
            // 
            this.AllHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AllHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AllHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllHistory.Location = new System.Drawing.Point(174, 279);
            this.AllHistory.Name = "AllHistory";
            this.AllHistory.Size = new System.Drawing.Size(346, 49);
            this.AllHistory.TabIndex = 12;
            this.AllHistory.Text = "Історія усіх зіграних ігор";
            this.AllHistory.UseVisualStyleBackColor = false;
            this.AllHistory.Click += new System.EventHandler(this.AllHistory_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.AllHistory);
            this.Controls.Add(this.PlayerRating);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayerstableButton);
            this.Controls.Add(this.StatisticButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StatisticButton;
        private System.Windows.Forms.Button PlayerstableButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label PlayerRating;
        private System.Windows.Forms.Button AllHistory;
    }
}