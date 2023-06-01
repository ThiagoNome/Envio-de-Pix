namespace BancoEnviarPixOO.View
{
    partial class TelaPix
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_saldoorigin = new System.Windows.Forms.Label();
            this.lb_cpforigin = new System.Windows.Forms.Label();
            this.lb_nomeOrigin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_nomedestino = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_cpfdestino = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_transferir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_saldoorigin);
            this.groupBox1.Controls.Add(this.lb_cpforigin);
            this.groupBox1.Controls.Add(this.lb_nomeOrigin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(33, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seus dados";
            // 
            // lb_saldoorigin
            // 
            this.lb_saldoorigin.BackColor = System.Drawing.SystemColors.Info;
            this.lb_saldoorigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_saldoorigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_saldoorigin.Location = new System.Drawing.Point(55, 94);
            this.lb_saldoorigin.Name = "lb_saldoorigin";
            this.lb_saldoorigin.Size = new System.Drawing.Size(149, 23);
            this.lb_saldoorigin.TabIndex = 9;
            this.lb_saldoorigin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_cpforigin
            // 
            this.lb_cpforigin.BackColor = System.Drawing.SystemColors.Info;
            this.lb_cpforigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_cpforigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cpforigin.Location = new System.Drawing.Point(55, 61);
            this.lb_cpforigin.Name = "lb_cpforigin";
            this.lb_cpforigin.Size = new System.Drawing.Size(198, 23);
            this.lb_cpforigin.TabIndex = 8;
            this.lb_cpforigin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_nomeOrigin
            // 
            this.lb_nomeOrigin.BackColor = System.Drawing.SystemColors.Info;
            this.lb_nomeOrigin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_nomeOrigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nomeOrigin.Location = new System.Drawing.Point(55, 28);
            this.lb_nomeOrigin.Name = "lb_nomeOrigin";
            this.lb_nomeOrigin.Size = new System.Drawing.Size(275, 23);
            this.lb_nomeOrigin.TabIndex = 7;
            this.lb_nomeOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_nomeOrigin.Click += new System.EventHandler(this.lb_nomeOrigin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_nomedestino);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lb_cpfdestino);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(33, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // lb_nomedestino
            // 
            this.lb_nomedestino.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_nomedestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_nomedestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nomedestino.Location = new System.Drawing.Point(55, 29);
            this.lb_nomedestino.Name = "lb_nomedestino";
            this.lb_nomedestino.Size = new System.Drawing.Size(275, 23);
            this.lb_nomedestino.TabIndex = 10;
            this.lb_nomedestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(55, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 9;
            // 
            // lb_cpfdestino
            // 
            this.lb_cpfdestino.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_cpfdestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_cpfdestino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cpfdestino.Location = new System.Drawing.Point(55, 66);
            this.lb_cpfdestino.Name = "lb_cpfdestino";
            this.lb_cpfdestino.Size = new System.Drawing.Size(198, 23);
            this.lb_cpfdestino.TabIndex = 8;
            this.lb_cpfdestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // btn_transferir
            // 
            this.btn_transferir.Location = new System.Drawing.Point(282, 359);
            this.btn_transferir.Name = "btn_transferir";
            this.btn_transferir.Size = new System.Drawing.Size(133, 39);
            this.btn_transferir.TabIndex = 6;
            this.btn_transferir.Text = "Transferir";
            this.btn_transferir.UseVisualStyleBackColor = true;
            this.btn_transferir.Click += new System.EventHandler(this.btn_transferir_Click);
            // 
            // TelaPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 410);
            this.Controls.Add(this.btn_transferir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaPix";
            this.ShowIcon = false;
            this.Text = "TelaPix";
            this.Load += new System.EventHandler(this.TelaPix_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Button btn_transferir;
        private Label lb_saldoorigin;
        private Label lb_cpforigin;
        private Label lb_nomeOrigin;
        private TextBox textBox1;
        private Label lb_cpfdestino;
        private Label lb_nomedestino;
        private Label label12;
    }
}