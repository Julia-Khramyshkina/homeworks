namespace Homework6_task2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // label1
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Highlight;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(203)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Margin = new System.Windows.Forms.Padding(0);
            this.label.Name = "label1";
            this.label.Size = new System.Drawing.Size(208, 76);
            this.label.TabIndex = 0;
            this.label.Text = "watch";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.label);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel1";
            this.flowLayoutPanel.Size = new System.Drawing.Size(350, 77);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 77);
            this.Controls.Add(this.flowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(366, 115);
            this.MinimumSize = new System.Drawing.Size(366, 115);
            this.Name = "Form1";
            this.Text = "Watch";
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;






    }
}

