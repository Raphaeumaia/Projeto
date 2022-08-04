namespace Projeto.Forms
{
    partial class Categorias
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.gbrCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCadastrar = new System.Windows.Forms.TextBox();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.gbrAtulizar = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtAtualizar = new System.Windows.Forms.TextBox();
            this.lblAtualizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.gbrCadastrar.SuspendLayout();
            this.gbrAtulizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(0, 0);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(594, 215);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            // 
            // gbrCadastrar
            // 
            this.gbrCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbrCadastrar.Controls.Add(this.btnCadastrar);
            this.gbrCadastrar.Controls.Add(this.txtCadastrar);
            this.gbrCadastrar.Controls.Add(this.lblCadastrar);
            this.gbrCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrCadastrar.Location = new System.Drawing.Point(0, 215);
            this.gbrCadastrar.Name = "gbrCadastrar";
            this.gbrCadastrar.Size = new System.Drawing.Size(319, 191);
            this.gbrCadastrar.TabIndex = 1;
            this.gbrCadastrar.TabStop = false;
            this.gbrCadastrar.Text = "Cadastrar Nova Categoria";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(36, 105);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 31);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCadastrar
            // 
            this.txtCadastrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastrar.Location = new System.Drawing.Point(189, 58);
            this.txtCadastrar.Name = "txtCadastrar";
            this.txtCadastrar.Size = new System.Drawing.Size(100, 21);
            this.txtCadastrar.TabIndex = 1;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(33, 58);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(150, 16);
            this.lblCadastrar.TabIndex = 0;
            this.lblCadastrar.Text = "Nome da nova categoria:";
            // 
            // gbrAtulizar
            // 
            this.gbrAtulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbrAtulizar.Controls.Add(this.btnAtualizar);
            this.gbrAtulizar.Controls.Add(this.txtAtualizar);
            this.gbrAtulizar.Controls.Add(this.lblAtualizar);
            this.gbrAtulizar.Enabled = false;
            this.gbrAtulizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrAtulizar.Location = new System.Drawing.Point(314, 215);
            this.gbrAtulizar.Name = "gbrAtulizar";
            this.gbrAtulizar.Size = new System.Drawing.Size(280, 191);
            this.gbrAtulizar.TabIndex = 3;
            this.gbrAtulizar.TabStop = false;
            this.gbrAtulizar.Text = "Atualizar Categoria";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(24, 105);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 31);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtAtualizar
            // 
            this.txtAtualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtualizar.Location = new System.Drawing.Point(154, 60);
            this.txtAtualizar.Name = "txtAtualizar";
            this.txtAtualizar.Size = new System.Drawing.Size(100, 21);
            this.txtAtualizar.TabIndex = 1;
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.AutoSize = true;
            this.lblAtualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualizar.Location = new System.Drawing.Point(6, 63);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(149, 16);
            this.lblAtualizar.TabIndex = 0;
            this.lblAtualizar.Text = "Novo nome da categoria:";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.gbrAtulizar);
            this.Controls.Add(this.gbrCadastrar);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.gbrCadastrar.ResumeLayout(false);
            this.gbrCadastrar.PerformLayout();
            this.gbrAtulizar.ResumeLayout(false);
            this.gbrAtulizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox gbrCadastrar;
        private System.Windows.Forms.GroupBox gbrAtulizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtAtualizar;
        private System.Windows.Forms.Label lblAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
    }
}