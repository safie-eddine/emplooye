namespace combo_pro
{
    partial class frmComboPro
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
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.AddCountry = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(89, 119);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(152, 21);
            this.cmbNames.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 3;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(89, 214);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(152, 21);
            this.cmbCountry.TabIndex = 4;
            this.cmbCountry.SelectedValueChanged += new System.EventHandler(this.CmbCountry_SelectedValueChanged);
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(260, 165);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(75, 23);
            this.AddCountry.TabIndex = 5;
            this.AddCountry.Text = "Add";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(89, 162);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(152, 20);
            this.txtCountry.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(89, 188);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(152, 20);
            this.txtKey.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(89, 3);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(152, 21);
            this.cmbDepartment.TabIndex = 10;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.CmbDepartment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Departments";
            // 
            // txtSelected
            // 
            this.txtSelected.Location = new System.Drawing.Point(89, 30);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(152, 20);
            this.txtSelected.TabIndex = 12;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(80, 266);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(95, 23);
            this.btnGo.TabIndex = 13;
            this.btnGo.Text = "Go to Employee";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.first_name,
            this.country_name});
            this.dataGridView1.Location = new System.Drawing.Point(368, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 216);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(80, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // department
            // 
            this.department.HeaderText = "department";
            this.department.Name = "department";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "first name";
            this.first_name.Name = "first_name";
            // 
            // country_name
            // 
            this.country_name.HeaderText = "country name";
            this.country_name.Name = "country_name";
            // 
            // frmComboPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.AddCountry);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbNames);
            this.Name = "frmComboPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComboPro";
            this.Load += new System.EventHandler(this.FrmComboPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_name;
    }
}

