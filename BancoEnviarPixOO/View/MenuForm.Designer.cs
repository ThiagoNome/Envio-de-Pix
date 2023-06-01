namespace BancoEnviarPixOO.View
{
    partial class MenuForm
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
            this.btn_banco1 = new System.Windows.Forms.Button();
            this.btn_banco2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_banco1
            // 
            this.btn_banco1.BackColor = System.Drawing.SystemColors.Info;
            this.btn_banco1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_banco1.Location = new System.Drawing.Point(12, 98);
            this.btn_banco1.Name = "btn_banco1";
            this.btn_banco1.Size = new System.Drawing.Size(248, 167);
            this.btn_banco1.TabIndex = 0;
            this.btn_banco1.Text = "Banco 1";
            this.btn_banco1.UseVisualStyleBackColor = false;
            this.btn_banco1.Click += new System.EventHandler(this.btn_banco1_Click);
            // 
            // btn_banco2
            // 
            this.btn_banco2.BackColor = System.Drawing.SystemColors.Info;
            this.btn_banco2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_banco2.Location = new System.Drawing.Point(296, 98);
            this.btn_banco2.Name = "btn_banco2";
            this.btn_banco2.Size = new System.Drawing.Size(248, 167);
            this.btn_banco2.TabIndex = 1;
            this.btn_banco2.Text = "Banco 2";
            this.btn_banco2.UseVisualStyleBackColor = false;
            this.btn_banco2.Click += new System.EventHandler(this.btn_banco2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual banco deseja entrar?";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_banco2);
            this.Controls.Add(this.btn_banco1);
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_banco1;
        private Button btn_banco2;
        private Label label1;
    }
}