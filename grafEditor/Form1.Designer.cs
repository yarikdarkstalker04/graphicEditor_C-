
namespace grafEditor
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
            this.button1 = new System.Windows.Forms.Button();
            this.buckButton = new System.Windows.Forms.Button();
            this.circButton = new System.Windows.Forms.Button();
            this.rectButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buckButton
            // 
            this.buckButton.AutoSize = true;
            this.buckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buckButton.Image = global::grafEditor.Properties.Resources.buck;
            this.buckButton.Location = new System.Drawing.Point(260, 12);
            this.buckButton.Name = "buckButton";
            this.buckButton.Size = new System.Drawing.Size(56, 56);
            this.buckButton.TabIndex = 6;
            this.buckButton.UseVisualStyleBackColor = true;
            this.buckButton.Click += new System.EventHandler(this.buckButton_Click);
            // 
            // circButton
            // 
            this.circButton.AutoSize = true;
            this.circButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.circButton.Image = global::grafEditor.Properties.Resources.circ;
            this.circButton.Location = new System.Drawing.Point(198, 12);
            this.circButton.Name = "circButton";
            this.circButton.Size = new System.Drawing.Size(56, 56);
            this.circButton.TabIndex = 5;
            this.circButton.UseVisualStyleBackColor = true;
            this.circButton.Click += new System.EventHandler(this.circButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.AutoSize = true;
            this.rectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rectButton.Image = global::grafEditor.Properties.Resources.rect;
            this.rectButton.Location = new System.Drawing.Point(136, 12);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(56, 56);
            this.rectButton.TabIndex = 4;
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = true;
            this.lineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lineButton.Image = global::grafEditor.Properties.Resources.line1;
            this.lineButton.Location = new System.Drawing.Point(74, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(56, 56);
            this.lineButton.TabIndex = 3;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Image = global::grafEditor.Properties.Resources.penc;
            this.pencilButton.Location = new System.Drawing.Point(12, 12);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(56, 56);
            this.pencilButton.TabIndex = 2;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 535);
            this.Controls.Add(this.buckButton);
            this.Controls.Add(this.circButton);
            this.Controls.Add(this.rectButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.pencilButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button circButton;
        private System.Windows.Forms.Button buckButton;
    }
}

