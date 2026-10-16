namespace up02
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            headerPanel = new Panel();
            logoBox = new PictureBox();
            titleLabel = new Label();
            materialsPanel = new FlowLayoutPanel();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(171, 207, 206);
            headerPanel.Controls.Add(logoBox);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1100, 84);
            headerPanel.TabIndex = 2;
            // 
            // logoBox
            // 
            logoBox.Image = (Image)resources.GetObject("logoBox.Image");
            logoBox.Location = new Point(20, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(60, 60);
            logoBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(96, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(324, 38);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Мозаика — материалы";
            // 
            // materialsPanel
            // 
            materialsPanel.AutoScroll = true;
            materialsPanel.BackColor = Color.White;
            materialsPanel.Dock = DockStyle.Fill;
            materialsPanel.FlowDirection = FlowDirection.TopDown;
            materialsPanel.Location = new Point(0, 84);
            materialsPanel.Name = "materialsPanel";
            materialsPanel.Padding = new Padding(16);
            materialsPanel.Size = new Size(1100, 636);
            materialsPanel.TabIndex = 0;
            materialsPanel.WrapContents = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(materialsPanel);
            Controls.Add(headerPanel);
            Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(900, 600);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мозаика — учёт материалов";
            Load += Main_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private PictureBox logoBox;
        private Label titleLabel;
        private FlowLayoutPanel materialsPanel;
    }
}
