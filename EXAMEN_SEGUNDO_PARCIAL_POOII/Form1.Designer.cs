
namespace EXAMEN_SEGUNDO_PARCIAL_POOII
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNAGRAGAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            this.BTNMOSTRAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXBNOMBRE = new System.Windows.Forms.TextBox();
            this.TXBCORREO = new System.Windows.Forms.TextBox();
            this.TXBEDAD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXBID = new System.Windows.Forms.TextBox();
            this.TXBFECHADENACIMIENTO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAGRAGAR
            // 
            this.BTNAGRAGAR.Location = new System.Drawing.Point(1288, 79);
            this.BTNAGRAGAR.Name = "BTNAGRAGAR";
            this.BTNAGRAGAR.Size = new System.Drawing.Size(184, 73);
            this.BTNAGRAGAR.TabIndex = 0;
            this.BTNAGRAGAR.Text = "AGREGAR";
            this.BTNAGRAGAR.UseVisualStyleBackColor = true;
      
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(1288, 378);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(184, 67);
            this.BTNELIMINAR.TabIndex = 1;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(1288, 287);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(184, 62);
            this.BTNACTUALIZAR.TabIndex = 2;
            this.BTNACTUALIZAR.Text = "ACTUALIZAR";
            this.BTNACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // BTNMOSTRAR
            // 
            this.BTNMOSTRAR.Location = new System.Drawing.Point(1288, 186);
            this.BTNMOSTRAR.Name = "BTNMOSTRAR";
            this.BTNMOSTRAR.Size = new System.Drawing.Size(184, 62);
            this.BTNMOSTRAR.TabIndex = 3;
            this.BTNMOSTRAR.Text = "MOSTRAR";
            this.BTNMOSTRAR.UseVisualStyleBackColor = true;
            this.BTNMOSTRAR.Click += new System.EventHandler(this.BTNMOSTRAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1376, 433);
            this.dataGridView1.TabIndex = 4;
            // 
            // TXBNOMBRE
            // 
            this.TXBNOMBRE.Location = new System.Drawing.Point(213, 151);
            this.TXBNOMBRE.Name = "TXBNOMBRE";
            this.TXBNOMBRE.Size = new System.Drawing.Size(258, 29);
            this.TXBNOMBRE.TabIndex = 5;
            
            // 
            // TXBCORREO
            // 
            this.TXBCORREO.Location = new System.Drawing.Point(863, 151);
            this.TXBCORREO.Name = "TXBCORREO";
            this.TXBCORREO.Size = new System.Drawing.Size(258, 29);
            this.TXBCORREO.TabIndex = 7;
            
            // 
            // TXBEDAD
            // 
            this.TXBEDAD.Location = new System.Drawing.Point(213, 264);
            this.TXBEDAD.Name = "TXBEDAD";
            this.TXBEDAD.Size = new System.Drawing.Size(258, 29);
            this.TXBEDAD.TabIndex = 8;
        
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(91, 268);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(58, 25);
            this.V.TabIndex = 10;
            this.V.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(746, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // TXBID
            // 
            this.TXBID.Location = new System.Drawing.Point(863, 223);
            this.TXBID.Name = "TXBID";
            this.TXBID.Size = new System.Drawing.Size(258, 29);
            this.TXBID.TabIndex = 14;
           
            // 
            // TXBFECHADENACIMIENTO
            // 
            this.TXBFECHADENACIMIENTO.Location = new System.Drawing.Point(213, 357);
            this.TXBFECHADENACIMIENTO.Name = "TXBFECHADENACIMIENTO";
            this.TXBFECHADENACIMIENTO.Size = new System.Drawing.Size(258, 29);
            this.TXBFECHADENACIMIENTO.TabIndex = 15;
          
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "FechaNacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(824, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 29);
            this.dateTimePicker1.TabIndex = 17;
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 936);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXBFECHADENACIMIENTO);
            this.Controls.Add(this.TXBID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.V);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBEDAD);
            this.Controls.Add(this.TXBCORREO);
            this.Controls.Add(this.TXBNOMBRE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNMOSTRAR);
            this.Controls.Add(this.BTNACTUALIZAR);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNAGRAGAR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAGRAGAR;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNACTUALIZAR;
        private System.Windows.Forms.Button BTNMOSTRAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXBNOMBRE;
        private System.Windows.Forms.TextBox TXBCORREO;
        private System.Windows.Forms.TextBox TXBEDAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXBID;
        private System.Windows.Forms.TextBox TXBFECHADENACIMIENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

