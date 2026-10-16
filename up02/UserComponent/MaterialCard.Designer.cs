namespace up02.UserComponent
{
    partial class MaterialCard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxImage = new PictureBox();
            labelName = new Label();
            labelDetails = new Label();
            labelShortage = new Label();
            labelHiddenId = new Label();
            labelMinCol = new Label();
            labelCol = new Label();
            labelUpokovka = new Label();
            labelPrice = new Label();
            labelType = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackColor = Color.White;
            pictureBoxImage.Location = new Point(14, 14);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(140, 140);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(174, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(570, 34);
            labelName.TabIndex = 1;
            // 
            // labelDetails
            // 
            labelDetails.Location = new Point(174, 55);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(590, 96);
            labelDetails.TabIndex = 2;
            // 
            // labelShortage
            // 
            labelShortage.BackColor = Color.FromArgb(84, 111, 148);
            labelShortage.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelShortage.ForeColor = Color.White;
            labelShortage.Location = new Point(770, 55);
            labelShortage.Name = "labelShortage";
            labelShortage.Size = new Size(220, 67);
            labelShortage.TabIndex = 3;
            labelShortage.TextAlign = ContentAlignment.MiddleCenter;
            labelShortage.Click += labelShortage_Click;
            // 
            // labelHiddenId
            // 
            labelHiddenId.AutoSize = true;
            labelHiddenId.Location = new Point(14, 160);
            labelHiddenId.Name = "labelHiddenId";
            labelHiddenId.Size = new Size(0, 19);
            labelHiddenId.TabIndex = 4;
            labelHiddenId.Visible = false;
            // 
            // labelMinCol
            // 
            labelMinCol.AutoSize = true;
            labelMinCol.Location = new Point(301, 14);
            labelMinCol.Name = "labelMinCol";
            labelMinCol.Size = new Size(46, 19);
            labelMinCol.TabIndex = 5;
            labelMinCol.Text = "label1";
            labelMinCol.Visible = false;
            // 
            // labelCol
            // 
            labelCol.AutoSize = true;
            labelCol.Location = new Point(298, 36);
            labelCol.Name = "labelCol";
            labelCol.Size = new Size(49, 19);
            labelCol.TabIndex = 6;
            labelCol.Text = "label2";
            labelCol.Visible = false;
            // 
            // labelUpokovka
            // 
            labelUpokovka.AutoSize = true;
            labelUpokovka.Location = new Point(298, 55);
            labelUpokovka.Name = "labelUpokovka";
            labelUpokovka.Size = new Size(49, 19);
            labelUpokovka.TabIndex = 7;
            labelUpokovka.Text = "label3";
            labelUpokovka.Visible = false;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(298, 81);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(49, 19);
            labelPrice.TabIndex = 8;
            labelPrice.Text = "label4";
            labelPrice.Visible = false;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(301, 103);
            labelType.Name = "labelType";
            labelType.Size = new Size(46, 19);
            labelType.TabIndex = 9;
            labelType.Text = "label1";
            labelType.Visible = false;
            // 
            // MaterialCard
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(171, 207, 206);
            Controls.Add(labelType);
            Controls.Add(labelPrice);
            Controls.Add(labelUpokovka);
            Controls.Add(labelCol);
            Controls.Add(labelMinCol);
            Controls.Add(labelHiddenId);
            Controls.Add(labelShortage);
            Controls.Add(labelDetails);
            Controls.Add(labelName);
            Controls.Add(pictureBoxImage);
            Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 12);
            Name = "MaterialCard";
            Size = new Size(1010, 170);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Label labelName;
        private Label labelDetails;
        private Label labelShortage;
        private Label labelHiddenId;
        private Label labelMinCol;
        private Label labelCol;
        private Label labelUpokovka;
        private Label labelPrice;
        private Label labelType;
    }
}