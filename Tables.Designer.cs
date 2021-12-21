namespace PractikaDB
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAnkete = new System.Windows.Forms.Button();
            this.btnPhisical = new System.Windows.Forms.Button();
            this.btnPsyco = new System.Windows.Forms.Button();
            this.btnCouple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 592);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 672);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить строки";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(232, 672);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 43);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(459, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Обновить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(659, 672);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAnkete
            // 
            this.btnAnkete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnkete.Location = new System.Drawing.Point(12, 12);
            this.btnAnkete.Name = "btnAnkete";
            this.btnAnkete.Size = new System.Drawing.Size(129, 43);
            this.btnAnkete.TabIndex = 1;
            this.btnAnkete.Text = "Анкеты";
            this.btnAnkete.UseVisualStyleBackColor = true;
            this.btnAnkete.Click += new System.EventHandler(this.btnAnkete_Click);
            // 
            // btnPhisical
            // 
            this.btnPhisical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPhisical.Location = new System.Drawing.Point(232, 12);
            this.btnPhisical.Name = "btnPhisical";
            this.btnPhisical.Size = new System.Drawing.Size(129, 43);
            this.btnPhisical.TabIndex = 1;
            this.btnPhisical.Text = "Физические качества";
            this.btnPhisical.UseVisualStyleBackColor = true;
            this.btnPhisical.Click += new System.EventHandler(this.btnPhisical_Click);
            // 
            // btnPsyco
            // 
            this.btnPsyco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPsyco.Location = new System.Drawing.Point(459, 12);
            this.btnPsyco.Name = "btnPsyco";
            this.btnPsyco.Size = new System.Drawing.Size(139, 43);
            this.btnPsyco.TabIndex = 1;
            this.btnPsyco.Text = "Психологический тест";
            this.btnPsyco.UseVisualStyleBackColor = true;
            this.btnPsyco.Click += new System.EventHandler(this.btnPsyco_Click);
            // 
            // btnCouple
            // 
            this.btnCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCouple.Location = new System.Drawing.Point(659, 12);
            this.btnCouple.Name = "btnCouple";
            this.btnCouple.Size = new System.Drawing.Size(129, 43);
            this.btnCouple.TabIndex = 1;
            this.btnCouple.Text = "Готовые пары";
            this.btnCouple.UseVisualStyleBackColor = true;
            this.btnCouple.Click += new System.EventHandler(this.btnCouple_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCouple);
            this.Controls.Add(this.btnPsyco);
            this.Controls.Add(this.btnPhisical);
            this.Controls.Add(this.btnAnkete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tables";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAnkete;
        private System.Windows.Forms.Button btnPhisical;
        private System.Windows.Forms.Button btnPsyco;
        private System.Windows.Forms.Button btnCouple;
    }
}