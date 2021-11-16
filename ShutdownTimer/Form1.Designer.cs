
namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.counterTxt = new System.Windows.Forms.MaskedTextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.counterLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // counterTxt
            // 
            this.counterTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.counterTxt.Location = new System.Drawing.Point(218, 43);
            this.counterTxt.Mask = "00:00:00";
            this.counterTxt.Name = "counterTxt";
            this.counterTxt.Size = new System.Drawing.Size(100, 34);
            this.counterTxt.TabIndex = 0;
            this.counterTxt.ValidatingType = typeof(int);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(228, 93);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Başlat";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Location = new System.Drawing.Point(234, 164);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(64, 17);
            this.counterLbl.TabIndex = 5;
            this.counterLbl.Text = "00:00:00";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(228, 122);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 209);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.counterLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.counterTxt);
            this.Name = "Form1";
            this.Text = "Sayaç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox counterTxt;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Timer timer1;
    }
}

