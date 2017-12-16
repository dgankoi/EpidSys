namespace Epidsys
{
    partial class DBEzv
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
            System.Windows.Forms.Label idZvupadkaLabel;
            System.Windows.Forms.Label data_vypadkaLabel;
            System.Windows.Forms.Label lokaciya_vupdakaLabel;
            System.Windows.Forms.Label pomerlyuLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label vikLabel;
            System.Windows.Forms.Label idhvorobuLabel;
            this.epidsysDataSet = new Epidsys.epidsysDataSet();
            this.zareetstrvani_vipadkuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zareetstrvani_vipadkuTableAdapter = new Epidsys.epidsysDataSetTableAdapters.zareetstrvani_vipadkuTableAdapter();
            this.tableAdapterManager = new Epidsys.epidsysDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleterl = new System.Windows.Forms.Button();
            this.btnSaverl = new System.Windows.Forms.Button();
            this.btnAddel = new System.Windows.Forms.Button();
            this.hvorobuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hvorobuTableAdapter = new Epidsys.epidsysDataSetTableAdapters.hvorobuTableAdapter();
            this.zareetstrvani_vipadkuDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZvupadkaTextBox = new System.Windows.Forms.TextBox();
            this.data_vypadkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lokaciya_vupdakaTextBox = new System.Windows.Forms.TextBox();
            this.pomerlyuTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.vikTextBox = new System.Windows.Forms.TextBox();
            this.idhvorobuTextBox = new System.Windows.Forms.TextBox();
            this.btnUnlogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            idZvupadkaLabel = new System.Windows.Forms.Label();
            data_vypadkaLabel = new System.Windows.Forms.Label();
            lokaciya_vupdakaLabel = new System.Windows.Forms.Label();
            pomerlyuLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            vikLabel = new System.Windows.Forms.Label();
            idhvorobuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zareetstrvani_vipadkuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zareetstrvani_vipadkuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idZvupadkaLabel
            // 
            idZvupadkaLabel.AutoSize = true;
            idZvupadkaLabel.Location = new System.Drawing.Point(24, 12);
            idZvupadkaLabel.Name = "idZvupadkaLabel";
            idZvupadkaLabel.Size = new System.Drawing.Size(70, 13);
            idZvupadkaLabel.TabIndex = 64;
            idZvupadkaLabel.Text = "id Zvupadka:";
            // 
            // data_vypadkaLabel
            // 
            data_vypadkaLabel.AutoSize = true;
            data_vypadkaLabel.Location = new System.Drawing.Point(24, 39);
            data_vypadkaLabel.Name = "data_vypadkaLabel";
            data_vypadkaLabel.Size = new System.Drawing.Size(75, 13);
            data_vypadkaLabel.TabIndex = 66;
            data_vypadkaLabel.Text = "data vypadka:";
            // 
            // lokaciya_vupdakaLabel
            // 
            lokaciya_vupdakaLabel.AutoSize = true;
            lokaciya_vupdakaLabel.Location = new System.Drawing.Point(24, 64);
            lokaciya_vupdakaLabel.Name = "lokaciya_vupdakaLabel";
            lokaciya_vupdakaLabel.Size = new System.Drawing.Size(94, 13);
            lokaciya_vupdakaLabel.TabIndex = 68;
            lokaciya_vupdakaLabel.Text = "lokaciya vupdaka:";
            // 
            // pomerlyuLabel
            // 
            pomerlyuLabel.AutoSize = true;
            pomerlyuLabel.Location = new System.Drawing.Point(24, 90);
            pomerlyuLabel.Name = "pomerlyuLabel";
            pomerlyuLabel.Size = new System.Drawing.Size(52, 13);
            pomerlyuLabel.TabIndex = 70;
            pomerlyuLabel.Text = "pomerlyu:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(24, 116);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 13);
            genderLabel.TabIndex = 72;
            genderLabel.Text = "gender:";
            // 
            // vikLabel
            // 
            vikLabel.AutoSize = true;
            vikLabel.Location = new System.Drawing.Point(24, 142);
            vikLabel.Name = "vikLabel";
            vikLabel.Size = new System.Drawing.Size(24, 13);
            vikLabel.TabIndex = 74;
            vikLabel.Text = "vik:";
            // 
            // idhvorobuLabel
            // 
            idhvorobuLabel.AutoSize = true;
            idhvorobuLabel.Location = new System.Drawing.Point(24, 168);
            idhvorobuLabel.Name = "idhvorobuLabel";
            idhvorobuLabel.Size = new System.Drawing.Size(57, 13);
            idhvorobuLabel.TabIndex = 76;
            idhvorobuLabel.Text = "idhvorobu:";
            // 
            // epidsysDataSet
            // 
            this.epidsysDataSet.DataSetName = "epidsysDataSet";
            this.epidsysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zareetstrvani_vipadkuBindingSource
            // 
            this.zareetstrvani_vipadkuBindingSource.DataMember = "zareetstrvani_vipadku";
            this.zareetstrvani_vipadkuBindingSource.DataSource = this.epidsysDataSet;
            // 
            // zareetstrvani_vipadkuTableAdapter
            // 
            this.zareetstrvani_vipadkuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.hvorobuTableAdapter = null;
            this.tableAdapterManager.pomerlyuTableAdapter = null;
            this.tableAdapterManager.terretoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Epidsys.epidsysDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.vikTableAdapter = null;
            this.tableAdapterManager.zareetstrvani_vipadkuTableAdapter = this.zareetstrvani_vipadkuTableAdapter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Редагувати:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Хвороби";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Користувачів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Населенні пункти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleterl
            // 
            this.btnDeleterl.Location = new System.Drawing.Point(633, 365);
            this.btnDeleterl.Name = "btnDeleterl";
            this.btnDeleterl.Size = new System.Drawing.Size(75, 23);
            this.btnDeleterl.TabIndex = 64;
            this.btnDeleterl.Text = "Видлити";
            this.btnDeleterl.UseVisualStyleBackColor = true;
            this.btnDeleterl.Click += new System.EventHandler(this.btnDeleterl_Click);
            // 
            // btnSaverl
            // 
            this.btnSaverl.Location = new System.Drawing.Point(633, 336);
            this.btnSaverl.Name = "btnSaverl";
            this.btnSaverl.Size = new System.Drawing.Size(75, 23);
            this.btnSaverl.TabIndex = 63;
            this.btnSaverl.Text = "Зберегти";
            this.btnSaverl.UseVisualStyleBackColor = true;
            this.btnSaverl.Click += new System.EventHandler(this.btnSaverl_Click);
            // 
            // btnAddel
            // 
            this.btnAddel.Location = new System.Drawing.Point(633, 307);
            this.btnAddel.Name = "btnAddel";
            this.btnAddel.Size = new System.Drawing.Size(75, 23);
            this.btnAddel.TabIndex = 62;
            this.btnAddel.Text = "Додати";
            this.btnAddel.UseVisualStyleBackColor = true;
            this.btnAddel.Click += new System.EventHandler(this.btnAddel_Click);
            // 
            // hvorobuBindingSource
            // 
            this.hvorobuBindingSource.DataMember = "hvorobu";
            this.hvorobuBindingSource.DataSource = this.epidsysDataSet;
            // 
            // hvorobuTableAdapter
            // 
            this.hvorobuTableAdapter.ClearBeforeFill = true;
            // 
            // zareetstrvani_vipadkuDataGridView
            // 
            this.zareetstrvani_vipadkuDataGridView.AutoGenerateColumns = false;
            this.zareetstrvani_vipadkuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zareetstrvani_vipadkuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.zareetstrvani_vipadkuDataGridView.DataSource = this.zareetstrvani_vipadkuBindingSource;
            this.zareetstrvani_vipadkuDataGridView.Location = new System.Drawing.Point(12, 193);
            this.zareetstrvani_vipadkuDataGridView.Name = "zareetstrvani_vipadkuDataGridView";
            this.zareetstrvani_vipadkuDataGridView.Size = new System.Drawing.Size(615, 220);
            this.zareetstrvani_vipadkuDataGridView.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idZvupadka";
            this.dataGridViewTextBoxColumn1.HeaderText = "idZvupadka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_vypadka";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_vypadka";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lokaciya_vupdaka";
            this.dataGridViewTextBoxColumn3.HeaderText = "lokaciya_vupdaka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pomerlyu";
            this.dataGridViewTextBoxColumn4.HeaderText = "pomerlyu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "vik";
            this.dataGridViewTextBoxColumn8.HeaderText = "vik";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "idhvorobu";
            this.dataGridViewTextBoxColumn9.HeaderText = "idhvorobu";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // idZvupadkaTextBox
            // 
            this.idZvupadkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "idZvupadka", true));
            this.idZvupadkaTextBox.Location = new System.Drawing.Point(124, 9);
            this.idZvupadkaTextBox.Name = "idZvupadkaTextBox";
            this.idZvupadkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.idZvupadkaTextBox.TabIndex = 65;
            // 
            // data_vypadkaDateTimePicker
            // 
            this.data_vypadkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zareetstrvani_vipadkuBindingSource, "data_vypadka", true));
            this.data_vypadkaDateTimePicker.Location = new System.Drawing.Point(124, 35);
            this.data_vypadkaDateTimePicker.Name = "data_vypadkaDateTimePicker";
            this.data_vypadkaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_vypadkaDateTimePicker.TabIndex = 67;
            // 
            // lokaciya_vupdakaTextBox
            // 
            this.lokaciya_vupdakaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "lokaciya_vupdaka", true));
            this.lokaciya_vupdakaTextBox.Location = new System.Drawing.Point(124, 61);
            this.lokaciya_vupdakaTextBox.Name = "lokaciya_vupdakaTextBox";
            this.lokaciya_vupdakaTextBox.Size = new System.Drawing.Size(200, 20);
            this.lokaciya_vupdakaTextBox.TabIndex = 69;
            // 
            // pomerlyuTextBox
            // 
            this.pomerlyuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "pomerlyu", true));
            this.pomerlyuTextBox.Location = new System.Drawing.Point(124, 87);
            this.pomerlyuTextBox.Name = "pomerlyuTextBox";
            this.pomerlyuTextBox.Size = new System.Drawing.Size(200, 20);
            this.pomerlyuTextBox.TabIndex = 71;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(124, 113);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 73;
            // 
            // vikTextBox
            // 
            this.vikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "vik", true));
            this.vikTextBox.Location = new System.Drawing.Point(124, 139);
            this.vikTextBox.Name = "vikTextBox";
            this.vikTextBox.Size = new System.Drawing.Size(200, 20);
            this.vikTextBox.TabIndex = 75;
            // 
            // idhvorobuTextBox
            // 
            this.idhvorobuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zareetstrvani_vipadkuBindingSource, "idhvorobu", true));
            this.idhvorobuTextBox.Location = new System.Drawing.Point(124, 165);
            this.idhvorobuTextBox.Name = "idhvorobuTextBox";
            this.idhvorobuTextBox.Size = new System.Drawing.Size(200, 20);
            this.idhvorobuTextBox.TabIndex = 77;
            // 
            // btnUnlogin
            // 
            this.btnUnlogin.Location = new System.Drawing.Point(387, 11);
            this.btnUnlogin.Name = "btnUnlogin";
            this.btnUnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnUnlogin.TabIndex = 79;
            this.btnUnlogin.Text = "Вийти";
            this.btnUnlogin.UseVisualStyleBackColor = true;
            this.btnUnlogin.Click += new System.EventHandler(this.btnUnlogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(387, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Меню";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DBEzv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 433);
            this.Controls.Add(this.btnUnlogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(idZvupadkaLabel);
            this.Controls.Add(this.idZvupadkaTextBox);
            this.Controls.Add(data_vypadkaLabel);
            this.Controls.Add(this.data_vypadkaDateTimePicker);
            this.Controls.Add(lokaciya_vupdakaLabel);
            this.Controls.Add(this.lokaciya_vupdakaTextBox);
            this.Controls.Add(pomerlyuLabel);
            this.Controls.Add(this.pomerlyuTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(vikLabel);
            this.Controls.Add(this.vikTextBox);
            this.Controls.Add(idhvorobuLabel);
            this.Controls.Add(this.idhvorobuTextBox);
            this.Controls.Add(this.zareetstrvani_vipadkuDataGridView);
            this.Controls.Add(this.btnDeleterl);
            this.Controls.Add(this.btnSaverl);
            this.Controls.Add(this.btnAddel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DBEzv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зареєстровані випадки";
            this.Load += new System.EventHandler(this.DBEzv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zareetstrvani_vipadkuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zareetstrvani_vipadkuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private epidsysDataSet epidsysDataSet;
        private System.Windows.Forms.BindingSource zareetstrvani_vipadkuBindingSource;
        private epidsysDataSetTableAdapters.zareetstrvani_vipadkuTableAdapter zareetstrvani_vipadkuTableAdapter;
        private epidsysDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleterl;
        private System.Windows.Forms.Button btnSaverl;
        private System.Windows.Forms.Button btnAddel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource hvorobuBindingSource;
        private epidsysDataSetTableAdapters.hvorobuTableAdapter hvorobuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox idhvorobuTextBox;
        private System.Windows.Forms.TextBox vikTextBox;
        private System.Windows.Forms.TextBox pomerlyuTextBox;
        private System.Windows.Forms.TextBox lokaciya_vupdakaTextBox;
        private System.Windows.Forms.DateTimePicker data_vypadkaDateTimePicker;
        private System.Windows.Forms.TextBox idZvupadkaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView zareetstrvani_vipadkuDataGridView;
        private System.Windows.Forms.Button btnUnlogin;
        private System.Windows.Forms.Button btnBack;
    }
}