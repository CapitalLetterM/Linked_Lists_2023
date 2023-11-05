namespace LinkedLists_7
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
            this.buttonMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxList1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxList2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxList3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(7, 90);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(322, 23);
            this.buttonMerge.TabIndex = 35;
            this.buttonMerge.Text = "З\'єднати";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(72, 119);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(257, 20);
            this.textBoxResult.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Список 1";
            // 
            // textBoxList1
            // 
            this.textBoxList1.Location = new System.Drawing.Point(72, 12);
            this.textBoxList1.Name = "textBoxList1";
            this.textBoxList1.Size = new System.Drawing.Size(257, 20);
            this.textBoxList1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Список 2";
            // 
            // textBoxList2
            // 
            this.textBoxList2.Location = new System.Drawing.Point(72, 38);
            this.textBoxList2.Name = "textBoxList2";
            this.textBoxList2.Size = new System.Drawing.Size(257, 20);
            this.textBoxList2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Список 3";
            // 
            // textBoxList3
            // 
            this.textBoxList3.Location = new System.Drawing.Point(72, 64);
            this.textBoxList3.Name = "textBoxList3";
            this.textBoxList3.Size = new System.Drawing.Size(257, 20);
            this.textBoxList3.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 148);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxList3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxList2);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxList2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxList3;
    }
}

