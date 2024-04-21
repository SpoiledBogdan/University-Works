
namespace Kurs1
{
    partial class Filtration
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
            this.filterField1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filterText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.exportToJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterField1
            // 
            this.filterField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterField1.Font = new System.Drawing.Font("Consolas", 10F);
            this.filterField1.FormattingEnabled = true;
            this.filterField1.Location = new System.Drawing.Point(58, 27);
            this.filterField1.Name = "filterField1";
            this.filterField1.Size = new System.Drawing.Size(245, 23);
            this.filterField1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F);
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поле";
            // 
            // filterText
            // 
            this.filterText.Font = new System.Drawing.Font("Consolas", 10F);
            this.filterText.Location = new System.Drawing.Point(58, 56);
            this.filterText.Name = "filterText";
            this.filterText.Size = new System.Drawing.Size(245, 23);
            this.filterText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F);
            this.label6.Location = new System.Drawing.Point(4, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Текст";
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Consolas", 10F);
            this.filter.Location = new System.Drawing.Point(7, 85);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(128, 32);
            this.filter.TabIndex = 14;
            this.filter.Text = "Фильтровать";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // exportToJSON
            // 
            this.exportToJSON.Font = new System.Drawing.Font("Consolas", 10F);
            this.exportToJSON.Location = new System.Drawing.Point(141, 85);
            this.exportToJSON.Name = "exportToJSON";
            this.exportToJSON.Size = new System.Drawing.Size(162, 32);
            this.exportToJSON.TabIndex = 15;
            this.exportToJSON.Text = "Экспорт в JSON";
            this.exportToJSON.UseVisualStyleBackColor = true;
            this.exportToJSON.Click += new System.EventHandler(this.exportToJSON_Click);
            // 
            // Filtration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 137);
            this.Controls.Add(this.exportToJSON);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterField1);
            this.Name = "Filtration";
            this.Text = "Фильтрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterField1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button exportToJSON;
    }
}