namespace TRex
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
            this.FloorPictureBox = new System.Windows.Forms.PictureBox();
            this.TRexPictureBox = new System.Windows.Forms.PictureBox();
            this.Obstacle1PictureBox = new System.Windows.Forms.PictureBox();
            this.Obstacle2PictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.MetorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FloorPictureBox
            // 
            this.FloorPictureBox.BackColor = System.Drawing.Color.Black;
            this.FloorPictureBox.Location = new System.Drawing.Point(1, 415);
            this.FloorPictureBox.Name = "FloorPictureBox";
            this.FloorPictureBox.Size = new System.Drawing.Size(618, 65);
            this.FloorPictureBox.TabIndex = 0;
            this.FloorPictureBox.TabStop = false;
            // 
            // TRexPictureBox
            // 
            this.TRexPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TRexPictureBox.Image")));
            this.TRexPictureBox.Location = new System.Drawing.Point(66, 372);
            this.TRexPictureBox.Name = "TRexPictureBox";
            this.TRexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.TRexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TRexPictureBox.TabIndex = 1;
            this.TRexPictureBox.TabStop = false;
            this.TRexPictureBox.Click += new System.EventHandler(this.TRexPictureBox_Click);
            // 
            // Obstacle1PictureBox
            // 
            this.Obstacle1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Obstacle1PictureBox.Image")));
            this.Obstacle1PictureBox.Location = new System.Drawing.Point(341, 369);
            this.Obstacle1PictureBox.Name = "Obstacle1PictureBox";
            this.Obstacle1PictureBox.Size = new System.Drawing.Size(23, 46);
            this.Obstacle1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle1PictureBox.TabIndex = 2;
            this.Obstacle1PictureBox.TabStop = false;
            this.Obstacle1PictureBox.Tag = "ObstacleOmit";
            // 
            // Obstacle2PictureBox
            // 
            this.Obstacle2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Obstacle2PictureBox.Image")));
            this.Obstacle2PictureBox.Location = new System.Drawing.Point(484, 382);
            this.Obstacle2PictureBox.Name = "Obstacle2PictureBox";
            this.Obstacle2PictureBox.Size = new System.Drawing.Size(32, 33);
            this.Obstacle2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle2PictureBox.TabIndex = 3;
            this.Obstacle2PictureBox.TabStop = false;
            this.Obstacle2PictureBox.Tag = "ObstacleOmit";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Location = new System.Drawing.Point(36, 26);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(50, 13);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 45;
            this.GameTimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // MetorPictureBox
            // 
            this.MetorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MetorPictureBox.Image")));
            this.MetorPictureBox.Location = new System.Drawing.Point(258, 41);
            this.MetorPictureBox.Name = "MetorPictureBox";
            this.MetorPictureBox.Size = new System.Drawing.Size(348, 275);
            this.MetorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MetorPictureBox.TabIndex = 5;
            this.MetorPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.MetorPictureBox);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Obstacle2PictureBox);
            this.Controls.Add(this.Obstacle1PictureBox);
            this.Controls.Add(this.TRexPictureBox);
            this.Controls.Add(this.FloorPictureBox);
            this.Name = "Form1";
            this.Text = "TRex Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.FloorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FloorPictureBox;
        private System.Windows.Forms.PictureBox TRexPictureBox;
        private System.Windows.Forms.PictureBox Obstacle1PictureBox;
        private System.Windows.Forms.PictureBox Obstacle2PictureBox;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox MetorPictureBox;
    }
}

