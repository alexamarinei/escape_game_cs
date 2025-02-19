namespace NoEscape
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bottom_bg = new System.Windows.Forms.Panel();
            this.INGAME_SCORE = new System.Windows.Forms.Label();
            this.BUTTON_START = new System.Windows.Forms.Button();
            this.ZONE_1 = new System.Windows.Forms.Button();
            this.ZONE_2 = new System.Windows.Forms.Button();
            this.ZONE_3 = new System.Windows.Forms.Button();
            this.ZONE_4 = new System.Windows.Forms.Button();
            this.ZONE_5 = new System.Windows.Forms.Button();
            this.ZONE_6 = new System.Windows.Forms.Button();
            this.ESCAPE = new System.Windows.Forms.Panel();
            this.GAME_START = new System.Windows.Forms.Timer(this.components);
            this.time_zone = new System.Windows.Forms.Label();
            this.Verify = new System.Windows.Forms.Timer(this.components);
            this.DIF1 = new System.Windows.Forms.Button();
            this.DIF2 = new System.Windows.Forms.Button();
            this.DIF3 = new System.Windows.Forms.Button();
            this.timer_anim = new System.Windows.Forms.Timer(this.components);
            this.END_GAME = new System.Windows.Forms.Label();
            this.bottom_bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottom_bg
            // 
            this.bottom_bg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bottom_bg.Controls.Add(this.INGAME_SCORE);
            this.bottom_bg.Controls.Add(this.BUTTON_START);
            this.bottom_bg.Location = new System.Drawing.Point(0, 350);
            this.bottom_bg.Margin = new System.Windows.Forms.Padding(0);
            this.bottom_bg.Name = "bottom_bg";
            this.bottom_bg.Size = new System.Drawing.Size(900, 100);
            this.bottom_bg.TabIndex = 0;
            // 
            // INGAME_SCORE
            // 
            this.INGAME_SCORE.AutoSize = true;
            this.INGAME_SCORE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGAME_SCORE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.INGAME_SCORE.Location = new System.Drawing.Point(50, 38);
            this.INGAME_SCORE.Name = "INGAME_SCORE";
            this.INGAME_SCORE.Size = new System.Drawing.Size(104, 32);
            this.INGAME_SCORE.TabIndex = 14;
            this.INGAME_SCORE.Text = "LEVEL";
            // 
            // BUTTON_START
            // 
            this.BUTTON_START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_START.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BUTTON_START.Location = new System.Drawing.Point(509, 11);
            this.BUTTON_START.Margin = new System.Windows.Forms.Padding(0);
            this.BUTTON_START.Name = "BUTTON_START";
            this.BUTTON_START.Size = new System.Drawing.Size(382, 80);
            this.BUTTON_START.TabIndex = 8;
            this.BUTTON_START.Text = "START";
            this.BUTTON_START.UseVisualStyleBackColor = true;
            this.BUTTON_START.Click += new System.EventHandler(this.BUTTON_START_Click);
            // 
            // ZONE_1
            // 
            this.ZONE_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_1.Location = new System.Drawing.Point(548, 172);
            this.ZONE_1.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_1.Name = "ZONE_1";
            this.ZONE_1.Size = new System.Drawing.Size(50, 50);
            this.ZONE_1.TabIndex = 8;
            this.ZONE_1.Text = "1";
            this.ZONE_1.UseVisualStyleBackColor = false;
            this.ZONE_1.Click += new System.EventHandler(this.ZONE_1_Click);
            // 
            // ZONE_2
            // 
            this.ZONE_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_2.Location = new System.Drawing.Point(598, 172);
            this.ZONE_2.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_2.Name = "ZONE_2";
            this.ZONE_2.Size = new System.Drawing.Size(50, 50);
            this.ZONE_2.TabIndex = 9;
            this.ZONE_2.Text = "2";
            this.ZONE_2.UseVisualStyleBackColor = false;
            this.ZONE_2.Click += new System.EventHandler(this.ZONE_2_Click);
            // 
            // ZONE_3
            // 
            this.ZONE_3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_3.Location = new System.Drawing.Point(648, 172);
            this.ZONE_3.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_3.Name = "ZONE_3";
            this.ZONE_3.Size = new System.Drawing.Size(50, 50);
            this.ZONE_3.TabIndex = 10;
            this.ZONE_3.Text = "3";
            this.ZONE_3.UseVisualStyleBackColor = false;
            this.ZONE_3.Click += new System.EventHandler(this.ZONE_3_Click);
            // 
            // ZONE_4
            // 
            this.ZONE_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_4.Location = new System.Drawing.Point(698, 172);
            this.ZONE_4.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_4.Name = "ZONE_4";
            this.ZONE_4.Size = new System.Drawing.Size(50, 50);
            this.ZONE_4.TabIndex = 11;
            this.ZONE_4.Text = "4";
            this.ZONE_4.UseVisualStyleBackColor = false;
            this.ZONE_4.Click += new System.EventHandler(this.ZONE_4_Click);
            // 
            // ZONE_5
            // 
            this.ZONE_5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_5.Location = new System.Drawing.Point(748, 172);
            this.ZONE_5.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_5.Name = "ZONE_5";
            this.ZONE_5.Size = new System.Drawing.Size(50, 50);
            this.ZONE_5.TabIndex = 12;
            this.ZONE_5.Text = "5";
            this.ZONE_5.UseVisualStyleBackColor = false;
            this.ZONE_5.Click += new System.EventHandler(this.ZONE_5_Click);
            // 
            // ZONE_6
            // 
            this.ZONE_6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZONE_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZONE_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZONE_6.Location = new System.Drawing.Point(798, 172);
            this.ZONE_6.Margin = new System.Windows.Forms.Padding(0);
            this.ZONE_6.Name = "ZONE_6";
            this.ZONE_6.Size = new System.Drawing.Size(50, 50);
            this.ZONE_6.TabIndex = 13;
            this.ZONE_6.Text = "6";
            this.ZONE_6.UseVisualStyleBackColor = false;
            this.ZONE_6.Click += new System.EventHandler(this.ZONE_6_Click);
            // 
            // ESCAPE
            // 
            this.ESCAPE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ESCAPE.BackColor = System.Drawing.Color.Transparent;
            this.ESCAPE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ESCAPE.BackgroundImage")));
            this.ESCAPE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ESCAPE.Location = new System.Drawing.Point(126, 120);
            this.ESCAPE.Name = "ESCAPE";
            this.ESCAPE.Size = new System.Drawing.Size(298, 237);
            this.ESCAPE.TabIndex = 1;
            // 
            // GAME_START
            // 
            this.GAME_START.Interval = 1000;
            this.GAME_START.Tick += new System.EventHandler(this.GAME_START_Tick);
            // 
            // time_zone
            // 
            this.time_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_zone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.time_zone.Location = new System.Drawing.Point(548, 120);
            this.time_zone.Name = "time_zone";
            this.time_zone.Size = new System.Drawing.Size(300, 32);
            this.time_zone.TabIndex = 16;
            this.time_zone.Text = "30 Seconds";
            this.time_zone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Verify
            // 
            this.Verify.Interval = 10;
            this.Verify.Tick += new System.EventHandler(this.Verify_Tick);
            // 
            // DIF1
            // 
            this.DIF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DIF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIF1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DIF1.Location = new System.Drawing.Point(548, 172);
            this.DIF1.Margin = new System.Windows.Forms.Padding(0);
            this.DIF1.Name = "DIF1";
            this.DIF1.Size = new System.Drawing.Size(100, 50);
            this.DIF1.TabIndex = 17;
            this.DIF1.Text = "E";
            this.DIF1.UseVisualStyleBackColor = false;
            this.DIF1.Click += new System.EventHandler(this.DIF1_Click);
            // 
            // DIF2
            // 
            this.DIF2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DIF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIF2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DIF2.Location = new System.Drawing.Point(648, 172);
            this.DIF2.Margin = new System.Windows.Forms.Padding(0);
            this.DIF2.Name = "DIF2";
            this.DIF2.Size = new System.Drawing.Size(100, 50);
            this.DIF2.TabIndex = 18;
            this.DIF2.Text = "N";
            this.DIF2.UseVisualStyleBackColor = false;
            this.DIF2.Click += new System.EventHandler(this.DIF2_Click);
            // 
            // DIF3
            // 
            this.DIF3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DIF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIF3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DIF3.Location = new System.Drawing.Point(748, 172);
            this.DIF3.Margin = new System.Windows.Forms.Padding(0);
            this.DIF3.Name = "DIF3";
            this.DIF3.Size = new System.Drawing.Size(100, 50);
            this.DIF3.TabIndex = 19;
            this.DIF3.Text = "H";
            this.DIF3.UseVisualStyleBackColor = false;
            this.DIF3.Click += new System.EventHandler(this.DIF3_Click);
            // 
            // timer_anim
            // 
            this.timer_anim.Interval = 10;
            this.timer_anim.Tick += new System.EventHandler(this.timer_anim_Tick);
            // 
            // END_GAME
            // 
            this.END_GAME.BackColor = System.Drawing.Color.Transparent;
            this.END_GAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END_GAME.ForeColor = System.Drawing.Color.Lime;
            this.END_GAME.Location = new System.Drawing.Point(54, 120);
            this.END_GAME.Name = "END_GAME";
            this.END_GAME.Size = new System.Drawing.Size(453, 138);
            this.END_GAME.TabIndex = 20;
            this.END_GAME.Text = "WIN";
            this.END_GAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.END_GAME);
            this.Controls.Add(this.DIF3);
            this.Controls.Add(this.DIF2);
            this.Controls.Add(this.DIF1);
            this.Controls.Add(this.time_zone);
            this.Controls.Add(this.ZONE_6);
            this.Controls.Add(this.ZONE_5);
            this.Controls.Add(this.ZONE_4);
            this.Controls.Add(this.ZONE_3);
            this.Controls.Add(this.ZONE_2);
            this.Controls.Add(this.ZONE_1);
            this.Controls.Add(this.ESCAPE);
            this.Controls.Add(this.bottom_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bottom_bg.ResumeLayout(false);
            this.bottom_bg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottom_bg;
        private System.Windows.Forms.Panel ESCAPE;
        private System.Windows.Forms.Label INGAME_SCORE;
        private System.Windows.Forms.Button BUTTON_START;
        private System.Windows.Forms.Button ZONE_1;
        private System.Windows.Forms.Button ZONE_2;
        private System.Windows.Forms.Button ZONE_3;
        private System.Windows.Forms.Button ZONE_4;
        private System.Windows.Forms.Button ZONE_5;
        private System.Windows.Forms.Button ZONE_6;
        private System.Windows.Forms.Timer GAME_START;
        private System.Windows.Forms.Label time_zone;
        private System.Windows.Forms.Timer Verify;
        private System.Windows.Forms.Button DIF1;
        private System.Windows.Forms.Button DIF2;
        private System.Windows.Forms.Button DIF3;
        private System.Windows.Forms.Timer timer_anim;
        private System.Windows.Forms.Label END_GAME;
    }
}

