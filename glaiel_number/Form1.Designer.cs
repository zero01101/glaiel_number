namespace glaiel_number
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNumberGoUp = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNumberGoUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThisMany = new System.Windows.Forms.Label();
            this.lblShebang = new System.Windows.Forms.Label();
            this.lblInstant = new System.Windows.Forms.Label();
            this.zynga = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(126, 46);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNumberGoUp
            // 
            this.lblNumberGoUp.AutoSize = true;
            this.lblNumberGoUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberGoUp.Location = new System.Drawing.Point(15, 55);
            this.lblNumberGoUp.Name = "lblNumberGoUp";
            this.lblNumberGoUp.Size = new System.Drawing.Size(70, 26);
            this.lblNumberGoUp.TabIndex = 1;
            this.lblNumberGoUp.Text = "label1";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 107);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNumberGoUp
            // 
            this.btnNumberGoUp.Enabled = false;
            this.btnNumberGoUp.Location = new System.Drawing.Point(93, 107);
            this.btnNumberGoUp.Name = "btnNumberGoUp";
            this.btnNumberGoUp.Size = new System.Drawing.Size(485, 23);
            this.btnNumberGoUp.TabIndex = 3;
            this.btnNumberGoUp.Text = "number go up";
            this.btnNumberGoUp.UseVisualStyleBackColor = true;
            this.btnNumberGoUp.Click += new System.EventHandler(this.btnNumberGoUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "it costs this many number to upgrade number go up: ";
            // 
            // lblThisMany
            // 
            this.lblThisMany.AutoSize = true;
            this.lblThisMany.Location = new System.Drawing.Point(276, 81);
            this.lblThisMany.Name = "lblThisMany";
            this.lblThisMany.Size = new System.Drawing.Size(35, 13);
            this.lblThisMany.TabIndex = 5;
            this.lblThisMany.Text = "label2";
            // 
            // lblShebang
            // 
            this.lblShebang.AutoSize = true;
            this.lblShebang.Location = new System.Drawing.Point(421, 55);
            this.lblShebang.Name = "lblShebang";
            this.lblShebang.Size = new System.Drawing.Size(0, 13);
            this.lblShebang.TabIndex = 6;
            // 
            // lblInstant
            // 
            this.lblInstant.AutoSize = true;
            this.lblInstant.Location = new System.Drawing.Point(421, 81);
            this.lblInstant.Name = "lblInstant";
            this.lblInstant.Size = new System.Drawing.Size(0, 13);
            this.lblInstant.TabIndex = 7;
            // 
            // zynga
            // 
            this.zynga.AutoSize = true;
            this.zynga.Location = new System.Drawing.Point(424, 12);
            this.zynga.Name = "zynga";
            this.zynga.Size = new System.Drawing.Size(57, 17);
            this.zynga.TabIndex = 8;
            this.zynga.Text = "zynga!";
            this.zynga.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 141);
            this.Controls.Add(this.zynga);
            this.Controls.Add(this.lblInstant);
            this.Controls.Add(this.lblShebang);
            this.Controls.Add(this.lblThisMany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNumberGoUp);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblNumberGoUp);
            this.Controls.Add(this.lblNumber);
            this.MaximumSize = new System.Drawing.Size(614, 180);
            this.MinimumSize = new System.Drawing.Size(614, 180);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNumberGoUp;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNumberGoUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThisMany;
        private System.Windows.Forms.Label lblShebang;
        private System.Windows.Forms.Label lblInstant;
        private System.Windows.Forms.CheckBox zynga;
    }
}

