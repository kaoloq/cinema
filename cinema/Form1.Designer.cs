
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_NameOfFilm = new System.Windows.Forms.TextBox();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.button_SendFilm = new System.Windows.Forms.Button();
            this.textBox_Timetable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CountOfFilms = new System.Windows.Forms.TextBox();
            this.button_SendCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_NameOfFilm
            // 
            this.textBox_NameOfFilm.Location = new System.Drawing.Point(39, 281);
            this.textBox_NameOfFilm.Name = "textBox_NameOfFilm";
            this.textBox_NameOfFilm.Size = new System.Drawing.Size(371, 31);
            this.textBox_NameOfFilm.TabIndex = 0;
            this.textBox_NameOfFilm.Text = "Name of a film";
            this.textBox_NameOfFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(143, 340);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(150, 31);
            this.textBox_Duration.TabIndex = 1;
            this.textBox_Duration.Text = "Duration";
            this.textBox_Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SendFilm
            // 
            this.button_SendFilm.Location = new System.Drawing.Point(162, 400);
            this.button_SendFilm.Name = "button_SendFilm";
            this.button_SendFilm.Size = new System.Drawing.Size(112, 34);
            this.button_SendFilm.TabIndex = 2;
            this.button_SendFilm.Text = "Send";
            this.button_SendFilm.UseVisualStyleBackColor = true;
            this.button_SendFilm.Click += new System.EventHandler(this.button_SendFilm_Click);
            // 
            // textBox_Timetable
            // 
            this.textBox_Timetable.Location = new System.Drawing.Point(449, 72);
            this.textBox_Timetable.Multiline = true;
            this.textBox_Timetable.Name = "textBox_Timetable";
            this.textBox_Timetable.Size = new System.Drawing.Size(508, 564);
            this.textBox_Timetable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timetable";
            // 
            // textBox_CountOfFilms
            // 
            this.textBox_CountOfFilms.Location = new System.Drawing.Point(139, 122);
            this.textBox_CountOfFilms.Name = "textBox_CountOfFilms";
            this.textBox_CountOfFilms.Size = new System.Drawing.Size(150, 31);
            this.textBox_CountOfFilms.TabIndex = 5;
            this.textBox_CountOfFilms.Text = "Count of films";
            this.textBox_CountOfFilms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SendCount
            // 
            this.button_SendCount.Location = new System.Drawing.Point(158, 176);
            this.button_SendCount.Name = "button_SendCount";
            this.button_SendCount.Size = new System.Drawing.Size(112, 34);
            this.button_SendCount.TabIndex = 6;
            this.button_SendCount.Text = "Send";
            this.button_SendCount.UseVisualStyleBackColor = true;
            this.button_SendCount.Click += new System.EventHandler(this.button_SendCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.Controls.Add(this.button_SendCount);
            this.Controls.Add(this.textBox_CountOfFilms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Timetable);
            this.Controls.Add(this.button_SendFilm);
            this.Controls.Add(this.textBox_Duration);
            this.Controls.Add(this.textBox_NameOfFilm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NameOfFilm;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.Button button_SendFilm;
        private System.Windows.Forms.TextBox textBox_Timetable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CountOfFilms;
        private System.Windows.Forms.Button button_SendCount;
    }
}

