namespace up02.MyForms
{
    partial class EditMaterial
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
            Exit = new Button();
            label1 = new Label();
            panel1 = new Panel();
            NameMaterial = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            DiscMaterial = new TextBox();
            TypeMaterial = new ComboBox();
            PriceMaterial = new TextBox();
            ColMaterial = new TextBox();
            MinColMaterial = new TextBox();
            UnitMaterial = new ComboBox();
            TextFotoMaterial = new TextBox();
            SaveButtom = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(629, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(116, 36);
            Exit.TabIndex = 0;
            Exit.Text = "Назад";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 1;
            label1.Text = "Материал: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 111, 148);
            panel1.Controls.Add(NameMaterial);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 46);
            panel1.TabIndex = 2;
            // 
            // NameMaterial
            // 
            NameMaterial.BackColor = Color.FromArgb(171, 207, 206);
            NameMaterial.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameMaterial.Location = new Point(95, 3);
            NameMaterial.Name = "NameMaterial";
            NameMaterial.Size = new Size(245, 30);
            NameMaterial.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 3;
            label2.Text = "Тип материала: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 4;
            label3.Text = "Стоимость: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 5;
            label4.Text = "Количество: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(220, 23);
            label5.TabIndex = 6;
            label5.Text = "Минимальное количество: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 7;
            label6.Text = "Примечание:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 228);
            label7.Name = "label7";
            label7.Size = new Size(143, 23);
            label7.TabIndex = 8;
            label7.Text = "Ссылка на фото: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 196);
            label8.Name = "label8";
            label8.Size = new Size(167, 23);
            label8.TabIndex = 9;
            label8.Text = "Единица измерения:";
            // 
            // DiscMaterial
            // 
            DiscMaterial.Location = new Point(12, 274);
            DiscMaterial.Multiline = true;
            DiscMaterial.Name = "DiscMaterial";
            DiscMaterial.Size = new Size(733, 138);
            DiscMaterial.TabIndex = 10;
            // 
            // TypeMaterial
            // 
            TypeMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeMaterial.FormattingEnabled = true;
            TypeMaterial.Location = new Point(142, 50);
            TypeMaterial.Name = "TypeMaterial";
            TypeMaterial.Size = new Size(253, 23);
            TypeMaterial.TabIndex = 11;
            // 
            // PriceMaterial
            // 
            PriceMaterial.Location = new Point(108, 86);
            PriceMaterial.Name = "PriceMaterial";
            PriceMaterial.Size = new Size(287, 23);
            PriceMaterial.TabIndex = 12;
            PriceMaterial.KeyPress += PriceMaterial_KeyPress;
            // 
            // ColMaterial
            // 
            ColMaterial.Location = new Point(118, 125);
            ColMaterial.Name = "ColMaterial";
            ColMaterial.Size = new Size(277, 23);
            ColMaterial.TabIndex = 13;
            ColMaterial.KeyPress += ColMaterial_KeyPress;
            // 
            // MinColMaterial
            // 
            MinColMaterial.Location = new Point(226, 163);
            MinColMaterial.Name = "MinColMaterial";
            MinColMaterial.Size = new Size(169, 23);
            MinColMaterial.TabIndex = 14;
            MinColMaterial.KeyPress += MinColMaterial_KeyPress;
            // 
            // UnitMaterial
            // 
            UnitMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitMaterial.FormattingEnabled = true;
            UnitMaterial.Location = new Point(186, 196);
            UnitMaterial.Name = "UnitMaterial";
            UnitMaterial.Size = new Size(209, 23);
            UnitMaterial.TabIndex = 15;
            // 
            // TextFotoMaterial
            // 
            TextFotoMaterial.Location = new Point(151, 228);
            TextFotoMaterial.Name = "TextFotoMaterial";
            TextFotoMaterial.Size = new Size(244, 23);
            TextFotoMaterial.TabIndex = 16;
            // 
            // SaveButtom
            // 
            SaveButtom.Location = new Point(629, 46);
            SaveButtom.Name = "SaveButtom";
            SaveButtom.Size = new Size(116, 36);
            SaveButtom.TabIndex = 17;
            SaveButtom.Text = "Сохранить";
            SaveButtom.UseVisualStyleBackColor = true;
            SaveButtom.Click += SaveButtom_Click;
            // 
            // EditMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 424);
            Controls.Add(SaveButtom);
            Controls.Add(TextFotoMaterial);
            Controls.Add(UnitMaterial);
            Controls.Add(Exit);
            Controls.Add(MinColMaterial);
            Controls.Add(ColMaterial);
            Controls.Add(PriceMaterial);
            Controls.Add(TypeMaterial);
            Controls.Add(DiscMaterial);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "EditMaterial";
            Text = "Изменение материала";
            Load += EditMaterial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Label label1;
        private Panel panel1;
        private TextBox NameMaterial;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox DiscMaterial;
        private ComboBox TypeMaterial;
        private TextBox PriceMaterial;
        private TextBox ColMaterial;
        private TextBox MinColMaterial;
        private ComboBox UnitMaterial;
        private TextBox TextFotoMaterial;
        private Button SaveButtom;
    }
}