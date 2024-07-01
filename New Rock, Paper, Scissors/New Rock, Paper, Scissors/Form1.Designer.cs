namespace New_Rock__Paper__Scissors
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
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.eRock = new System.Windows.Forms.PictureBox();
            this.ePaper = new System.Windows.Forms.PictureBox();
            this.eScissors = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // Scissors
            // 
            this.Scissors.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Scissors;
            this.Scissors.Location = new System.Drawing.Point(527, 300);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(130, 130);
            this.Scissors.TabIndex = 2;
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Paper;
            this.Paper.Location = new System.Drawing.Point(300, 300);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(130, 130);
            this.Paper.TabIndex = 1;
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Rock
            // 
            this.Rock.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Rock1;
            this.Rock.Location = new System.Drawing.Point(74, 300);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(130, 130);
            this.Rock.TabIndex = 0;
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // eRock
            // 
            this.eRock.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Rock;
            this.eRock.Location = new System.Drawing.Point(300, -130);
            this.eRock.Name = "eRock";
            this.eRock.Size = new System.Drawing.Size(130, 130);
            this.eRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eRock.TabIndex = 3;
            this.eRock.TabStop = false;
            // 
            // ePaper
            // 
            this.ePaper.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Paper;
            this.ePaper.Location = new System.Drawing.Point(300, -130);
            this.ePaper.Name = "ePaper";
            this.ePaper.Size = new System.Drawing.Size(130, 130);
            this.ePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePaper.TabIndex = 4;
            this.ePaper.TabStop = false;
            // 
            // eScissors
            // 
            this.eScissors.Image = global::New_Rock__Paper__Scissors.Properties.Resources.Scissors;
            this.eScissors.Location = new System.Drawing.Point(300, -130);
            this.eScissors.Name = "eScissors";
            this.eScissors.Size = new System.Drawing.Size(130, 130);
            this.eScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eScissors.TabIndex = 5;
            this.eScissors.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eScissors);
            this.Controls.Add(this.ePaper);
            this.Controls.Add(this.eRock);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eScissors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.PictureBox eRock;
        private System.Windows.Forms.PictureBox ePaper;
        private System.Windows.Forms.PictureBox eScissors;
    }
}

