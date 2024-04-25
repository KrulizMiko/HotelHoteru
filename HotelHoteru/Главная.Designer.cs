namespace HotelHoteru
{
    partial class Главная
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Главная));
            this.переход = new System.Windows.Forms.Button();
            this.переход2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // переход
            // 
            this.переход.BackColor = System.Drawing.Color.Transparent;
            this.переход.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.переход.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.переход.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.переход.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.переход.ForeColor = System.Drawing.Color.Transparent;
            this.переход.Location = new System.Drawing.Point(12, 12);
            this.переход.Name = "переход";
            this.переход.Size = new System.Drawing.Size(91, 29);
            this.переход.TabIndex = 0;
            this.переход.Text = "Номера";
            this.переход.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.переход.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.переход.UseVisualStyleBackColor = false;
            this.переход.Click += new System.EventHandler(this.переход_Click);
            // 
            // переход2
            // 
            this.переход2.BackColor = System.Drawing.Color.Transparent;
            this.переход2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.переход2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.переход2.ForeColor = System.Drawing.Color.Transparent;
            this.переход2.Location = new System.Drawing.Point(109, 12);
            this.переход2.Name = "переход2";
            this.переход2.Size = new System.Drawing.Size(69, 29);
            this.переход2.TabIndex = 1;
            this.переход2.Text = "Акции";
            this.переход2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.переход2.UseVisualStyleBackColor = false;
            this.переход2.Click += new System.EventHandler(this.переход2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(184, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Мероприятия";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(139, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = " Hoteru Izhevsk Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(284, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отель для вас";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(316, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "О нас";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.переход2);
            this.Controls.Add(this.переход);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Главная";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tag = "";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button переход;
        private System.Windows.Forms.Button переход2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

