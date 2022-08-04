namespace Projeto.Forms
{
    partial class Pedidos
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.grbCadastrarIdCliente = new System.Windows.Forms.GroupBox();
            this.txtProdutoCadastrar = new System.Windows.Forms.TextBox();
            this.txtIdProdutoCadastrar = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblUsuarioCadastrar = new System.Windows.Forms.Label();
            this.lblCadatrarProduto = new System.Windows.Forms.Label();
            this.grbLocalizar = new System.Windows.Forms.GroupBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtIdLocalizar = new System.Windows.Forms.TextBox();
            this.lblIdLocalizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.grbCadastrarIdCliente.SuspendLayout();
            this.grbLocalizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(-1, -6);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(316, 230);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // grbCadastrarIdCliente
            // 
            this.grbCadastrarIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbCadastrarIdCliente.Controls.Add(this.txtProdutoCadastrar);
            this.grbCadastrarIdCliente.Controls.Add(this.txtIdProdutoCadastrar);
            this.grbCadastrarIdCliente.Controls.Add(this.btnCadastrar);
            this.grbCadastrarIdCliente.Controls.Add(this.lblUsuarioCadastrar);
            this.grbCadastrarIdCliente.Controls.Add(this.lblCadatrarProduto);
            this.grbCadastrarIdCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrarIdCliente.Location = new System.Drawing.Point(-1, 221);
            this.grbCadastrarIdCliente.Name = "grbCadastrarIdCliente";
            this.grbCadastrarIdCliente.Size = new System.Drawing.Size(316, 184);
            this.grbCadastrarIdCliente.TabIndex = 1;
            this.grbCadastrarIdCliente.TabStop = false;
            this.grbCadastrarIdCliente.Text = "Cadastrar:";
            // 
            // txtProdutoCadastrar
            // 
            this.txtProdutoCadastrar.Location = new System.Drawing.Point(114, 22);
            this.txtProdutoCadastrar.Name = "txtProdutoCadastrar";
            this.txtProdutoCadastrar.Size = new System.Drawing.Size(177, 27);
            this.txtProdutoCadastrar.TabIndex = 6;
            // 
            // txtIdProdutoCadastrar
            // 
            this.txtIdProdutoCadastrar.Location = new System.Drawing.Point(114, 61);
            this.txtIdProdutoCadastrar.Name = "txtIdProdutoCadastrar";
            this.txtIdProdutoCadastrar.Size = new System.Drawing.Size(177, 27);
            this.txtIdProdutoCadastrar.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(14, 119);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(278, 34);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblUsuarioCadastrar
            // 
            this.lblUsuarioCadastrar.AutoSize = true;
            this.lblUsuarioCadastrar.Location = new System.Drawing.Point(77, 64);
            this.lblUsuarioCadastrar.Name = "lblUsuarioCadastrar";
            this.lblUsuarioCadastrar.Size = new System.Drawing.Size(31, 21);
            this.lblUsuarioCadastrar.TabIndex = 2;
            this.lblUsuarioCadastrar.Text = "ID:";
            // 
            // lblCadatrarProduto
            // 
            this.lblCadatrarProduto.AutoSize = true;
            this.lblCadatrarProduto.Location = new System.Drawing.Point(32, 23);
            this.lblCadatrarProduto.Name = "lblCadatrarProduto";
            this.lblCadatrarProduto.Size = new System.Drawing.Size(76, 21);
            this.lblCadatrarProduto.TabIndex = 0;
            this.lblCadatrarProduto.Text = "Produto:";
            // 
            // grbLocalizar
            // 
            this.grbLocalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbLocalizar.Controls.Add(this.txtIdLocalizar);
            this.grbLocalizar.Controls.Add(this.btnLocalizar);
            this.grbLocalizar.Controls.Add(this.lblIdLocalizar);
            this.grbLocalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocalizar.Location = new System.Drawing.Point(311, 221);
            this.grbLocalizar.Name = "grbLocalizar";
            this.grbLocalizar.Size = new System.Drawing.Size(283, 184);
            this.grbLocalizar.TabIndex = 2;
            this.grbLocalizar.TabStop = false;
            this.grbLocalizar.Text = "Localizar Pedido:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Location = new System.Drawing.Point(14, 119);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(258, 34);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(311, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(289, 224);
            this.dgvProdutos.TabIndex = 3;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // txtIdLocalizar
            // 
            this.txtIdLocalizar.Location = new System.Drawing.Point(47, 58);
            this.txtIdLocalizar.Name = "txtIdLocalizar";
            this.txtIdLocalizar.Size = new System.Drawing.Size(177, 27);
            this.txtIdLocalizar.TabIndex = 8;
            // 
            // lblIdLocalizar
            // 
            this.lblIdLocalizar.AutoSize = true;
            this.lblIdLocalizar.Location = new System.Drawing.Point(10, 61);
            this.lblIdLocalizar.Name = "lblIdLocalizar";
            this.lblIdLocalizar.Size = new System.Drawing.Size(31, 21);
            this.lblIdLocalizar.TabIndex = 7;
            this.lblIdLocalizar.Text = "ID:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 405);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbLocalizar);
            this.Controls.Add(this.grbCadastrarIdCliente);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.grbCadastrarIdCliente.ResumeLayout(false);
            this.grbCadastrarIdCliente.PerformLayout();
            this.grbLocalizar.ResumeLayout(false);
            this.grbLocalizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox grbCadastrarIdCliente;
        private System.Windows.Forms.GroupBox grbLocalizar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblCadatrarProduto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblUsuarioCadastrar;
        private System.Windows.Forms.TextBox txtProdutoCadastrar;
        private System.Windows.Forms.TextBox txtIdProdutoCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtIdLocalizar;
        private System.Windows.Forms.Label lblIdLocalizar;
    }
}