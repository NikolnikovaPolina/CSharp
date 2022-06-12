namespace PaperReflexForm
{
    partial class ReflectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classFieldsBox = new System.Windows.Forms.ListBox();
            this.parametersBox = new System.Windows.Forms.ListBox();
            this.createClassButton = new System.Windows.Forms.Button();
            this.fillParametersButton = new System.Windows.Forms.Button();
            this.executeMethodButton = new System.Windows.Forms.Button();
            this.choiceClassBox = new System.Windows.Forms.ComboBox();
            this.choiceMethodBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбор класса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор метода класса";
            // 
            // classFieldsBox
            // 
            this.classFieldsBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classFieldsBox.FormattingEnabled = true;
            this.classFieldsBox.ItemHeight = 25;
            this.classFieldsBox.Location = new System.Drawing.Point(373, 37);
            this.classFieldsBox.Name = "classFieldsBox";
            this.classFieldsBox.Size = new System.Drawing.Size(368, 179);
            this.classFieldsBox.TabIndex = 2;
            // 
            // parametersBox
            // 
            this.parametersBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parametersBox.FormattingEnabled = true;
            this.parametersBox.ItemHeight = 25;
            this.parametersBox.Location = new System.Drawing.Point(373, 254);
            this.parametersBox.Name = "parametersBox";
            this.parametersBox.Size = new System.Drawing.Size(368, 179);
            this.parametersBox.TabIndex = 3;
            // 
            // createClassButton
            // 
            this.createClassButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createClassButton.Location = new System.Drawing.Point(34, 186);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(251, 78);
            this.createClassButton.TabIndex = 4;
            this.createClassButton.Text = "Создать класс";
            this.createClassButton.UseVisualStyleBackColor = true;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // fillParametersButton
            // 
            this.fillParametersButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fillParametersButton.Location = new System.Drawing.Point(34, 270);
            this.fillParametersButton.Name = "fillParametersButton";
            this.fillParametersButton.Size = new System.Drawing.Size(251, 78);
            this.fillParametersButton.TabIndex = 5;
            this.fillParametersButton.Text = "Ввести параметры метода";
            this.fillParametersButton.UseVisualStyleBackColor = true;
            this.fillParametersButton.Click += new System.EventHandler(this.fillParametersButton_Click);
            // 
            // executeMethodButton
            // 
            this.executeMethodButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.executeMethodButton.Location = new System.Drawing.Point(34, 354);
            this.executeMethodButton.Name = "executeMethodButton";
            this.executeMethodButton.Size = new System.Drawing.Size(251, 78);
            this.executeMethodButton.TabIndex = 6;
            this.executeMethodButton.Text = "Выполнить выбранный метод";
            this.executeMethodButton.UseVisualStyleBackColor = true;
            this.executeMethodButton.Click += new System.EventHandler(this.executeMethodButton_Click);
            // 
            // choiceClassBox
            // 
            this.choiceClassBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choiceClassBox.FormattingEnabled = true;
            this.choiceClassBox.Location = new System.Drawing.Point(34, 45);
            this.choiceClassBox.Name = "choiceClassBox";
            this.choiceClassBox.Size = new System.Drawing.Size(241, 33);
            this.choiceClassBox.TabIndex = 7;
            this.choiceClassBox.SelectedIndexChanged += new System.EventHandler(this.choiceClassBox_SelectedIndexChanged);
            // 
            // choiceMethodBox
            // 
            this.choiceMethodBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choiceMethodBox.FormattingEnabled = true;
            this.choiceMethodBox.Location = new System.Drawing.Point(34, 124);
            this.choiceMethodBox.Name = "choiceMethodBox";
            this.choiceMethodBox.Size = new System.Drawing.Size(241, 33);
            this.choiceMethodBox.TabIndex = 8;
            this.choiceMethodBox.SelectedIndexChanged += new System.EventHandler(this.choiceMethodBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поля класса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(373, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Параметры выбранного метода\r\n";
            // 
            // ReflectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choiceMethodBox);
            this.Controls.Add(this.choiceClassBox);
            this.Controls.Add(this.executeMethodButton);
            this.Controls.Add(this.fillParametersButton);
            this.Controls.Add(this.createClassButton);
            this.Controls.Add(this.parametersBox);
            this.Controls.Add(this.classFieldsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReflectionForm";
            this.Text = "ReflectionForm";
            this.Load += new System.EventHandler(this.ReflectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox classFieldsBox;
        private ListBox parametersBox;
        private Button createClassButton;
        private Button fillParametersButton;
        private Button executeMethodButton;
        private ComboBox choiceClassBox;
        private ComboBox choiceMethodBox;
        private Label label3;
        private Label label4;
    }
}