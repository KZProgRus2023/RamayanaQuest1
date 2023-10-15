namespace RamayanaQuest1
{
    partial class RamayanaQuest1Form
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.optionAButton = new System.Windows.Forms.Button();
            this.optionBButton = new System.Windows.Forms.Button();
            this.optionCButton = new System.Windows.Forms.Button();
            this.optionDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(265, 55);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 13);
            this.questionLabel.TabIndex = 0;
            // 
            // optionAButton
            // 
            this.optionAButton.Location = new System.Drawing.Point(184, 151);
            this.optionAButton.Name = "optionAButton";
            this.optionAButton.Size = new System.Drawing.Size(75, 23);
            this.optionAButton.TabIndex = 1;
            this.optionAButton.UseVisualStyleBackColor = true;
            // 
            // optionBButton
            // 
            this.optionBButton.Location = new System.Drawing.Point(184, 200);
            this.optionBButton.Name = "optionBButton";
            this.optionBButton.Size = new System.Drawing.Size(75, 23);
            this.optionBButton.TabIndex = 2;
            this.optionBButton.UseVisualStyleBackColor = true;
            // 
            // optionCButton
            // 
            this.optionCButton.Location = new System.Drawing.Point(184, 250);
            this.optionCButton.Name = "optionCButton";
            this.optionCButton.Size = new System.Drawing.Size(75, 23);
            this.optionCButton.TabIndex = 3;
            this.optionCButton.UseVisualStyleBackColor = true;
            // 
            // optionDButton
            // 
            this.optionDButton.Location = new System.Drawing.Point(184, 297);
            this.optionDButton.Name = "optionDButton";
            this.optionDButton.Size = new System.Drawing.Size(75, 23);
            this.optionDButton.TabIndex = 4;
            this.optionDButton.UseVisualStyleBackColor = true;
            // 
            // RamayanaQuest1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionDButton);
            this.Controls.Add(this.optionCButton);
            this.Controls.Add(this.optionBButton);
            this.Controls.Add(this.optionAButton);
            this.Controls.Add(this.questionLabel);
            this.Name = "RamayanaQuest1Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button optionAButton;
        private System.Windows.Forms.Button optionBButton;
        private System.Windows.Forms.Button optionCButton;
        private System.Windows.Forms.Button optionDButton;
    }
}

