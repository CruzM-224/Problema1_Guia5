
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.tituo = new System.Windows.Forms.Label();
            this.rbtngerente = new System.Windows.Forms.RadioButton();
            this.rbtnsubgerente = new System.Windows.Forms.RadioButton();
            this.rbtnsecretaria = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(170, 120);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(170, 153);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(100, 20);
            this.Salario.TabIndex = 3;
            this.Salario.Text = "Salario";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(346, 211);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // tituo
            // 
            this.tituo.AutoSize = true;
            this.tituo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituo.Location = new System.Drawing.Point(330, 45);
            this.tituo.Name = "tituo";
            this.tituo.Size = new System.Drawing.Size(131, 25);
            this.tituo.TabIndex = 5;
            this.tituo.Text = "Problema 1";
            // 
            // rbtngerente
            // 
            this.rbtngerente.AutoSize = true;
            this.rbtngerente.Location = new System.Drawing.Point(489, 104);
            this.rbtngerente.Name = "rbtngerente";
            this.rbtngerente.Size = new System.Drawing.Size(63, 17);
            this.rbtngerente.TabIndex = 6;
            this.rbtngerente.TabStop = true;
            this.rbtngerente.Text = "Gerente";
            this.rbtngerente.UseVisualStyleBackColor = true;
            this.rbtngerente.CheckedChanged += new System.EventHandler(this.rbtngerente_CheckedChanged);
            // 
            // rbtnsubgerente
            // 
            this.rbtnsubgerente.AutoSize = true;
            this.rbtnsubgerente.Location = new System.Drawing.Point(489, 138);
            this.rbtnsubgerente.Name = "rbtnsubgerente";
            this.rbtnsubgerente.Size = new System.Drawing.Size(80, 17);
            this.rbtnsubgerente.TabIndex = 7;
            this.rbtnsubgerente.TabStop = true;
            this.rbtnsubgerente.Text = "Subgerente";
            this.rbtnsubgerente.UseVisualStyleBackColor = true;
            this.rbtnsubgerente.CheckedChanged += new System.EventHandler(this.rbtnsubgerente_CheckedChanged);
            // 
            // rbtnsecretaria
            // 
            this.rbtnsecretaria.AutoSize = true;
            this.rbtnsecretaria.Location = new System.Drawing.Point(489, 174);
            this.rbtnsecretaria.Name = "rbtnsecretaria";
            this.rbtnsecretaria.Size = new System.Drawing.Size(73, 17);
            this.rbtnsecretaria.TabIndex = 8;
            this.rbtnsecretaria.TabStop = true;
            this.rbtnsecretaria.Text = "Secretaria";
            this.rbtnsecretaria.UseVisualStyleBackColor = true;
            this.rbtnsecretaria.CheckedChanged += new System.EventHandler(this.rbtnsecretaria_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnsecretaria);
            this.Controls.Add(this.rbtnsubgerente);
            this.Controls.Add(this.rbtngerente);
            this.Controls.Add(this.tituo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label tituo;
        private System.Windows.Forms.RadioButton rbtngerente;
        private System.Windows.Forms.RadioButton rbtnsubgerente;
        private System.Windows.Forms.RadioButton rbtnsecretaria;
    }
}

