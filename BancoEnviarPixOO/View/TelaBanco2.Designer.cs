namespace BancoEnviarPixOO.View
{
    partial class TelaBanco2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_nomeb2 = new System.Windows.Forms.Label();
            this.lbl_cpfb2 = new System.Windows.Forms.Label();
            this.lbl_saldob2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 77);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fazer Pix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 77);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Saldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_nomeb2
            // 
            this.lbl_nomeb2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_nomeb2.Location = new System.Drawing.Point(113, 39);
            this.lbl_nomeb2.Name = "lbl_nomeb2";
            this.lbl_nomeb2.Size = new System.Drawing.Size(254, 23);
            this.lbl_nomeb2.TabIndex = 5;
            this.lbl_nomeb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cpfb2
            // 
            this.lbl_cpfb2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_cpfb2.Location = new System.Drawing.Point(113, 85);
            this.lbl_cpfb2.Name = "lbl_cpfb2";
            this.lbl_cpfb2.Size = new System.Drawing.Size(254, 23);
            this.lbl_cpfb2.TabIndex = 6;
            this.lbl_cpfb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_saldob2
            // 
            this.lbl_saldob2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_saldob2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_saldob2.Location = new System.Drawing.Point(113, 129);
            this.lbl_saldob2.Name = "lbl_saldob2";
            this.lbl_saldob2.Size = new System.Drawing.Size(254, 23);
            this.lbl_saldob2.TabIndex = 7;
            this.lbl_saldob2.Text = " Para ver o saldo - Cliqui no botão";
            this.lbl_saldob2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_saldob2.Click += new System.EventHandler(this.lbl_saldob2_Click);
            // 
            // TelaBanco2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 301);
            this.Controls.Add(this.lbl_saldob2);
            this.Controls.Add(this.lbl_cpfb2);
            this.Controls.Add(this.lbl_nomeb2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaBanco2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco 2";
            this.Load += new System.EventHandler(this.TelaBanco2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label lbl_nomeb2;
        private Label lbl_cpfb2;
        private Label lbl_saldob2;
    }
}