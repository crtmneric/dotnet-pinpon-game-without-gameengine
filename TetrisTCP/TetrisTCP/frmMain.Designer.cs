namespace TetrisTCP
{
    partial class frmMain
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tmrMovements = new System.Windows.Forms.Timer(this.components);
            this.pctBall = new System.Windows.Forms.PictureBox();
            this.pctPlayer2 = new System.Windows.Forms.PictureBox();
            this.pctPlayer1 = new System.Windows.Forms.PictureBox();
            this.pctLeftWall = new System.Windows.Forms.PictureBox();
            this.pctRigtWall = new System.Windows.Forms.PictureBox();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            this.lblKeys = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRigtWall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(71, 264);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 83);
            this.lblInfo.TabIndex = 3;
            // 
            // tmrMovements
            // 
            this.tmrMovements.Tick += new System.EventHandler(this.tmrMovements_Tick);
            // 
            // pctBall
            // 
            this.pctBall.BackgroundImage = global::TetrisTCP.Properties.Resources.top;
            this.pctBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBall.Location = new System.Drawing.Point(676, 415);
            this.pctBall.Name = "pctBall";
            this.pctBall.Size = new System.Drawing.Size(48, 34);
            this.pctBall.TabIndex = 2;
            this.pctBall.TabStop = false;
            // 
            // pctPlayer2
            // 
            this.pctPlayer2.BackgroundImage = global::TetrisTCP.Properties.Resources.cubuk;
            this.pctPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPlayer2.Location = new System.Drawing.Point(619, 787);
            this.pctPlayer2.Name = "pctPlayer2";
            this.pctPlayer2.Size = new System.Drawing.Size(163, 36);
            this.pctPlayer2.TabIndex = 1;
            this.pctPlayer2.TabStop = false;
            // 
            // pctPlayer1
            // 
            this.pctPlayer1.BackgroundImage = global::TetrisTCP.Properties.Resources.cubuk;
            this.pctPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPlayer1.Location = new System.Drawing.Point(619, -2);
            this.pctPlayer1.Name = "pctPlayer1";
            this.pctPlayer1.Size = new System.Drawing.Size(163, 36);
            this.pctPlayer1.TabIndex = 0;
            this.pctPlayer1.TabStop = false;
            // 
            // pctLeftWall
            // 
            this.pctLeftWall.BackgroundImage = global::TetrisTCP.Properties.Resources.duvar;
            this.pctLeftWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctLeftWall.Location = new System.Drawing.Point(1, -2);
            this.pctLeftWall.Name = "pctLeftWall";
            this.pctLeftWall.Size = new System.Drawing.Size(24, 825);
            this.pctLeftWall.TabIndex = 4;
            this.pctLeftWall.TabStop = false;
            // 
            // pctRigtWall
            // 
            this.pctRigtWall.BackgroundImage = global::TetrisTCP.Properties.Resources.duvar;
            this.pctRigtWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRigtWall.Location = new System.Drawing.Point(1312, -2);
            this.pctRigtWall.Name = "pctRigtWall";
            this.pctRigtWall.Size = new System.Drawing.Size(24, 825);
            this.pctRigtWall.TabIndex = 5;
            this.pctRigtWall.TabStop = false;
            // 
            // tmrStart
            // 
            this.tmrStart.Interval = 1000;
            this.tmrStart.Tick += new System.EventHandler(this.tmrStart_Tick);
            // 
            // tmrBall
            // 
            this.tmrBall.Interval = 50;
            this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeys.ForeColor = System.Drawing.Color.Red;
            this.lblKeys.Location = new System.Drawing.Point(87, 79);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(964, 46);
            this.lblKeys.TabIndex = 6;
            this.lblKeys.Text = "Player1- A-D , Player2 - LEFT,RIGHT ARROW KEYS";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 824);
            this.ControlBox = false;
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.pctRigtWall);
            this.Controls.Add(this.pctLeftWall);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pctBall);
            this.Controls.Add(this.pctPlayer2);
            this.Controls.Add(this.pctPlayer1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetrisk";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRigtWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlayer1;
        private System.Windows.Forms.PictureBox pctPlayer2;
        private System.Windows.Forms.PictureBox pctBall;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer tmrMovements;
        private System.Windows.Forms.PictureBox pctLeftWall;
        private System.Windows.Forms.PictureBox pctRigtWall;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.Timer tmrBall;
        private System.Windows.Forms.Label lblKeys;
    }
}

