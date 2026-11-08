namespace DataStructuresDynamicWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            txtDato = new TextBox();
            lstResultados = new ListBox();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnPush = new Button();
            btnPop = new Button();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(308, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(232, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar dinamico";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(81, 46);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(175, 35);
            txtDato.TabIndex = 1;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(57, 263);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(897, 364);
            lstResultados.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(546, 41);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(232, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(784, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(232, 40);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(57, 151);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(232, 40);
            btnPush.TabIndex = 5;
            btnPush.Text = "Pila (Push)";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(308, 151);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(232, 40);
            btnPop.TabIndex = 6;
            btnPop.Text = "Pila (Pop)";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(546, 151);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(232, 40);
            btnEnqueue.TabIndex = 7;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(784, 151);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(232, 40);
            btnDequeue.TabIndex = 8;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 803);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(lstResultados);
            Controls.Add(txtDato);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtDato;
        private ListBox lstResultados;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnPush;
        private Button btnPop;
        private Button btnEnqueue;
        private Button btnDequeue;
    }
}
