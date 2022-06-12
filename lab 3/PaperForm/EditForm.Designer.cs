namespace PaperForm
{
    partial class EditForm
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
            this.colorBox = new System.Windows.Forms.TextBox();
            this.countBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addSheetsButton = new System.Windows.Forms.Button();
            this.deleteSheetsButton = new System.Windows.Forms.Button();
            this.quallityButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorBox.Location = new System.Drawing.Point(283, 31);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(138, 32);
            this.colorBox.TabIndex = 0;
            // 
            // countBox
            // 
            this.countBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countBox.Location = new System.Drawing.Point(283, 97);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(138, 32);
            this.countBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество листов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Id";
            // 
            // weightBox
            // 
            this.weightBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weightBox.Location = new System.Drawing.Point(283, 165);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(138, 32);
            this.weightBox.TabIndex = 7;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceBox.Location = new System.Drawing.Point(283, 225);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(138, 32);
            this.priceBox.TabIndex = 8;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idBox.Location = new System.Drawing.Point(283, 286);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(138, 32);
            this.idBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(448, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Изменить цвет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addSheetsButton
            // 
            this.addSheetsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addSheetsButton.Location = new System.Drawing.Point(448, 93);
            this.addSheetsButton.Name = "addSheetsButton";
            this.addSheetsButton.Size = new System.Drawing.Size(216, 48);
            this.addSheetsButton.TabIndex = 11;
            this.addSheetsButton.Text = "Добавить листы";
            this.addSheetsButton.UseVisualStyleBackColor = true;
            this.addSheetsButton.Click += new System.EventHandler(this.addSheetsButton_Click);
            // 
            // deleteSheetsButton
            // 
            this.deleteSheetsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSheetsButton.Location = new System.Drawing.Point(448, 161);
            this.deleteSheetsButton.Name = "deleteSheetsButton";
            this.deleteSheetsButton.Size = new System.Drawing.Size(216, 48);
            this.deleteSheetsButton.TabIndex = 12;
            this.deleteSheetsButton.Text = "Вырвать листы";
            this.deleteSheetsButton.UseVisualStyleBackColor = true;
            this.deleteSheetsButton.Click += new System.EventHandler(this.deleteSheetsButton_Click);
            // 
            // quallityButton
            // 
            this.quallityButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quallityButton.Location = new System.Drawing.Point(448, 230);
            this.quallityButton.Name = "quallityButton";
            this.quallityButton.Size = new System.Drawing.Size(216, 56);
            this.quallityButton.TabIndex = 13;
            this.quallityButton.Text = "Рассчитать качество";
            this.quallityButton.UseVisualStyleBackColor = true;
            this.quallityButton.Click += new System.EventHandler(this.quallityButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(448, 308);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(216, 52);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 380);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quallityButton);
            this.Controls.Add(this.deleteSheetsButton);
            this.Controls.Add(this.addSheetsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.colorBox);
            this.Name = "EditForm";
            this.Text = "Изменение тетради";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox colorBox;
        private TextBox countBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox weightBox;
        private TextBox priceBox;
        private TextBox idBox;
        private Button button1;
        private Button addSheetsButton;
        private Button deleteSheetsButton;
        private Button quallityButton;
        private Button saveButton;
    }
}