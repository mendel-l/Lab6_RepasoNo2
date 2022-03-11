namespace Lab6_RepasoNo2
{
    partial class Alquileres
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.comboBoxNit = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownKmRecorridos = new System.Windows.Forms.NumericUpDown();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonNextForm = new System.Windows.Forms.Button();
            this.dateTimePickerAlquiler = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKmRecorridos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Km Recorridos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de Devolución:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fecha de Alquiler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "NIT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Placa:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(347, 66);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(125, 50);
            this.btnMostrar.TabIndex = 34;
            this.btnMostrar.Text = "Agregar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridViewResultado
            // 
            this.dataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultado.Location = new System.Drawing.Point(83, 199);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.Size = new System.Drawing.Size(321, 150);
            this.dataGridViewResultado.TabIndex = 33;
            // 
            // comboBoxNit
            // 
            this.comboBoxNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNit.FormattingEnabled = true;
            this.comboBoxNit.Location = new System.Drawing.Point(176, 24);
            this.comboBoxNit.Name = "comboBoxNit";
            this.comboBoxNit.Size = new System.Drawing.Size(160, 24);
            this.comboBoxNit.TabIndex = 45;
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(176, 52);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPlaca.TabIndex = 46;
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(176, 111);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerDevolucion.TabIndex = 50;
            // 
            // numericUpDownKmRecorridos
            // 
            this.numericUpDownKmRecorridos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownKmRecorridos.Location = new System.Drawing.Point(176, 137);
            this.numericUpDownKmRecorridos.Name = "numericUpDownKmRecorridos";
            this.numericUpDownKmRecorridos.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownKmRecorridos.TabIndex = 54;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(197, 435);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 59;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(0, 435);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 25);
            this.buttonReturn.TabIndex = 58;
            this.buttonReturn.Text = "Regresar";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonNextForm
            // 
            this.buttonNextForm.Location = new System.Drawing.Point(410, 435);
            this.buttonNextForm.Name = "buttonNextForm";
            this.buttonNextForm.Size = new System.Drawing.Size(75, 25);
            this.buttonNextForm.TabIndex = 60;
            this.buttonNextForm.Text = "Clientes";
            this.buttonNextForm.UseVisualStyleBackColor = true;
            this.buttonNextForm.Click += new System.EventHandler(this.buttonNextForm_Click);
            // 
            // dateTimePickerAlquiler
            // 
            this.dateTimePickerAlquiler.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAlquiler.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAlquiler.Location = new System.Drawing.Point(176, 83);
            this.dateTimePickerAlquiler.Name = "dateTimePickerAlquiler";
            this.dateTimePickerAlquiler.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerAlquiler.TabIndex = 55;
            // 
            // Alquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonNextForm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dateTimePickerAlquiler);
            this.Controls.Add(this.numericUpDownKmRecorridos);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.comboBoxNit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridViewResultado);
            this.Name = "Alquileres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquileres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKmRecorridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.ComboBox comboBoxNit;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.NumericUpDown numericUpDownKmRecorridos;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonNextForm;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlquiler;
    }
}