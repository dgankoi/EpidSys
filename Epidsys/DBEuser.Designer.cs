namespace Epidsys
{
    partial class DBEuser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iduserLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.epidsysDataSet = new Epidsys.epidsysDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Epidsys.epidsysDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new Epidsys.epidsysDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnlogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleterl = new System.Windows.Forms.Button();
            this.btnSaverl = new System.Windows.Forms.Button();
            this.btnAddel = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            iduserLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iduserLabel
            // 
            iduserLabel.AutoSize = true;
            iduserLabel.Location = new System.Drawing.Point(6, 6);
            iduserLabel.Name = "iduserLabel";
            iduserLabel.Size = new System.Drawing.Size(38, 13);
            iduserLabel.TabIndex = 58;
            iduserLabel.Text = "iduser:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(6, 32);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 60;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(6, 58);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 62;
            passwordLabel.Text = "password:";
            // 
            // epidsysDataSet
            // 
            this.epidsysDataSet.DataSetName = "epidsysDataSet";
            this.epidsysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.epidsysDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.hvorobuTableAdapter = null;
            this.tableAdapterManager.pomerlyuTableAdapter = null;
            this.tableAdapterManager.terretoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Epidsys.epidsysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.vikTableAdapter = null;
            this.tableAdapterManager.zareetstrvani_vipadkuTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Редагувати:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 54;
            this.button4.Text = "Випадки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Хвороби";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Населенні пункти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnlogin
            // 
            this.btnUnlogin.Location = new System.Drawing.Point(170, 3);
            this.btnUnlogin.Name = "btnUnlogin";
            this.btnUnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnUnlogin.TabIndex = 48;
            this.btnUnlogin.Text = "Вийти";
            this.btnUnlogin.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(170, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleterl
            // 
            this.btnDeleterl.Location = new System.Drawing.Point(397, 277);
            this.btnDeleterl.Name = "btnDeleterl";
            this.btnDeleterl.Size = new System.Drawing.Size(75, 23);
            this.btnDeleterl.TabIndex = 58;
            this.btnDeleterl.Text = "Видлити";
            this.btnDeleterl.UseVisualStyleBackColor = true;
            this.btnDeleterl.Click += new System.EventHandler(this.btnDeleterl_Click);
            // 
            // btnSaverl
            // 
            this.btnSaverl.Location = new System.Drawing.Point(397, 248);
            this.btnSaverl.Name = "btnSaverl";
            this.btnSaverl.Size = new System.Drawing.Size(75, 23);
            this.btnSaverl.TabIndex = 57;
            this.btnSaverl.Text = "Зберегти";
            this.btnSaverl.UseVisualStyleBackColor = true;
            this.btnSaverl.Click += new System.EventHandler(this.btnSaverl_Click);
            // 
            // btnAddel
            // 
            this.btnAddel.Location = new System.Drawing.Point(397, 219);
            this.btnAddel.Name = "btnAddel";
            this.btnAddel.Size = new System.Drawing.Size(75, 23);
            this.btnAddel.TabIndex = 56;
            this.btnAddel.Text = "Додати";
            this.btnAddel.UseVisualStyleBackColor = true;
            this.btnAddel.Click += new System.EventHandler(this.btnAddel_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(9, 90);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(327, 220);
            this.userDataGridView.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iduser";
            this.dataGridViewTextBoxColumn1.HeaderText = "iduser";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn2.HeaderText = "login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // iduserTextBox
            // 
            this.iduserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "iduser", true));
            this.iduserTextBox.Location = new System.Drawing.Point(67, 3);
            this.iduserTextBox.Name = "iduserTextBox";
            this.iduserTextBox.Size = new System.Drawing.Size(100, 20);
            this.iduserTextBox.TabIndex = 59;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(67, 29);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 61;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(67, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 63;
            // 
            // DBEuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 312);
            this.Controls.Add(iduserLabel);
            this.Controls.Add(this.iduserTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.btnDeleterl);
            this.Controls.Add(this.btnSaverl);
            this.Controls.Add(this.btnAddel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnlogin);
            this.Controls.Add(this.btnBack);
            this.Name = "DBEuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Користувач";
            this.Load += new System.EventHandler(this.DBEuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private epidsysDataSet epidsysDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private epidsysDataSetTableAdapters.userTableAdapter userTableAdapter;
        private epidsysDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnlogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleterl;
        private System.Windows.Forms.Button btnSaverl;
        private System.Windows.Forms.Button btnAddel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox iduserTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView userDataGridView;
    }
}