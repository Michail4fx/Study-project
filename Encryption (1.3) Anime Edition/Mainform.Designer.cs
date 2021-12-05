
namespace Encryption__1._3__Anime_Edition
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.textBoxCrypt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вспомогательныеФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переставитьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматироватьТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxKeyWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKeyWord.ForeColor = System.Drawing.Color.Gray;
            this.textBoxKeyWord.Location = new System.Drawing.Point(0, 29);
            this.textBoxKeyWord.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxKeyWord.MaxLength = 40;
            this.textBoxKeyWord.Multiline = true;
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(584, 37);
            this.textBoxKeyWord.TabIndex = 7;
            this.textBoxKeyWord.Text = "Введите ключ:";
            this.textBoxKeyWord.WordWrap = false;
            this.textBoxKeyWord.Enter += new System.EventHandler(this.textBoxKeyWord_Enter);
            this.textBoxKeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyWord_KeyPress);
            this.textBoxKeyWord.Leave += new System.EventHandler(this.textBoxKeyWord_Leave);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Start.Location = new System.Drawing.Point(349, 227);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(223, 53);
            this.Start.TabIndex = 12;
            this.Start.Text = "Выполнить";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOriginal.ForeColor = System.Drawing.Color.Gray;
            this.textBoxOriginal.Location = new System.Drawing.Point(0, 74);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(584, 135);
            this.textBoxOriginal.TabIndex = 18;
            this.textBoxOriginal.Text = "Введите текст:";
            this.textBoxOriginal.Enter += new System.EventHandler(this.textBoxOriginal_Enter);
            this.textBoxOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOriginal_KeyPress);
            this.textBoxOriginal.Leave += new System.EventHandler(this.textBoxOriginal_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.decryptRadioButton);
            this.groupBox1.Controls.Add(this.encryptRadioButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 65);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опция:";
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.decryptRadioButton.Location = new System.Drawing.Point(161, 25);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(159, 29);
            this.decryptRadioButton.TabIndex = 1;
            this.decryptRadioButton.Text = "Расшифровать";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(6, 25);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(149, 29);
            this.encryptRadioButton.TabIndex = 0;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Зашифровать";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBoxCrypt
            // 
            this.textBoxCrypt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCrypt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxCrypt.Location = new System.Drawing.Point(0, 286);
            this.textBoxCrypt.Multiline = true;
            this.textBoxCrypt.Name = "textBoxCrypt";
            this.textBoxCrypt.Size = new System.Drawing.Size(584, 210);
            this.textBoxCrypt.TabIndex = 20;
            this.textBoxCrypt.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вспомогательныеФункцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "Файл";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // вспомогательныеФункцииToolStripMenuItem
            // 
            this.вспомогательныеФункцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переставитьТекстToolStripMenuItem,
            this.форматироватьТекстToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.вспомогательныеФункцииToolStripMenuItem.Name = "вспомогательныеФункцииToolStripMenuItem";
            this.вспомогательныеФункцииToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.вспомогательныеФункцииToolStripMenuItem.Text = "Вспомогательные функции";
            // 
            // переставитьТекстToolStripMenuItem
            // 
            this.переставитьТекстToolStripMenuItem.Name = "переставитьТекстToolStripMenuItem";
            this.переставитьТекстToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.переставитьТекстToolStripMenuItem.Text = "Переставить текст";
            this.переставитьТекстToolStripMenuItem.Click += new System.EventHandler(this.переставитьТекстToolStripMenuItem_Click);
            // 
            // форматироватьТекстToolStripMenuItem
            // 
            this.форматироватьТекстToolStripMenuItem.Name = "форматироватьТекстToolStripMenuItem";
            this.форматироватьТекстToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.форматироватьТекстToolStripMenuItem.Text = "Форматировать текст";
            this.форматироватьТекстToolStripMenuItem.Click += new System.EventHandler(this.форматироватьТекстToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(426, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Версия: 1.3 (Anime Edition)";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textBoxKeyWord);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.TextBox textBoxCrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вспомогательныеФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переставитьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматироватьТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

