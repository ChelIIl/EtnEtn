namespace EtnEtn
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
            this.ConTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.mark_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ConTable
            // 
            this.ConTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ConTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConTable.Location = new System.Drawing.Point(0, 0);
            this.ConTable.Name = "ConTable";
            this.ConTable.Size = new System.Drawing.Size(601, 150);
            this.ConTable.TabIndex = 0;
            this.ConTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConTable_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(93, 164);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Поиск";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // mark_t
            // 
            this.mark_t.Location = new System.Drawing.Point(265, 166);
            this.mark_t.Name = "mark_t";
            this.mark_t.Size = new System.Drawing.Size(100, 20);
            this.mark_t.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка машины";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(514, 164);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "Обновить";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 199);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mark_t);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ConTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox mark_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrefresh;
    }
}

