namespace Projeto.Forms
{
    partial class Produtos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gbrEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.txtPrecoEditar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.txtProdutoEditar = new System.Windows.Forms.TextBox();
            this.lblProdutoEditar = new System.Windows.Forms.Label();
            this.gbrCadastrar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.txtPrecoCad = new System.Windows.Forms.TextBox();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtProdutoCad = new System.Windows.Forms.TextBox();
            this.lblProdutoCad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbrEditar.SuspendLayout();
            this.gbrCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(-1, 1);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(594, 215);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // gbrEditar
            // 
            this.gbrEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbrEditar.Controls.Add(this.cmbCategoriaEditar);
            this.gbrEditar.Controls.Add(this.lblCategoriaEditar);
            this.gbrEditar.Controls.Add(this.txtPrecoEditar);
            this.gbrEditar.Controls.Add(this.btnAtualizar);
            this.gbrEditar.Controls.Add(this.lblPrecoEditar);
            this.gbrEditar.Controls.Add(this.txtProdutoEditar);
            this.gbrEditar.Controls.Add(this.lblProdutoEditar);
            this.gbrEditar.Enabled = false;
            this.gbrEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrEditar.Location = new System.Drawing.Point(318, 213);
            this.gbrEditar.Name = "gbrEditar";
            this.gbrEditar.Size = new System.Drawing.Size(275, 191);
            this.gbrEditar.TabIndex = 4;
            this.gbrEditar.TabStop = false;
            this.gbrEditar.Text = "Editar Produto:";
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(134, 105);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(128, 29);
            this.cmbCategoriaEditar.TabIndex = 8;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEditar.Location = new System.Drawing.Point(29, 113);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(65, 16);
            this.lblCategoriaEditar.TabIndex = 7;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // txtPrecoEditar
            // 
            this.txtPrecoEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoEditar.Location = new System.Drawing.Point(134, 78);
            this.txtPrecoEditar.Name = "txtPrecoEditar";
            this.txtPrecoEditar.Size = new System.Drawing.Size(128, 21);
            this.txtPrecoEditar.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(32, 150);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 31);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEditar.Location = new System.Drawing.Point(29, 78);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(41, 16);
            this.lblPrecoEditar.TabIndex = 5;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // txtProdutoEditar
            // 
            this.txtProdutoEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoEditar.Location = new System.Drawing.Point(134, 46);
            this.txtProdutoEditar.Name = "txtProdutoEditar";
            this.txtProdutoEditar.Size = new System.Drawing.Size(128, 21);
            this.txtProdutoEditar.TabIndex = 1;
            this.txtProdutoEditar.TextChanged += new System.EventHandler(this.txtProdutoEditar_TextChanged);
            // 
            // lblProdutoEditar
            // 
            this.lblProdutoEditar.AutoSize = true;
            this.lblProdutoEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoEditar.Location = new System.Drawing.Point(29, 49);
            this.lblProdutoEditar.Name = "lblProdutoEditar";
            this.lblProdutoEditar.Size = new System.Drawing.Size(53, 16);
            this.lblProdutoEditar.TabIndex = 0;
            this.lblProdutoEditar.Text = "Produto:";
            // 
            // gbrCadastrar
            // 
            this.gbrCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbrCadastrar.Controls.Add(this.cmbCategoriaCad);
            this.gbrCadastrar.Controls.Add(this.lblCategoriaCad);
            this.gbrCadastrar.Controls.Add(this.txtPrecoCad);
            this.gbrCadastrar.Controls.Add(this.lblPrecoCad);
            this.gbrCadastrar.Controls.Add(this.btnCadastrar);
            this.gbrCadastrar.Controls.Add(this.txtProdutoCad);
            this.gbrCadastrar.Controls.Add(this.lblProdutoCad);
            this.gbrCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrCadastrar.Location = new System.Drawing.Point(-1, 213);
            this.gbrCadastrar.Name = "gbrCadastrar";
            this.gbrCadastrar.Size = new System.Drawing.Size(319, 191);
            this.gbrCadastrar.TabIndex = 7;
            this.gbrCadastrar.TabStop = false;
            this.gbrCadastrar.Text = "Cadastrar Novo Produto";
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(140, 109);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(128, 29);
            this.cmbCategoriaCad.TabIndex = 6;
            this.cmbCategoriaCad.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaCad_SelectedIndexChanged);
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.Location = new System.Drawing.Point(38, 115);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(65, 16);
            this.lblCategoriaCad.TabIndex = 5;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // txtPrecoCad
            // 
            this.txtPrecoCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCad.Location = new System.Drawing.Point(140, 78);
            this.txtPrecoCad.Name = "txtPrecoCad";
            this.txtPrecoCad.Size = new System.Drawing.Size(128, 21);
            this.txtPrecoCad.TabIndex = 4;
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(35, 78);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(41, 16);
            this.lblPrecoCad.TabIndex = 3;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(38, 150);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 31);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtProdutoCad
            // 
            this.txtProdutoCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoCad.Location = new System.Drawing.Point(140, 46);
            this.txtProdutoCad.Name = "txtProdutoCad";
            this.txtProdutoCad.Size = new System.Drawing.Size(128, 21);
            this.txtProdutoCad.TabIndex = 1;
            // 
            // lblProdutoCad
            // 
            this.lblProdutoCad.AutoSize = true;
            this.lblProdutoCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoCad.Location = new System.Drawing.Point(35, 49);
            this.lblProdutoCad.Name = "lblProdutoCad";
            this.lblProdutoCad.Size = new System.Drawing.Size(53, 16);
            this.lblProdutoCad.TabIndex = 0;
            this.lblProdutoCad.Text = "Produto:";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.gbrCadastrar);
            this.Controls.Add(this.gbrEditar);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbrEditar.ResumeLayout(false);
            this.gbrEditar.PerformLayout();
            this.gbrCadastrar.ResumeLayout(false);
            this.gbrCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox gbrEditar;
        private System.Windows.Forms.TextBox txtPrecoEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.TextBox txtProdutoEditar;
        private System.Windows.Forms.Label lblProdutoEditar;
        private System.Windows.Forms.GroupBox gbrCadastrar;
        private System.Windows.Forms.TextBox txtPrecoCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtProdutoCad;
        private System.Windows.Forms.Label lblProdutoCad;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.Label lblCategoriaCad;
    }
}