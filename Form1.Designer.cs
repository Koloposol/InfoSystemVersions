namespace InfoSystemVersions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_dowload = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_res = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_del);
            this.groupBox1.Controls.Add(this.button_res);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_dowload);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // button_dowload
            // 
            this.button_dowload.Location = new System.Drawing.Point(12, 20);
            this.button_dowload.Name = "button_dowload";
            this.button_dowload.Size = new System.Drawing.Size(75, 23);
            this.button_dowload.TabIndex = 0;
            this.button_dowload.Text = "Загрузить";
            this.button_dowload.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(93, 20);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_res
            // 
            this.button_res.Location = new System.Drawing.Point(174, 20);
            this.button_res.Name = "button_res";
            this.button_res.Size = new System.Drawing.Size(75, 23);
            this.button_res.TabIndex = 2;
            this.button_res.Text = "Обновить";
            this.button_res.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(255, 20);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.column_1,
            this.column_2,
            this.column_3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // column_1
            // 
            this.column_1.HeaderText = "Column1";
            this.column_1.Name = "column_1";
            // 
            // column_2
            // 
            this.column_2.HeaderText = "Column2";
            this.column_2.Name = "column_2";
            // 
            // column_3
            // 
            this.column_3.HeaderText = "Column3";
            this.column_3.Name = "column_3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная система";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_dowload;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_res;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_3;
    }
}

