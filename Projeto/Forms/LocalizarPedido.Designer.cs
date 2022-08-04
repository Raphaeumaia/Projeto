namespace Projeto.Forms
{
    partial class LocalizarPedido
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gbrLocalizar = new System.Windows.Forms.GroupBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblLocalizar = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbrLocalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(-3, 0);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(806, 267);
            this.dgvPedidos.TabIndex = 0;
            // 
            // gbrLocalizar
            // 
            this.gbrLocalizar.Controls.Add(this.lblPreco);
            this.gbrLocalizar.Controls.Add(this.txtId);
            this.gbrLocalizar.Controls.Add(this.lblLocalizar);
            this.gbrLocalizar.Controls.Add(this.btnLocalizar);
            this.gbrLocalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrLocalizar.Location = new System.Drawing.Point(13, 273);
            this.gbrLocalizar.Name = "gbrLocalizar";
            this.gbrLocalizar.Size = new System.Drawing.Size(775, 165);
            this.gbrLocalizar.TabIndex = 1;
            this.gbrLocalizar.TabStop = false;
            this.gbrLocalizar.Text = "Localizar Pedido";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(47, 102);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(163, 31);
            this.btnLocalizar.TabIndex = 0;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblLocalizar
            // 
            this.lblLocalizar.AutoSize = true;
            this.lblLocalizar.Location = new System.Drawing.Point(7, 47);
            this.lblLocalizar.Name = "lblLocalizar";
            this.lblLocalizar.Size = new System.Drawing.Size(115, 21);
            this.lblLocalizar.TabIndex = 1;
            this.lblLocalizar.Text = "Id do Cliente:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(129, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 27);
            this.txtId.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(375, 81);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 21);
            this.lblPreco.TabIndex = 3;
            // 
            // LocalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbrLocalizar);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "LocalizarPedido";
            this.Text = "LocalizarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbrLocalizar.ResumeLayout(false);
            this.gbrLocalizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox gbrLocalizar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLocalizar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label lblPreco;
    }
}