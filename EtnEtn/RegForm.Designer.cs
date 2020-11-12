namespace EtnEtn
{
    partial class RegForm
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
            this.login_t = new System.Windows.Forms.TextBox();
            this.pass_t = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // login_t
            // 
            this.login_t.Location = new System.Drawing.Point(12, 25);
            this.login_t.Name = "login_t";
            this.login_t.Size = new System.Drawing.Size(100, 20);
            this.login_t.TabIndex = 2;
            // 
            // pass_t
            // 
            this.pass_t.Location = new System.Drawing.Point(154, 25);
            this.pass_t.Name = "pass_t";
            this.pass_t.Size = new System.Drawing.Size(100, 20);
            this.pass_t.TabIndex = 3;
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(97, 70);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 4;
            this.btnenter.Text = "Войти";
            this.btnenter.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 111);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.pass_t);
            this.Controls.Add(this.login_t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenter;
        public System.Windows.Forms.TextBox login_t;
        public System.Windows.Forms.TextBox pass_t;
    }
}