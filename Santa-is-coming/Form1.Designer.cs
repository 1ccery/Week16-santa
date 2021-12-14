namespace Santa_is_coming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeTop = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.treeBottom = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            this.SuspendLayout();
            // 
            // treeTop
            // 
            this.treeTop.Image = ((System.Drawing.Image)(resources.GetObject("treeTop.Image")));
            this.treeTop.Location = new System.Drawing.Point(528, -1);
            this.treeTop.Name = "treeTop";
            this.treeTop.Size = new System.Drawing.Size(86, 100);
            this.treeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeTop.TabIndex = 0;
            this.treeTop.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(0, 374);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(799, 75);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 1;
            this.Ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(135, 188);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(118, 62);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // treeBottom
            // 
            this.treeBottom.Image = ((System.Drawing.Image)(resources.GetObject("treeBottom.Image")));
            this.treeBottom.Location = new System.Drawing.Point(528, 261);
            this.treeBottom.Name = "treeBottom";
            this.treeBottom.Size = new System.Drawing.Size(86, 120);
            this.treeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeBottom.TabIndex = 3;
            this.treeBottom.TabStop = false;
            this.treeBottom.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(647, 30);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(63, 50);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 4;
            this.snowflake.TabStop = false;
            this.snowflake.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(0, 261);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(122, 107);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 5;
            this.house.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(249, 18);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(139, 100);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 6;
            this.moon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(12, 18);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(130, 45);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "Score:0";
            this.scoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.house);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.treeBottom);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.treeTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox treeTop;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox treeBottom;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
    }
}

