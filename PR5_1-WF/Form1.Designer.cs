namespace PR5_1_WF
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
			this.task1 = new System.Windows.Forms.GroupBox();
			this.tabel = new System.Windows.Forms.RichTextBox();
			this.step = new System.Windows.Forms.TextBox();
			this.step_label = new System.Windows.Forms.Label();
			this.border2 = new System.Windows.Forms.TextBox();
			this.border1 = new System.Windows.Forms.TextBox();
			this.border2_label = new System.Windows.Forms.Label();
			this.border1_label = new System.Windows.Forms.Label();
			this.calculate2 = new System.Windows.Forms.Button();
			this.task1.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.tabel);
			this.task1.Controls.Add(this.step);
			this.task1.Controls.Add(this.step_label);
			this.task1.Controls.Add(this.border2);
			this.task1.Controls.Add(this.border1);
			this.task1.Controls.Add(this.border2_label);
			this.task1.Controls.Add(this.border1_label);
			this.task1.Controls.Add(this.calculate2);
			this.task1.Location = new System.Drawing.Point(12, 12);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(312, 297);
			this.task1.TabIndex = 2;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// tabel
			// 
			this.tabel.Location = new System.Drawing.Point(22, 131);
			this.tabel.Name = "tabel";
			this.tabel.Size = new System.Drawing.Size(263, 96);
			this.tabel.TabIndex = 7;
			this.tabel.Text = "";
			// 
			// step
			// 
			this.step.Location = new System.Drawing.Point(216, 97);
			this.step.Name = "step";
			this.step.Size = new System.Drawing.Size(90, 22);
			this.step.TabIndex = 6;
			this.step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.border1_KeyPress);
			// 
			// step_label
			// 
			this.step_label.AutoSize = true;
			this.step_label.Location = new System.Drawing.Point(15, 97);
			this.step_label.Name = "step_label";
			this.step_label.Size = new System.Drawing.Size(40, 17);
			this.step_label.TabIndex = 5;
			this.step_label.Text = "Шаг: ";
			// 
			// border2
			// 
			this.border2.Location = new System.Drawing.Point(216, 69);
			this.border2.Name = "border2";
			this.border2.Size = new System.Drawing.Size(90, 22);
			this.border2.TabIndex = 4;
			this.border2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.border1_KeyPress);
			// 
			// border1
			// 
			this.border1.Location = new System.Drawing.Point(216, 43);
			this.border1.Name = "border1";
			this.border1.Size = new System.Drawing.Size(90, 22);
			this.border1.TabIndex = 3;
			this.border1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.border1_KeyPress);
			// 
			// border2_label
			// 
			this.border2_label.AutoSize = true;
			this.border2_label.Location = new System.Drawing.Point(15, 70);
			this.border2_label.Name = "border2_label";
			this.border2_label.Size = new System.Drawing.Size(199, 17);
			this.border2_label.TabIndex = 2;
			this.border2_label.Text = "Верхняя граница диапазона:";
			// 
			// border1_label
			// 
			this.border1_label.AutoSize = true;
			this.border1_label.Location = new System.Drawing.Point(15, 43);
			this.border1_label.Name = "border1_label";
			this.border1_label.Size = new System.Drawing.Size(195, 17);
			this.border1_label.TabIndex = 1;
			this.border1_label.Text = "Нижняя граница диапазона:";
			// 
			// calculate2
			// 
			this.calculate2.Location = new System.Drawing.Point(159, 246);
			this.calculate2.Name = "calculate2";
			this.calculate2.Size = new System.Drawing.Size(147, 38);
			this.calculate2.TabIndex = 0;
			this.calculate2.Text = "Расчитать";
			this.calculate2.UseVisualStyleBackColor = true;
			this.calculate2.Click += new System.EventHandler(this.calculate2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 319);
			this.Controls.Add(this.task1);
			this.Name = "Form1";
			this.Text = "Практикум 5";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.RichTextBox tabel;
		private System.Windows.Forms.TextBox step;
		private System.Windows.Forms.Label step_label;
		private System.Windows.Forms.TextBox border2;
		private System.Windows.Forms.TextBox border1;
		private System.Windows.Forms.Label border2_label;
		private System.Windows.Forms.Label border1_label;
		private System.Windows.Forms.Button calculate2;
	}
}

