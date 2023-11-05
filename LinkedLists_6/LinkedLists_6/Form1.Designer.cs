namespace LinkedLists_6
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
            this.buttonDouble = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDouble
            // 
            this.buttonDouble.Location = new System.Drawing.Point(11, 38);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(322, 23);
            this.buttonDouble.TabIndex = 30;
            this.buttonDouble.Text = "Подвоїти";
            this.buttonDouble.UseVisualStyleBackColor = true;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(76, 67);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(257, 20);
            this.textBoxResult.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Список";
            // 
            // textBoxList
            // 
            this.textBoxList.Location = new System.Drawing.Point(76, 12);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(257, 20);
            this.textBoxList.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 98);
            this.Controls.Add(this.buttonDouble);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDouble;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxList;
    }
}

