namespace Epidsys
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.hvorobuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epidsysDataSet = new Epidsys.epidsysDataSet();
            this.hvorobuTableAdapter = new Epidsys.epidsysDataSetTableAdapters.hvorobuTableAdapter();
            this.btnVhid = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlEntrance = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).BeginInit();
            this.pnlEntrance.SuspendLayout();
            this.SuspendLayout();
            // 
            // hvorobuBindingSource
            // 
            this.hvorobuBindingSource.DataMember = "hvorobu";
            this.hvorobuBindingSource.DataSource = this.epidsysDataSet;
            // 
            // epidsysDataSet
            // 
            this.epidsysDataSet.DataSetName = "epidsysDataSet";
            this.epidsysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hvorobuTableAdapter
            // 
            this.hvorobuTableAdapter.ClearBeforeFill = true;
            // 
            // btnVhid
            // 
            this.btnVhid.Location = new System.Drawing.Point(35, 122);
            this.btnVhid.Name = "btnVhid";
            this.btnVhid.Size = new System.Drawing.Size(100, 26);
            this.btnVhid.TabIndex = 0;
            this.btnVhid.Text = "Вхід";
            this.btnVhid.UseVisualStyleBackColor = true;
            this.btnVhid.Click += new System.EventHandler(this.btnVhid_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(67, 27);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Location = new System.Drawing.Point(67, 57);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pnlEntrance
            // 
            this.pnlEntrance.Controls.Add(this.label2);
            this.pnlEntrance.Controls.Add(this.label1);
            this.pnlEntrance.Controls.Add(this.txtPass);
            this.pnlEntrance.Controls.Add(this.txtLogin);
            this.pnlEntrance.Controls.Add(this.btnVhid);
            this.pnlEntrance.Location = new System.Drawing.Point(12, 12);
            this.pnlEntrance.Name = "pnlEntrance";
            this.pnlEntrance.Size = new System.Drawing.Size(170, 151);
            this.pnlEntrance.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логін:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 178);
            this.Controls.Add(this.pnlEntrance);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hvorobuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epidsysDataSet)).EndInit();
            this.pnlEntrance.ResumeLayout(false);
            this.pnlEntrance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private epidsysDataSet epidsysDataSet;
        private System.Windows.Forms.BindingSource hvorobuBindingSource;
        private epidsysDataSetTableAdapters.hvorobuTableAdapter hvorobuTableAdapter;
        private System.Windows.Forms.Button btnVhid;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
          private System.Windows.Forms.Panel pnlEntrance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

