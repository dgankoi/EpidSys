namespace Epidsys
{
    partial class DBEnp
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
            System.Windows.Forms.Label idTerretoryLabel;
            System.Windows.Forms.Label nazva_TerretoryLabel;
            System.Windows.Forms.Label kil_naselennyaLabel;
            System.Windows.Forms.Label gustota_naselennyaLabel;
            this.epidsysDataSet = new Epidsys.epidsysDataSet();
            this.terretoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terretoryTableAdapter = new Epidsys.epidsysDataSetTableAdapters.terretoryTableAdapter();
            this.tableAdapterManager = new Epidsys.epidsysDataSetTableAdapters.TableAdapterManager();
            this.terretoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTerretoryTextBox = new System.Windows.Forms.TextBox();
            this.nazva_TerretoryTextBox = new System.Windows.Forms.TextBox();
            this.kil_naselennyaTextBox = new System.Windows.Forms.TextBox();
            this.gustota_naselennyaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnlogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleterl = new System.Windows.Forms.Button();
            this.btnSaverl = new System.Windows.Forms.Button();
            this.btnAddel = new System.Windows.Forms.Button();
            idTerretoryLabel = new System.Windows.Forms.Label();
            nazva_TerretoryLabel = new System.Windows.Forms.Label();
            kil_naselennyaLabel = new System.Windows.Forms.Label();
            gustota_naselennyaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terretoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terretoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTerretoryLabel
            // 
            idTerretoryLabel.AutoSize = true;
            idTerretoryLabel.Location = new System.Drawing.Point(17, 9);
            idTerretoryLabel.Name = "idTerretoryLabel";
            idTerretoryLabel.Size = new System.Drawing.Size(63, 13);
            idTerretoryLabel.TabIndex = 1;
            idTerretoryLabel.Text = "id Terretory:";
            // 
            // nazva_TerretoryLabel
            // 
            nazva_TerretoryLabel.AutoSize = true;
            nazva_TerretoryLabel.Location = new System.Drawing.Point(17, 35);
            nazva_TerretoryLabel.Name = "nazva_TerretoryLabel";
            nazva_TerretoryLabel.Size = new System.Drawing.Size(84, 13);
            nazva_TerretoryLabel.TabIndex = 3;
            nazva_TerretoryLabel.Text = "nazva Terretory:";
            // 
            // kil_naselennyaLabel
            // 
            kil_naselennyaLabel.AutoSize = true;
            kil_naselennyaLabel.Location = new System.Drawing.Point(17, 61);
            kil_naselennyaLabel.Name = "kil_naselennyaLabel";
            kil_naselennyaLabel.Size = new System.Drawing.Size(77, 13);
            kil_naselennyaLabel.TabIndex = 5;
            kil_naselennyaLabel.Text = "kil naselennya:";
            // 
            // gustota_naselennyaLabel
            // 
            gustota_naselennyaLabel.AutoSize = true;
            gustota_naselennyaLabel.Location = new System.Drawing.Point(17, 87);
            gustota_naselennyaLabel.Name = "gustota_naselennyaLabel";
            gustota_naselennyaLabel.Size = new System.Drawing.Size(102, 13);
            gustota_naselennyaLabel.TabIndex = 7;
            gustota_naselennyaLabel.Text = "gustota naselennya:";
            // 
            // epidsysDataSet
            // 
            this.epidsysDataSet.DataSetName = "epidsysDataSet";
            this.epidsysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terretoryBindingSource
            // 
            this.terretoryBindingSource.DataMember = "terretory";
            this.terretoryBindingSource.DataSource = this.epidsysDataSet;
            // 
            // terretoryTableAdapter
            // 
            this.terretoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.hvorobuTableAdapter = null;
            this.tableAdapterManager.pomerlyuTableAdapter = null;
            this.tableAdapterManager.terretoryTableAdapter = this.terretoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = Epidsys.epidsysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.vikTableAdapter = null;
            this.tableAdapterManager.zareetstrvani_vipadkuTableAdapter = null;
            // 
            // terretoryDataGridView
            // 
            this.terretoryDataGridView.AutoGenerateColumns = false;
            this.terretoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terretoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.terretoryDataGridView.DataSource = this.terretoryBindingSource;
            this.terretoryDataGridView.Location = new System.Drawing.Point(12, 110);
            this.terretoryDataGridView.Name = "terretoryDataGridView";
            this.terretoryDataGridView.Size = new System.Drawing.Size(445, 220);
            this.terretoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTerretory";
            this.dataGridViewTextBoxColumn1.HeaderText = "idTerretory";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazva_Terretory";
            this.dataGridViewTextBoxColumn2.HeaderText = "nazva_Terretory";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kil_naselennya";
            this.dataGridViewTextBoxColumn3.HeaderText = "kil_naselennya";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gustota_naselennya";
            this.dataGridViewTextBoxColumn4.HeaderText = "gustota_naselennya";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idTerretoryTextBox
            // 
            this.idTerretoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terretoryBindingSource, "idTerretory", true));
            this.idTerretoryTextBox.Location = new System.Drawing.Point(125, 6);
            this.idTerretoryTextBox.Name = "idTerretoryTextBox";
            this.idTerretoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTerretoryTextBox.TabIndex = 2;
            // 
            // nazva_TerretoryTextBox
            // 
            this.nazva_TerretoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terretoryBindingSource, "nazva_Terretory", true));
            this.nazva_TerretoryTextBox.Location = new System.Drawing.Point(125, 32);
            this.nazva_TerretoryTextBox.Name = "nazva_TerretoryTextBox";
            this.nazva_TerretoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazva_TerretoryTextBox.TabIndex = 4;
            // 
            // kil_naselennyaTextBox
            // 
            this.kil_naselennyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terretoryBindingSource, "kil_naselennya", true));
            this.kil_naselennyaTextBox.Location = new System.Drawing.Point(125, 58);
            this.kil_naselennyaTextBox.Name = "kil_naselennyaTextBox";
            this.kil_naselennyaTextBox.Size = new System.Drawing.Size(100, 20);
            this.kil_naselennyaTextBox.TabIndex = 6;
            // 
            // gustota_naselennyaTextBox
            // 
            this.gustota_naselennyaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.terretoryBindingSource, "gustota_naselennya", true));
            this.gustota_naselennyaTextBox.Location = new System.Drawing.Point(125, 84);
            this.gustota_naselennyaTextBox.Name = "gustota_naselennyaTextBox";
            this.gustota_naselennyaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gustota_naselennyaTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Редагувати:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(411, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "Випадки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Користувачів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Хвороби";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnlogin
            // 
            this.btnUnlogin.Location = new System.Drawing.Point(240, 9);
            this.btnUnlogin.Name = "btnUnlogin";
            this.btnUnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnUnlogin.TabIndex = 48;
            this.btnUnlogin.Text = "Вийти";
            this.btnUnlogin.UseVisualStyleBackColor = true;
            this.btnUnlogin.Click += new System.EventHandler(this.btnUnlogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 38);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleterl
            // 
            this.btnDeleterl.Location = new System.Drawing.Point(474, 294);
            this.btnDeleterl.Name = "btnDeleterl";
            this.btnDeleterl.Size = new System.Drawing.Size(75, 22);
            this.btnDeleterl.TabIndex = 61;
            this.btnDeleterl.Text = "Видлити";
            this.btnDeleterl.UseVisualStyleBackColor = true;
            this.btnDeleterl.Click += new System.EventHandler(this.btnDeleterl_Click);
            // 
            // btnSaverl
            // 
            this.btnSaverl.Location = new System.Drawing.Point(474, 265);
            this.btnSaverl.Name = "btnSaverl";
            this.btnSaverl.Size = new System.Drawing.Size(75, 22);
            this.btnSaverl.TabIndex = 60;
            this.btnSaverl.Text = "Зберегти";
            this.btnSaverl.UseVisualStyleBackColor = true;
            this.btnSaverl.Click += new System.EventHandler(this.btnSaverl_Click);
            // 
            // btnAddel
            // 
            this.btnAddel.Location = new System.Drawing.Point(474, 236);
            this.btnAddel.Name = "btnAddel";
            this.btnAddel.Size = new System.Drawing.Size(75, 22);
            this.btnAddel.TabIndex = 59;
            this.btnAddel.Text = "Додати";
            this.btnAddel.UseVisualStyleBackColor = true;
            this.btnAddel.Click += new System.EventHandler(this.btnAddel_Click);
            // 
            // DBEnp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 328);
            this.Controls.Add(this.btnDeleterl);
            this.Controls.Add(this.btnSaverl);
            this.Controls.Add(this.btnAddel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnlogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(idTerretoryLabel);
            this.Controls.Add(this.idTerretoryTextBox);
            this.Controls.Add(nazva_TerretoryLabel);
            this.Controls.Add(this.nazva_TerretoryTextBox);
            this.Controls.Add(kil_naselennyaLabel);
            this.Controls.Add(this.kil_naselennyaTextBox);
            this.Controls.Add(gustota_naselennyaLabel);
            this.Controls.Add(this.gustota_naselennyaTextBox);
            this.Controls.Add(this.terretoryDataGridView);
            this.Name = "DBEnp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Територія";
            this.Load += new System.EventHandler(this.DBEnp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terretoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terretoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private epidsysDataSet epidsysDataSet;
        private System.Windows.Forms.BindingSource terretoryBindingSource;
        private epidsysDataSetTableAdapters.terretoryTableAdapter terretoryTableAdapter;
        private epidsysDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView terretoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTerretoryTextBox;
        private System.Windows.Forms.TextBox nazva_TerretoryTextBox;
        private System.Windows.Forms.TextBox kil_naselennyaTextBox;
        private System.Windows.Forms.TextBox gustota_naselennyaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnlogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleterl;
        private System.Windows.Forms.Button btnSaverl;
        private System.Windows.Forms.Button btnAddel;
    }
}