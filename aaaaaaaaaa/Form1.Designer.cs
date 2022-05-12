namespace aaaaaaaaaa
{
	partial class Form1
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертерRGBLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волна60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.превитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.усреднениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.градиентГраницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализацияГистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.эквализацияГистограммаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1390, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Open";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.фильтрыToolStripMenuItem.Text = "Filters";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.конвертерRGBLabToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Point Filters";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.инверсияToolStripMenuItem.Text = "Revers";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.ReversToolStripMenuItem_Click);
            // 
            // конвертерRGBLabToolStripMenuItem
            // 
            this.конвертерRGBLabToolStripMenuItem.Name = "конвертерRGBLabToolStripMenuItem";
            this.конвертерRGBLabToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.конвертерRGBLabToolStripMenuItem.Text = "Converter RGB->Lab";
            this.конвертерRGBLabToolStripMenuItem.Click += new System.EventHandler(this.ConverterRGBLabToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.волнаToolStripMenuItem,
            this.волна60ToolStripMenuItem,
            this.превитToolStripMenuItem,
            this.гауссToolStripMenuItem,
            this.усреднениеToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Matrix Filters";
            // 
            // волнаToolStripMenuItem
            // 
            this.волнаToolStripMenuItem.Name = "волнаToolStripMenuItem";
            this.волнаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.волнаToolStripMenuItem.Text = "Wave(30)";
            this.волнаToolStripMenuItem.Click += new System.EventHandler(this.Wave30ToolStripMenuItem_Click);
            // 
            // волна60ToolStripMenuItem
            // 
            this.волна60ToolStripMenuItem.Name = "волна60ToolStripMenuItem";
            this.волна60ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.волна60ToolStripMenuItem.Text = "Wave(60)";
            this.волна60ToolStripMenuItem.Click += new System.EventHandler(this.Wave60ToolStripMenuItem_Click);
            // 
            // превитToolStripMenuItem
            // 
            this.превитToolStripMenuItem.Name = "превитToolStripMenuItem";
            this.превитToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.превитToolStripMenuItem.Text = "Prewitt";
            this.превитToolStripMenuItem.Click += new System.EventHandler(this.PrewittToolStripMenuItem_Click_1);
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.гауссToolStripMenuItem.Text = "Gauss";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.GaussToolStripMenuItem_Click);
            // 
            // усреднениеToolStripMenuItem
            // 
            this.усреднениеToolStripMenuItem.Name = "усреднениеToolStripMenuItem";
            this.усреднениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.усреднениеToolStripMenuItem.Text = "Middle";
            this.усреднениеToolStripMenuItem.Click += new System.EventHandler(this.MiddleToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытиеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.градиентГраницаToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матМорфологияToolStripMenuItem.Text = "Math Morf";
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытиеToolStripMenuItem.Text = "Opening";
            this.открытиеToolStripMenuItem.Click += new System.EventHandler(this.OpeningToolStripMenuItem_Click);
            // 
            // закрытиеToolStripMenuItem
            // 
            this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.закрытиеToolStripMenuItem.Text = "Closing";
            this.закрытиеToolStripMenuItem.Click += new System.EventHandler(this.ClosingToolStripMenuItem_Click);
            // 
            // градиентГраницаToolStripMenuItem
            // 
            this.градиентГраницаToolStripMenuItem.Name = "градиентГраницаToolStripMenuItem";
            this.градиентГраницаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.градиентГраницаToolStripMenuItem.Text = "Fade Border";
            this.градиентГраницаToolStripMenuItem.Click += new System.EventHandler(this.FadeBorderToolStripMenuItem_Click);
            // 
            // эквализацияГистограммаToolStripMenuItem
            // 
            this.эквализацияГистограммаToolStripMenuItem.Name = "эквализацияГистограммаToolStripMenuItem";
            this.эквализацияГистограммаToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.эквализацияГистограммаToolStripMenuItem.Text = "Equalization Gisto";
            this.эквализацияГистограммаToolStripMenuItem.Click += new System.EventHandler(this.EqualizationGistToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(806, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(572, 425);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem конвертерRGBLabToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem волнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волна60ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem превитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem усреднениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эквализацияГистограммаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem матМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem градиентГраницаToolStripMenuItem;
    }
}

