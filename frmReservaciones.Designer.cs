namespace Hotel
{
    partial class frmReservaciones
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.pListas = new System.Windows.Forms.Panel();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(749, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 59);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgvHabitaciones
            // 
            this.dtgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHabitaciones.Location = new System.Drawing.Point(13, 199);
            this.dtgvHabitaciones.Name = "dtgvHabitaciones";
            this.dtgvHabitaciones.Size = new System.Drawing.Size(454, 178);
            this.dtgvHabitaciones.TabIndex = 2;
            this.dtgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellClick);
            this.dtgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHabitaciones_CellContentClick);
            // 
            // pListas
            // 
            this.pListas.AutoScroll = true;
            this.pListas.Location = new System.Drawing.Point(492, 86);
            this.pListas.Name = "pListas";
            this.pListas.Size = new System.Drawing.Size(391, 291);
            this.pListas.TabIndex = 3;
            this.pListas.Paint += new System.Windows.Forms.PaintEventHandler(this.pListas_Paint);
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Location = new System.Drawing.Point(13, 12);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.Size = new System.Drawing.Size(454, 178);
            this.dtgvClientes.TabIndex = 4;
            this.dtgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellClick);
            this.dtgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dias";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(616, 25);
            this.txtDias.Multiline = true;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(107, 33);
            this.txtDias.TabIndex = 6;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 389);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.pListas);
            this.Controls.Add(this.dtgvHabitaciones);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgvHabitaciones;
        private System.Windows.Forms.Panel pListas;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDias;
    }
}