
namespace JapaneseCrosswords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.f4 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.f4);
            this.panel1.Controls.Add(this.f3);
            this.panel1.Controls.Add(this.f2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 150);
            this.panel1.TabIndex = 17;
            // 
            // f4
            // 
            this.f4.Location = new System.Drawing.Point(62, 106);
            this.f4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(125, 24);
            this.f4.TabIndex = 16;
            this.f4.Text = "Яблоко 15х15";
            this.f4.UseVisualStyleBackColor = true;
            this.f4.Click += new System.EventHandler(this.f4_Click);
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(62, 64);
            this.f3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(125, 24);
            this.f3.TabIndex = 15;
            this.f3.Text = "Фотоаппарат 10х10";
            this.f3.UseVisualStyleBackColor = true;
            this.f3.Click += new System.EventHandler(this.f3_Click);
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(62, 23);
            this.f2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(125, 24);
            this.f2.TabIndex = 14;
            this.f2.Text = "Кролик 5х5";
            this.f2.UseVisualStyleBackColor = true;
            this.f2.Click += new System.EventHandler(this.f2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 171);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Японские кроссворды";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Button f4;
        private System.Windows.Forms.Button f3;
    }
}

