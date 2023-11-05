namespace LinkedLists_8
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(13, 64);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(322, 23);
            this.buttonSort.TabIndex = 37;
            this.buttonSort.Text = "Відсортувати";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(78, 93);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(257, 20);
            this.textBoxResult.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Список";
            // 
            // textBoxList
            // 
            this.textBoxList.Location = new System.Drawing.Point(78, 12);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(257, 20);
            this.textBoxList.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Відрізок";
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(78, 38);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(257, 20);
            this.textBoxPeriod.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.buttonSort);
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
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPeriod;
    }
}

