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
            this.блюрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.превиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лассоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.волня30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волня60ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.файлToolStripMenuItem.Text = "файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.открытьToolStripMenuItem.Text = "открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.фильтрыToolStripMenuItem.Text = "фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.конвертерRGBLabToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.инверсияToolStripMenuItem.Text = "инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // конвертерRGBLabToolStripMenuItem
            // 
            this.конвертерRGBLabToolStripMenuItem.Name = "конвертерRGBLabToolStripMenuItem";
            this.конвертерRGBLabToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.конвертерRGBLabToolStripMenuItem.Text = "конвертер RGB->Lab";
            this.конвертерRGBLabToolStripMenuItem.Click += new System.EventHandler(this.конвертерRGBLabToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блюрToolStripMenuItem,
            this.гауссToolStripMenuItem,
            this.превиттToolStripMenuItem,
            this.эквализаторToolStripMenuItem,
            this.волня30ToolStripMenuItem,
            this.волня60ToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "матричные";
            // 
            // блюрToolStripMenuItem
            // 
            this.блюрToolStripMenuItem.Name = "блюрToolStripMenuItem";
            this.блюрToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.блюрToolStripMenuItem.Text = "усреднение";
            this.блюрToolStripMenuItem.Click += new System.EventHandler(this.блюрToolStripMenuItem_Click);
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.гауссToolStripMenuItem.Text = "гаусс";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.гауссToolStripMenuItem_Click);
            // 
            // превиттToolStripMenuItem
            // 
            this.превиттToolStripMenuItem.Name = "превиттToolStripMenuItem";
            this.превиттToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.превиттToolStripMenuItem.Text = "превитт";
            this.превиттToolStripMenuItem.Click += new System.EventHandler(this.превиттToolStripMenuItem_Click);
            // 
            // эквализаторToolStripMenuItem
            // 
            this.эквализаторToolStripMenuItem.Name = "эквализаторToolStripMenuItem";
            this.эквализаторToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.эквализаторToolStripMenuItem.Text = "Эквализатор";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лассоToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.инструментыToolStripMenuItem.Text = "инструменты";
            // 
            // лассоToolStripMenuItem
            // 
            this.лассоToolStripMenuItem.Name = "лассоToolStripMenuItem";
            this.лассоToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.лассоToolStripMenuItem.Text = "лассо";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // волня30ToolStripMenuItem
            // 
            this.волня30ToolStripMenuItem.Name = "волня30ToolStripMenuItem";
            this.волня30ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.волня30ToolStripMenuItem.Text = "Волня(30)";
            this.волня30ToolStripMenuItem.Click += new System.EventHandler(this.волня30ToolStripMenuItem_Click);
            // 
            // волня60ToolStripMenuItem
            // 
            this.волня60ToolStripMenuItem.Name = "волня60ToolStripMenuItem";
            this.волня60ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.волня60ToolStripMenuItem.Text = "Волня(60)";
            this.волня60ToolStripMenuItem.Click += new System.EventHandler(this.волня60ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem лассоToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem конвертерRGBLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem превиттToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эквализаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волня30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волня60ToolStripMenuItem;
    }
}

