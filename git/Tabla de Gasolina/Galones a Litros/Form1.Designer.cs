namespace Galones_a_Litros
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Litros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Galones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gasolinaprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pase = new System.Windows.Forms.TextBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpromediorms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(14, 451);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(132, 46);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Iniciar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.Litros,
            this.Galones,
            this.Precio});
            this.dtgv.Location = new System.Drawing.Point(365, 30);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(386, 320);
            this.dtgv.TabIndex = 2;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // x
            // 
            this.x.HeaderText = "ID";
            this.x.Name = "x";
            // 
            // Litros
            // 
            this.Litros.HeaderText = "Litros/Km";
            this.Litros.Name = "Litros";
            this.Litros.Width = 80;
            // 
            // Galones
            // 
            this.Galones.HeaderText = "GalonPorKm";
            this.Galones.Name = "Galones";
            this.Galones.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "CostoPorKM";
            this.Precio.Name = "Precio";
            this.Precio.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(209, 52);
            this.cantidad.Multiline = true;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(89, 21);
            this.cantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "ingrese porcion de litros";
            // 
            // gasolinaprecio
            // 
            this.gasolinaprecio.Location = new System.Drawing.Point(209, 100);
            this.gasolinaprecio.Multiline = true;
            this.gasolinaprecio.Name = "gasolinaprecio";
            this.gasolinaprecio.Size = new System.Drawing.Size(89, 21);
            this.gasolinaprecio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "precio gasolina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "paso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pase
            // 
            this.pase.Location = new System.Drawing.Point(209, 144);
            this.pase.Multiline = true;
            this.pase.Name = "pase";
            this.pase.Size = new System.Drawing.Size(86, 21);
            this.pase.TabIndex = 12;
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(209, 211);
            this.txtpromedio.Multiline = true;
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.ReadOnly = true;
            this.txtpromedio.Size = new System.Drawing.Size(86, 21);
            this.txtpromedio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Promedio";
            // 
            // txtpromediorms
            // 
            this.txtpromediorms.Location = new System.Drawing.Point(209, 260);
            this.txtpromediorms.Multiline = true;
            this.txtpromediorms.Name = "txtpromediorms";
            this.txtpromediorms.ReadOnly = true;
            this.txtpromediorms.Size = new System.Drawing.Size(86, 21);
            this.txtpromediorms.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Promedio RMS";
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(163, 451);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(132, 46);
            this.btnborrar.TabIndex = 17;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 530);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpromediorms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.pase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gasolinaprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Tabla de Gasolina";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Litros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Galones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox gasolinaprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pase;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpromediorms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnborrar;
    }
}

