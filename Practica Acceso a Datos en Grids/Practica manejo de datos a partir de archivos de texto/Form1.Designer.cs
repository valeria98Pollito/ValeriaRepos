namespace Practica_manejo_de_datos_a_partir_de_archivos_de_texto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_list = new System.Windows.Forms.RadioButton();
            this.rb_grid = new System.Windows.Forms.RadioButton();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Consulta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_list);
            this.panel1.Controls.Add(this.rb_grid);
            this.panel1.Location = new System.Drawing.Point(288, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 63);
            this.panel1.TabIndex = 1;
            // 
            // rb_list
            // 
            this.rb_list.AutoSize = true;
            this.rb_list.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_list.ForeColor = System.Drawing.Color.Teal;
            this.rb_list.Location = new System.Drawing.Point(0, 30);
            this.rb_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_list.Name = "rb_list";
            this.rb_list.Size = new System.Drawing.Size(88, 24);
            this.rb_list.TabIndex = 2;
            this.rb_list.TabStop = true;
            this.rb_list.Text = "ListView";
            this.rb_list.UseVisualStyleBackColor = true;
            // 
            // rb_grid
            // 
            this.rb_grid.AutoSize = true;
            this.rb_grid.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_grid.ForeColor = System.Drawing.Color.Teal;
            this.rb_grid.Location = new System.Drawing.Point(0, 2);
            this.rb_grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_grid.Name = "rb_grid";
            this.rb_grid.Size = new System.Drawing.Size(126, 24);
            this.rb_grid.TabIndex = 1;
            this.rb_grid.TabStop = true;
            this.rb_grid.Text = "DataGridview";
            this.rb_grid.UseVisualStyleBackColor = true;
            this.rb_grid.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Location = new System.Drawing.Point(45, 94);
            this.txt_Consulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(136, 20);
            this.txt_Consulta.TabIndex = 2;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Aceptar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(185, 86);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(46, 33);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "OK";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lbl_Consulta
            // 
            this.lbl_Consulta.AutoSize = true;
            this.lbl_Consulta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consulta.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_Consulta.Location = new System.Drawing.Point(41, 65);
            this.lbl_Consulta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Consulta.Name = "lbl_Consulta";
            this.lbl_Consulta.Size = new System.Drawing.Size(78, 21);
            this.lbl_Consulta.TabIndex = 4;
            this.lbl_Consulta.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 177);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 127);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 178);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(120, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valeria Itzel Adán Contreras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "TECNOLOGÍAS DE INFORMACIÓN\r\nAcceso a Datos en Grinds\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(796, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Consulta);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Consulta);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Practica Acceso a Datos en Grids";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_list;
        private System.Windows.Forms.RadioButton rb_grid;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Consulta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

