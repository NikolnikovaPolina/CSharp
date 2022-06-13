
namespace RocetView
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAstronautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRocetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.AddAstronautToolStripMenuItem,
            this.AddRocetToolStripMenuItem,
            this.AddMoneyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.StartToolStripMenuItem.Text = "Запуск";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // AddAstronautToolStripMenuItem
            // 
            this.AddAstronautToolStripMenuItem.Name = "AddAstronautToolStripMenuItem";
            this.AddAstronautToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.AddAstronautToolStripMenuItem.Text = "Добавить космонавта ";
            // 
            // AddRocetToolStripMenuItem
            // 
            this.AddRocetToolStripMenuItem.Name = "AddRocetToolStripMenuItem";
            this.AddRocetToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.AddRocetToolStripMenuItem.Text = "Добавить ракету";
            // 
            // AddMoneyToolStripMenuItem
            // 
            this.AddMoneyToolStripMenuItem.Name = "AddMoneyToolStripMenuItem";
            this.AddMoneyToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.AddMoneyToolStripMenuItem.Text = "Добавить выплату";
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notificationTextBox.Location = new System.Drawing.Point(0, 24);
            this.notificationTextBox.MaximumSize = new System.Drawing.Size(322, 602);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.ReadOnly = true;
            this.notificationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notificationTextBox.Size = new System.Drawing.Size(322, 602);
            this.notificationTextBox.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox.Location = new System.Drawing.Point(326, 24);
            this.pictureBox.MaximumSize = new System.Drawing.Size(862, 602);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(862, 602);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1188, 631);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.notificationTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

