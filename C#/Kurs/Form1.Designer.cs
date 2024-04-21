
namespace Kurs1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктыОтправленияИНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дниВылетаИПрилетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.table1 = new System.Windows.Forms.DataGridView();
            this.table2 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.search3 = new System.Windows.Forms.Button();
            this.search2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.search1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delete2 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.оПриложенииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пунктыОтправленияИНазначенияToolStripMenuItem,
            this.дниВылетаИПрилетаToolStripMenuItem});
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.фильтрацияToolStripMenuItem.Text = "Фильтрация";
            // 
            // пунктыОтправленияИНазначенияToolStripMenuItem
            // 
            this.пунктыОтправленияИНазначенияToolStripMenuItem.Name = "пунктыОтправленияИНазначенияToolStripMenuItem";
            this.пунктыОтправленияИНазначенияToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.пунктыОтправленияИНазначенияToolStripMenuItem.Text = "Пункты отправления и назначения";
            this.пунктыОтправленияИНазначенияToolStripMenuItem.Click += new System.EventHandler(this.пунктыОтправленияИНазначенияToolStripMenuItem_Click);
            // 
            // дниВылетаИПрилетаToolStripMenuItem
            // 
            this.дниВылетаИПрилетаToolStripMenuItem.Name = "дниВылетаИПрилетаToolStripMenuItem";
            this.дниВылетаИПрилетаToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.дниВылетаИПрилетаToolStripMenuItem.Text = "Дни вылета и прилета";
            this.дниВылетаИПрилетаToolStripMenuItem.Click += new System.EventHandler(this.дниВылетаИПрилетаToolStripMenuItem_Click);
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F);
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // table1
            // 
            this.table1.AllowUserToAddRows = false;
            this.table1.AllowUserToDeleteRows = false;
            this.table1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1.Location = new System.Drawing.Point(12, 47);
            this.table1.Name = "table1";
            this.table1.ReadOnly = true;
            this.table1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table1.Size = new System.Drawing.Size(400, 457);
            this.table1.TabIndex = 0;
            // 
            // table2
            // 
            this.table2.AllowUserToAddRows = false;
            this.table2.AllowUserToDeleteRows = false;
            this.table2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table2.Location = new System.Drawing.Point(418, 47);
            this.table2.Name = "table2";
            this.table2.ReadOnly = true;
            this.table2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table2.Size = new System.Drawing.Size(400, 457);
            this.table2.TabIndex = 0;
            this.table2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table2_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 564);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 22);
            this.comboBox2.TabIndex = 37;
            // 
            // search3
            // 
            this.search3.Location = new System.Drawing.Point(729, 549);
            this.search3.Name = "search3";
            this.search3.Size = new System.Drawing.Size(89, 38);
            this.search3.TabIndex = 36;
            this.search3.Text = "Рейсы не в один день";
            this.search3.UseVisualStyleBackColor = true;
            this.search3.Click += new System.EventHandler(this.search3_Click);
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(218, 564);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(75, 23);
            this.search2.TabIndex = 35;
            this.search2.Text = "Поиск";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 14);
            this.label9.TabIndex = 33;
            this.label9.Text = "Пункт назначения";
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(624, 563);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(75, 23);
            this.search1.TabIndex = 32;
            this.search1.Text = "Поиск";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 563);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 22);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "День недели";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // delete2
            // 
            this.delete2.Font = new System.Drawing.Font("Consolas", 11F);
            this.delete2.Location = new System.Drawing.Point(663, 510);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(93, 32);
            this.delete2.TabIndex = 25;
            this.delete2.Text = "Удалить";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // delete1
            // 
            this.delete1.Font = new System.Drawing.Font("Consolas", 11F);
            this.delete1.Location = new System.Drawing.Point(257, 510);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(93, 32);
            this.delete1.TabIndex = 24;
            this.delete1.Text = "Удалить";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // edit2
            // 
            this.edit2.Font = new System.Drawing.Font("Consolas", 10F);
            this.edit2.Location = new System.Drawing.Point(517, 510);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(140, 32);
            this.edit2.TabIndex = 5;
            this.edit2.Text = "Редактировать";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // add2
            // 
            this.add2.Font = new System.Drawing.Font("Consolas", 10F);
            this.add2.Location = new System.Drawing.Point(418, 510);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(93, 32);
            this.add2.TabIndex = 4;
            this.add2.Text = "Добавить";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пункты отправления и назначения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.Location = new System.Drawing.Point(415, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дни вылета и прилета";
            // 
            // add1
            // 
            this.add1.Font = new System.Drawing.Font("Consolas", 10F);
            this.add1.Location = new System.Drawing.Point(12, 510);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(93, 32);
            this.add1.TabIndex = 1;
            this.add1.Text = "Добавить";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // edit1
            // 
            this.edit1.Font = new System.Drawing.Font("Consolas", 10F);
            this.edit1.Location = new System.Drawing.Point(111, 510);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(140, 32);
            this.edit1.TabIndex = 2;
            this.edit1.Text = "Редактировать";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 594);
            this.Controls.Add(this.search3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Справочник самолетов";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button search3;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктыОтправленияИНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дниВылетаИПрилетаToolStripMenuItem;
        public System.Windows.Forms.DataGridView table1;
        public System.Windows.Forms.DataGridView table2;
    }
}

