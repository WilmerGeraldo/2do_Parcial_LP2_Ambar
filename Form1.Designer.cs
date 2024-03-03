namespace _2do_Parcial_LP2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbar = new CircularProgressBar_NET5.CircularProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbar
            // 
            pbar.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            pbar.AnimationSpeed = 500;
            pbar.BackColor = Color.Transparent;
            pbar.Font = new Font("Calibri", 56.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pbar.ForeColor = Color.White;
            pbar.InnerColor = Color.Orange;
            pbar.InnerMargin = 2;
            pbar.InnerWidth = -1;
            pbar.Location = new Point(428, 97);
            pbar.MarqueeAnimationSpeed = 2000;
            pbar.Name = "pbar";
            pbar.OuterColor = Color.DarkOrange;
            pbar.OuterMargin = -25;
            pbar.OuterWidth = 26;
            pbar.ProgressColor = Color.Gold;
            pbar.ProgressWidth = 25;
            pbar.SecondaryFont = new Font("Segoe UI", 36F);
            pbar.Size = new Size(258, 253);
            pbar.StartAngle = 270;
            pbar.Style = ProgressBarStyle.Continuous;
            pbar.SubscriptColor = Color.FromArgb(166, 166, 166);
            pbar.SubscriptMargin = new Padding(10, -35, 0, 0);
            pbar.SubscriptText = "";
            pbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            pbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pbar.SuperscriptText = "";
            pbar.TabIndex = 0;
            pbar.TextMargin = new Padding(8, 8, 0, 0);
            pbar.Value = 68;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(309, 370);
            label1.Name = "label1";
            label1.Size = new Size(171, 45);
            label1.TabIndex = 2;
            label1.Text = "Loading...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(764, 450);
            Controls.Add(label1);
            Controls.Add(pbar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar_NET5.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
