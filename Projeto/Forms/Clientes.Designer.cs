namespace Projeto.Forms
{
    partial class Clientes
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
            this.gbrCadastrar = new System.Windows.Forms.GroupBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeCad = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbAtualizar = new System.Windows.Forms.GroupBox();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbrCadastrar.SuspendLayout();
            this.grbAtualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(594, 215);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // gbrCadastrar
            // 
            this.gbrCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbrCadastrar.Controls.Add(this.txtEmailCad);
            this.gbrCadastrar.Controls.Add(this.lblEmailCad);
            this.gbrCadastrar.Controls.Add(this.btnCadastrar);
            this.gbrCadastrar.Controls.Add(this.txtNomeCad);
            this.gbrCadastrar.Controls.Add(this.lblNomeCad);
            this.gbrCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrCadastrar.Location = new System.Drawing.Point(0, 212);
            this.gbrCadastrar.Name = "gbrCadastrar";
            this.gbrCadastrar.Size = new System.Drawing.Size(319, 191);
            this.gbrCadastrar.TabIndex = 2;
            this.gbrCadastrar.TabStop = false;
            this.gbrCadastrar.Text = "Cadastrar Novo Cliente";
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCad.Location = new System.Drawing.Point(140, 78);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(100, 21);
            this.txtEmailCad.TabIndex = 4;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCad.Location = new System.Drawing.Point(35, 78);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(38, 16);
            this.lblEmailCad.TabIndex = 3;
            this.lblEmailCad.Text = "Email:";
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
            // txtNomeCad
            // 
            this.txtNomeCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCad.Location = new System.Drawing.Point(140, 46);
            this.txtNomeCad.Name = "txtNomeCad";
            this.txtNomeCad.Size = new System.Drawing.Size(100, 21);
            this.txtNomeCad.TabIndex = 1;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(35, 49);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(99, 16);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo:";
            // 
            // grbAtualizar
            // 
            this.grbAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbAtualizar.Controls.Add(this.txtEmailEditar);
            this.grbAtualizar.Controls.Add(this.btnAtualizar);
            this.grbAtualizar.Controls.Add(this.lblEmailEditar);
            this.grbAtualizar.Controls.Add(this.txtNomeEditar);
            this.grbAtualizar.Controls.Add(this.lblNomeEditar);
            this.grbAtualizar.Enabled = false;
            this.grbAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAtualizar.Location = new System.Drawing.Point(319, 212);
            this.grbAtualizar.Name = "grbAtualizar";
            this.grbAtualizar.Size = new System.Drawing.Size(275, 191);
            this.grbAtualizar.TabIndex = 3;
            this.grbAtualizar.TabStop = false;
            this.grbAtualizar.Text = "Atualizar Cliente:";
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEditar.Location = new System.Drawing.Point(134, 78);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(100, 21);
            this.txtEmailEditar.TabIndex = 6;
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
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailEditar.Location = new System.Drawing.Point(29, 78);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(38, 16);
            this.lblEmailEditar.TabIndex = 5;
            this.lblEmailEditar.Text = "Email:";
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditar.Location = new System.Drawing.Point(134, 46);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(100, 21);
            this.txtNomeEditar.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditar.Location = new System.Drawing.Point(29, 49);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(99, 16);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.grbAtualizar);
            this.Controls.Add(this.gbrCadastrar);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbrCadastrar.ResumeLayout(false);
            this.gbrCadastrar.PerformLayout();
            this.grbAtualizar.ResumeLayout(false);
            this.grbAtualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbrCadastrar;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbAtualizar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.Label lblNomeEditar;
    }
}