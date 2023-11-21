namespace m8_ficha3_davidpereira
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_sair = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_ano = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_matricula = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_modelos = new System.Windows.Forms.ComboBox();
            this.comboBox_marca = new System.Windows.Forms.ComboBox();
            this.estatistica_tab2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_contar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_ano = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_cont_marca = new System.Windows.Forms.Label();
            this.comboBox_marcas2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_carros = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.estatistica_tab2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "car.png");
            this.imageList1.Images.SetKeyName(2, "edit-document.png");
            this.imageList1.Images.SetKeyName(3, "eraser.png");
            this.imageList1.Images.SetKeyName(4, "x-button.png");
            this.imageList1.Images.SetKeyName(5, "sair (1).png");
            // 
            // button_sair
            // 
            this.button_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_sair.ImageIndex = 5;
            this.button_sair.ImageList = this.imageList1;
            this.button_sair.Location = new System.Drawing.Point(467, 360);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(79, 56);
            this.button_sair.TabIndex = 3;
            this.button_sair.Text = "Sair";
            this.button_sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.estatistica_tab2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(42, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 342);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_eliminar);
            this.tabPage1.Controls.Add(this.button_adicionar);
            this.tabPage1.Controls.Add(this.button_alterar);
            this.tabPage1.Controls.Add(this.button_Limpar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "veiculos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.ImageIndex = 4;
            this.button_eliminar.ImageList = this.imageList1;
            this.button_eliminar.Location = new System.Drawing.Point(277, 122);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 53);
            this.button_eliminar.TabIndex = 5;
            this.button_eliminar.Text = "eliminar";
            this.button_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_adicionar
            // 
            this.button_adicionar.ImageIndex = 0;
            this.button_adicionar.ImageList = this.imageList1;
            this.button_adicionar.Location = new System.Drawing.Point(20, 122);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 53);
            this.button_adicionar.TabIndex = 4;
            this.button_adicionar.Text = "adicionar";
            this.button_adicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_alterar
            // 
            this.button_alterar.ImageIndex = 2;
            this.button_alterar.ImageList = this.imageList1;
            this.button_alterar.Location = new System.Drawing.Point(148, 122);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(75, 53);
            this.button_alterar.TabIndex = 3;
            this.button_alterar.Text = "alterar";
            this.button_alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_alterar.UseVisualStyleBackColor = true;
            this.button_alterar.Click += new System.EventHandler(this.button_alterar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.ImageIndex = 3;
            this.button_Limpar.ImageList = this.imageList1;
            this.button_Limpar.Location = new System.Drawing.Point(401, 122);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(75, 53);
            this.button_Limpar.TabIndex = 2;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marca,
            this.modelo,
            this.matricula,
            this.ano});
            this.dataGridView1.Location = new System.Drawing.Point(20, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(456, 117);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // marca
            // 
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // ano
            // 
            this.ano.HeaderText = "ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox_ano);
            this.groupBox1.Controls.Add(this.maskedTextBox_matricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_modelos);
            this.groupBox1.Controls.Add(this.comboBox_marca);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do carro";
            // 
            // maskedTextBox_ano
            // 
            this.maskedTextBox_ano.Location = new System.Drawing.Point(297, 56);
            this.maskedTextBox_ano.Mask = "0000";
            this.maskedTextBox_ano.Name = "maskedTextBox_ano";
            this.maskedTextBox_ano.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox_ano.TabIndex = 7;
            // 
            // maskedTextBox_matricula
            // 
            this.maskedTextBox_matricula.Location = new System.Drawing.Point(73, 59);
            this.maskedTextBox_matricula.Mask = "00->LL-00";
            this.maskedTextBox_matricula.Name = "maskedTextBox_matricula";
            this.maskedTextBox_matricula.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_matricula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "modelos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "marca";
            // 
            // comboBox_modelos
            // 
            this.comboBox_modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_modelos.FormattingEnabled = true;
            this.comboBox_modelos.Location = new System.Drawing.Point(297, 19);
            this.comboBox_modelos.Name = "comboBox_modelos";
            this.comboBox_modelos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_modelos.TabIndex = 1;
            // 
            // comboBox_marca
            // 
            this.comboBox_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_marca.FormattingEnabled = true;
            this.comboBox_marca.Items.AddRange(new object[] {
            "toyota",
            "seat",
            "Volkswagen"});
            this.comboBox_marca.Location = new System.Drawing.Point(57, 19);
            this.comboBox_marca.Name = "comboBox_marca";
            this.comboBox_marca.Size = new System.Drawing.Size(121, 21);
            this.comboBox_marca.TabIndex = 0;
            this.comboBox_marca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // estatistica_tab2
            // 
            this.estatistica_tab2.Controls.Add(this.listBox1);
            this.estatistica_tab2.Controls.Add(this.label11);
            this.estatistica_tab2.Controls.Add(this.groupBox4);
            this.estatistica_tab2.Controls.Add(this.groupBox3);
            this.estatistica_tab2.Controls.Add(this.groupBox2);
            this.estatistica_tab2.Location = new System.Drawing.Point(4, 37);
            this.estatistica_tab2.Name = "estatistica_tab2";
            this.estatistica_tab2.Size = new System.Drawing.Size(496, 301);
            this.estatistica_tab2.TabIndex = 1;
            this.estatistica_tab2.Text = "estatistica";
            this.estatistica_tab2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 251);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Matriculas de veiculos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_contar);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label_ano);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(140, 196);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 92);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "contar por ano anterior a";
            // 
            // button_contar
            // 
            this.button_contar.Location = new System.Drawing.Point(177, 22);
            this.button_contar.Name = "button_contar";
            this.button_contar.Size = new System.Drawing.Size(136, 23);
            this.button_contar.TabIndex = 4;
            this.button_contar.Text = "contar veiculos";
            this.button_contar.UseVisualStyleBackColor = true;
            this.button_contar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label_ano
            // 
            this.label_ano.BackColor = System.Drawing.Color.Turquoise;
            this.label_ano.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ano.Location = new System.Drawing.Point(19, 52);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(310, 28);
            this.label_ano.TabIndex = 2;
            this.label_ano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "digite um ano:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_cont_marca);
            this.groupBox3.Controls.Add(this.comboBox_marcas2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(140, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "contar por marca";
            // 
            // label_cont_marca
            // 
            this.label_cont_marca.BackColor = System.Drawing.Color.Turquoise;
            this.label_cont_marca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_cont_marca.Location = new System.Drawing.Point(19, 52);
            this.label_cont_marca.Name = "label_cont_marca";
            this.label_cont_marca.Size = new System.Drawing.Size(310, 28);
            this.label_cont_marca.TabIndex = 2;
            this.label_cont_marca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_marcas2
            // 
            this.comboBox_marcas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_marcas2.FormattingEnabled = true;
            this.comboBox_marcas2.Items.AddRange(new object[] {
            "toyota",
            "Volkswagen",
            "seat"});
            this.comboBox_marcas2.Location = new System.Drawing.Point(160, 16);
            this.comboBox_marcas2.Name = "comboBox_marcas2";
            this.comboBox_marcas2.Size = new System.Drawing.Size(153, 21);
            this.comboBox_marcas2.TabIndex = 1;
            this.comboBox_marcas2.SelectedIndexChanged += new System.EventHandler(this.comboBox_marcas2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "escolha uma marca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total_carros);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(140, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "contagem total de carros";
            // 
            // total_carros
            // 
            this.total_carros.BackColor = System.Drawing.Color.Turquoise;
            this.total_carros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_carros.Location = new System.Drawing.Point(177, 16);
            this.total_carros.Name = "total_carros";
            this.total_carros.Size = new System.Drawing.Size(166, 28);
            this.total_carros.TabIndex = 1;
            this.total_carros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "total de carros no stand:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 418);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.estatistica_tab2.ResumeLayout(false);
            this.estatistica_tab2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ano;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_modelos;
        private System.Windows.Forms.ComboBox comboBox_marca;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.TabPage estatistica_tab2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total_carros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_marcas2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_contar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_cont_marca;
        private System.Windows.Forms.ListBox listBox1;
    }
}

