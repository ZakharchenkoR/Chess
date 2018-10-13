namespace WinFormsChess
{
    partial class Chess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chess));
            this.CloseGame = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.PanelChess = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CloseGame
            // 
            this.CloseGame.Location = new System.Drawing.Point(468, 82);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(81, 38);
            this.CloseGame.TabIndex = 0;
            this.CloseGame.Text = "Close";
            this.CloseGame.UseVisualStyleBackColor = true;
            this.CloseGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(468, 22);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(81, 38);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // PanelChess
            // 
            this.PanelChess.Location = new System.Drawing.Point(30, 22);
            this.PanelChess.Name = "PanelChess";
            this.PanelChess.Size = new System.Drawing.Size(400, 400);
            this.PanelChess.TabIndex = 2;
            this.PanelChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelChess_MouseClick);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 444);
            this.Controls.Add(this.PanelChess);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.CloseGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Chess_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseGame;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Panel PanelChess;
    }
}

