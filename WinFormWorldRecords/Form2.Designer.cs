namespace WinFormWorldRecords
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Athletes_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Athletes_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Athletes_Code,
            this.Athletes_full_name,
            this.Date_of_birth,
            this.Place_of_birth});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Athletes_Code
            // 
            this.Athletes_Code.DataPropertyName = "Text";
            this.Athletes_Code.HeaderText = "Код спортсмена";
            this.Athletes_Code.MaxInputLength = 150;
            this.Athletes_Code.Name = "Athletes_Code";
            this.Athletes_Code.ReadOnly = true;
            this.Athletes_Code.Width = 115;
            // 
            // Athletes_full_name
            // 
            this.Athletes_full_name.DataPropertyName = "Text";
            this.Athletes_full_name.HeaderText = "ФИО спортсмена";
            this.Athletes_full_name.MaxInputLength = 150;
            this.Athletes_full_name.Name = "Athletes_full_name";
            this.Athletes_full_name.ReadOnly = true;
            this.Athletes_full_name.Width = 115;
            // 
            // Date_of_birth
            // 
            this.Date_of_birth.DataPropertyName = "Text";
            this.Date_of_birth.HeaderText = "Дата рождения";
            this.Date_of_birth.MaxInputLength = 150;
            this.Date_of_birth.Name = "Date_of_birth";
            this.Date_of_birth.ReadOnly = true;
            this.Date_of_birth.Width = 115;
            // 
            // Place_of_birth
            // 
            this.Place_of_birth.DataPropertyName = "Text";
            this.Place_of_birth.HeaderText = "Место рождения";
            this.Place_of_birth.MaxInputLength = 150;
            this.Place_of_birth.Name = "Place_of_birth";
            this.Place_of_birth.ReadOnly = true;
            this.Place_of_birth.Width = 115;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 216);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Athletes_Code;
        private DataGridViewTextBoxColumn Athletes_full_name;
        private DataGridViewTextBoxColumn Date_of_birth;
        private DataGridViewTextBoxColumn Place_of_birth;
        private Button button4;
    }
}