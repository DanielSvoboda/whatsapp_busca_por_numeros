
namespace whatsapp_busca_por_numeros
{
    partial class whatsapp_busca_por_numeros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botao_Procurar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox_DDD = new System.Windows.Forms.TextBox();
            this.textBox_num_inicio = new System.Windows.Forms.TextBox();
            this.textBox_num_fim = new System.Windows.Forms.TextBox();
            this.groupBox_Numero = new System.Windows.Forms.GroupBox();
            this.label_fim = new System.Windows.Forms.Label();
            this.label_ddd = new System.Windows.Forms.Label();
            this.label_inicio = new System.Windows.Forms.Label();
            this.label_quantidade_loc = new System.Windows.Forms.Label();
            this.botao_Limpar_DataGrid = new System.Windows.Forms.Button();
            this.checkBox_Foto = new System.Windows.Forms.CheckBox();
            this.groupBox_Pesquisar = new System.Windows.Forms.GroupBox();
            this.groupBox_Salvar = new System.Windows.Forms.GroupBox();
            this.button_Exportar = new System.Windows.Forms.Button();
            this.linkLabel_github = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_Numero.SuspendLayout();
            this.groupBox_Pesquisar.SuspendLayout();
            this.groupBox_Salvar.SuspendLayout();
            this.SuspendLayout();
            // 
            // botao_Procurar
            // 
            this.botao_Procurar.Location = new System.Drawing.Point(6, 63);
            this.botao_Procurar.Name = "botao_Procurar";
            this.botao_Procurar.Size = new System.Drawing.Size(60, 23);
            this.botao_Procurar.TabIndex = 0;
            this.botao_Procurar.Text = "Procurar";
            this.botao_Procurar.UseVisualStyleBackColor = true;
            this.botao_Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Nome,
            this.Número});
            this.dataGridView.Location = new System.Drawing.Point(12, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 10;
            this.dataGridView.RowTemplate.Height = 110;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(444, 456);
            this.dataGridView.TabIndex = 1;
            // 
            // textBox_DDD
            // 
            this.textBox_DDD.Location = new System.Drawing.Point(51, 13);
            this.textBox_DDD.Name = "textBox_DDD";
            this.textBox_DDD.Size = new System.Drawing.Size(33, 20);
            this.textBox_DDD.TabIndex = 2;
            this.textBox_DDD.Text = "5541";
            // 
            // textBox_num_inicio
            // 
            this.textBox_num_inicio.Location = new System.Drawing.Point(51, 39);
            this.textBox_num_inicio.Name = "textBox_num_inicio";
            this.textBox_num_inicio.Size = new System.Drawing.Size(63, 20);
            this.textBox_num_inicio.TabIndex = 3;
            // 
            // textBox_num_fim
            // 
            this.textBox_num_fim.Location = new System.Drawing.Point(51, 65);
            this.textBox_num_fim.Name = "textBox_num_fim";
            this.textBox_num_fim.Size = new System.Drawing.Size(63, 20);
            this.textBox_num_fim.TabIndex = 4;
            // 
            // groupBox_Numero
            // 
            this.groupBox_Numero.Controls.Add(this.label_fim);
            this.groupBox_Numero.Controls.Add(this.label_ddd);
            this.groupBox_Numero.Controls.Add(this.textBox_DDD);
            this.groupBox_Numero.Controls.Add(this.label_inicio);
            this.groupBox_Numero.Controls.Add(this.textBox_num_inicio);
            this.groupBox_Numero.Controls.Add(this.textBox_num_fim);
            this.groupBox_Numero.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Numero.Name = "groupBox_Numero";
            this.groupBox_Numero.Size = new System.Drawing.Size(120, 92);
            this.groupBox_Numero.TabIndex = 5;
            this.groupBox_Numero.TabStop = false;
            this.groupBox_Numero.Text = "Número";
            // 
            // label_fim
            // 
            this.label_fim.AutoSize = true;
            this.label_fim.Location = new System.Drawing.Point(6, 68);
            this.label_fim.Name = "label_fim";
            this.label_fim.Size = new System.Drawing.Size(28, 13);
            this.label_fim.TabIndex = 7;
            this.label_fim.Text = "FIM:";
            // 
            // label_ddd
            // 
            this.label_ddd.AutoSize = true;
            this.label_ddd.Location = new System.Drawing.Point(6, 16);
            this.label_ddd.Name = "label_ddd";
            this.label_ddd.Size = new System.Drawing.Size(34, 13);
            this.label_ddd.TabIndex = 5;
            this.label_ddd.Text = "DDD:";
            // 
            // label_inicio
            // 
            this.label_inicio.AutoSize = true;
            this.label_inicio.Location = new System.Drawing.Point(6, 42);
            this.label_inicio.Name = "label_inicio";
            this.label_inicio.Size = new System.Drawing.Size(42, 13);
            this.label_inicio.TabIndex = 6;
            this.label_inicio.Text = "INICIO:";
            // 
            // label_quantidade_loc
            // 
            this.label_quantidade_loc.AutoSize = true;
            this.label_quantidade_loc.Location = new System.Drawing.Point(9, 569);
            this.label_quantidade_loc.Name = "label_quantidade_loc";
            this.label_quantidade_loc.Size = new System.Drawing.Size(111, 13);
            this.label_quantidade_loc.TabIndex = 6;
            this.label_quantidade_loc.Text = "Numeros Localizados:";
            // 
            // botao_Limpar_DataGrid
            // 
            this.botao_Limpar_DataGrid.Location = new System.Drawing.Point(72, 63);
            this.botao_Limpar_DataGrid.Name = "botao_Limpar_DataGrid";
            this.botao_Limpar_DataGrid.Size = new System.Drawing.Size(61, 23);
            this.botao_Limpar_DataGrid.TabIndex = 7;
            this.botao_Limpar_DataGrid.Text = "Limpar";
            this.botao_Limpar_DataGrid.UseVisualStyleBackColor = true;
            this.botao_Limpar_DataGrid.Click += new System.EventHandler(this.botao_limpar_Click);
            // 
            // checkBox_Foto
            // 
            this.checkBox_Foto.AutoSize = true;
            this.checkBox_Foto.Checked = true;
            this.checkBox_Foto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Foto.Location = new System.Drawing.Point(39, 23);
            this.checkBox_Foto.Name = "checkBox_Foto";
            this.checkBox_Foto.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Foto.TabIndex = 7;
            this.checkBox_Foto.Text = "Ver Foto?";
            this.checkBox_Foto.UseVisualStyleBackColor = true;
            // 
            // groupBox_Pesquisar
            // 
            this.groupBox_Pesquisar.Controls.Add(this.checkBox_Foto);
            this.groupBox_Pesquisar.Controls.Add(this.botao_Limpar_DataGrid);
            this.groupBox_Pesquisar.Controls.Add(this.botao_Procurar);
            this.groupBox_Pesquisar.Location = new System.Drawing.Point(138, 12);
            this.groupBox_Pesquisar.Name = "groupBox_Pesquisar";
            this.groupBox_Pesquisar.Size = new System.Drawing.Size(139, 92);
            this.groupBox_Pesquisar.TabIndex = 8;
            this.groupBox_Pesquisar.TabStop = false;
            this.groupBox_Pesquisar.Text = "Pesquisar";
            // 
            // groupBox_Salvar
            // 
            this.groupBox_Salvar.Controls.Add(this.button_Exportar);
            this.groupBox_Salvar.Location = new System.Drawing.Point(283, 12);
            this.groupBox_Salvar.Name = "groupBox_Salvar";
            this.groupBox_Salvar.Size = new System.Drawing.Size(173, 52);
            this.groupBox_Salvar.TabIndex = 9;
            this.groupBox_Salvar.TabStop = false;
            this.groupBox_Salvar.Text = "Salvar";
            // 
            // button_Exportar
            // 
            this.button_Exportar.Location = new System.Drawing.Point(6, 19);
            this.button_Exportar.Name = "button_Exportar";
            this.button_Exportar.Size = new System.Drawing.Size(161, 23);
            this.button_Exportar.TabIndex = 0;
            this.button_Exportar.Text = "Exportar para .csv";
            this.button_Exportar.UseVisualStyleBackColor = true;
            this.button_Exportar.Click += new System.EventHandler(this.button_exportar_Click);
            // 
            // linkLabel_github
            // 
            this.linkLabel_github.AutoSize = true;
            this.linkLabel_github.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel_github.Location = new System.Drawing.Point(286, 569);
            this.linkLabel_github.Name = "linkLabel_github";
            this.linkLabel_github.Size = new System.Drawing.Size(173, 13);
            this.linkLabel_github.TabIndex = 8;
            this.linkLabel_github.TabStop = true;
            this.linkLabel_github.Text = "https://github.com/DanielSvoboda";
            this.linkLabel_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_github_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(289, 75);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(161, 23);
            this.progressBar.TabIndex = 10;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Width = 110;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 230;
            // 
            // Número
            // 
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            this.Número.Width = 110;
            // 
            // whatsapp_busca_por_numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 586);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.linkLabel_github);
            this.Controls.Add(this.groupBox_Salvar);
            this.Controls.Add(this.groupBox_Pesquisar);
            this.Controls.Add(this.label_quantidade_loc);
            this.Controls.Add(this.groupBox_Numero);
            this.Controls.Add(this.dataGridView);
            this.Name = "whatsapp_busca_por_numeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp Busca Por Números Validos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox_Numero.ResumeLayout(false);
            this.groupBox_Numero.PerformLayout();
            this.groupBox_Pesquisar.ResumeLayout(false);
            this.groupBox_Pesquisar.PerformLayout();
            this.groupBox_Salvar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao_Procurar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_DDD;
        private System.Windows.Forms.TextBox textBox_num_inicio;
        private System.Windows.Forms.TextBox textBox_num_fim;
        private System.Windows.Forms.GroupBox groupBox_Numero;
        private System.Windows.Forms.Label label_fim;
        private System.Windows.Forms.Label label_inicio;
        private System.Windows.Forms.Label label_ddd;
        private System.Windows.Forms.Label label_quantidade_loc;
        private System.Windows.Forms.Button botao_Limpar_DataGrid;
        private System.Windows.Forms.CheckBox checkBox_Foto;
        private System.Windows.Forms.GroupBox groupBox_Pesquisar;
        private System.Windows.Forms.GroupBox groupBox_Salvar;
        private System.Windows.Forms.Button button_Exportar;
        private System.Windows.Forms.LinkLabel linkLabel_github;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
    }
}

