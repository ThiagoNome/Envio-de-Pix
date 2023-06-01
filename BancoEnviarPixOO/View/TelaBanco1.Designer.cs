namespace BancoEnviarPixOO.View
{
    partial class TelaBanco1
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
            this.lbl_saldob1 = new System.Windows.Forms.Label();
            this.lbl_cpfb1 = new System.Windows.Forms.Label();
            this.lbl_nomeb1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_saldob1
            // 
            this.lbl_saldob1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_saldob1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldob1.Location = new System.Drawing.Point(118, 114);
            this.lbl_saldob1.Name = "lbl_saldob1";
            this.lbl_saldob1.Size = new System.Drawing.Size(254, 23);
            this.lbl_saldob1.TabIndex = 15;
            this.lbl_saldob1.Text = " Para ver o saldo - Cliqui no botão";
            this.lbl_saldob1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldob1.Click += new System.EventHandler(this.lbl_saldob1_Click);
            // 
            // lbl_cpfb1
            // 
            this.lbl_cpfb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpfb1.Location = new System.Drawing.Point(118, 70);
            this.lbl_cpfb1.Name = "lbl_cpfb1";
            this.lbl_cpfb1.Size = new System.Drawing.Size(254, 23);
            this.lbl_cpfb1.TabIndex = 14;
            this.lbl_cpfb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_nomeb1
            // 
            this.lbl_nomeb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeb1.Location = new System.Drawing.Point(118, 24);
            this.lbl_nomeb1.Name = "lbl_nomeb1";
            this.lbl_nomeb1.Size = new System.Drawing.Size(254, 23);
            this.lbl_nomeb1.TabIndex = 13;
            this.lbl_nomeb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 77);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ver Saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 77);
            this.button1.TabIndex = 11;
            this.button1.Text = "Fazer Pix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // TelaBanco1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 279);
            this.Controls.Add(this.lbl_saldob1);
            this.Controls.Add(this.lbl_cpfb1);
            this.Controls.Add(this.lbl_nomeb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaBanco1";
            this.ShowIcon = false;
            this.Text = "Banco 1";
            this.Load += new System.EventHandler(this.TelaBanco1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_saldob1;
        private Label lbl_cpfb1;
        private Label lbl_nomeb1;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}