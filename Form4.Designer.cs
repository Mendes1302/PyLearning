
namespace PyLearning
{
    partial class Form4
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
            this.radio_a = new System.Windows.Forms.RadioButton();
            this.radio_b = new System.Windows.Forms.RadioButton();
            this.questao = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_c = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gabarito = new System.Windows.Forms.RichTextBox();
            this.acerto = new System.Windows.Forms.Label();
            this.erro = new System.Windows.Forms.Label();
            this.acer = new System.Windows.Forms.Label();
            this.gab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio_a
            // 
            this.radio_a.AutoSize = true;
            this.radio_a.Location = new System.Drawing.Point(12, 237);
            this.radio_a.Name = "radio_a";
            this.radio_a.Size = new System.Drawing.Size(14, 13);
            this.radio_a.TabIndex = 1;
            this.radio_a.TabStop = true;
            this.radio_a.UseVisualStyleBackColor = true;
            this.radio_a.Visible = false;
            // 
            // radio_b
            // 
            this.radio_b.AutoSize = true;
            this.radio_b.Location = new System.Drawing.Point(12, 269);
            this.radio_b.Name = "radio_b";
            this.radio_b.Size = new System.Drawing.Size(14, 13);
            this.radio_b.TabIndex = 2;
            this.radio_b.TabStop = true;
            this.radio_b.UseVisualStyleBackColor = true;
            this.radio_b.Visible = false;
            // 
            // questao
            // 
            this.questao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.questao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questao.Location = new System.Drawing.Point(1, 84);
            this.questao.Name = "questao";
            this.questao.ReadOnly = true;
            this.questao.Size = new System.Drawing.Size(835, 147);
            this.questao.TabIndex = 3;
            this.questao.Text = "";
            this.questao.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_c
            // 
            this.radio_c.AutoSize = true;
            this.radio_c.Location = new System.Drawing.Point(12, 304);
            this.radio_c.Name = "radio_c";
            this.radio_c.Size = new System.Drawing.Size(14, 13);
            this.radio_c.TabIndex = 5;
            this.radio_c.TabStop = true;
            this.radio_c.UseVisualStyleBackColor = true;
            this.radio_c.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            // 
            // gabarito
            // 
            this.gabarito.BackColor = System.Drawing.SystemColors.Control;
            this.gabarito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gabarito.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gabarito.Location = new System.Drawing.Point(12, 84);
            this.gabarito.Name = "gabarito";
            this.gabarito.Size = new System.Drawing.Size(363, 128);
            this.gabarito.TabIndex = 6;
            this.gabarito.Text = "";
            this.gabarito.Visible = false;
            // 
            // acerto
            // 
            this.acerto.AutoSize = true;
            this.acerto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acerto.Location = new System.Drawing.Point(70, 350);
            this.acerto.Name = "acerto";
            this.acerto.Size = new System.Drawing.Size(0, 28);
            this.acerto.TabIndex = 7;
            // 
            // erro
            // 
            this.erro.AutoSize = true;
            this.erro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.erro.Location = new System.Drawing.Point(25, 184);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(65, 28);
            this.erro.TabIndex = 8;
            this.erro.Text = "label2";
            this.erro.Visible = false;
            // 
            // acer
            // 
            this.acer.AutoSize = true;
            this.acer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acer.Location = new System.Drawing.Point(25, 139);
            this.acer.Name = "acer";
            this.acer.Size = new System.Drawing.Size(65, 28);
            this.acer.TabIndex = 9;
            this.acer.Text = "label3";
            this.acer.Visible = false;
            // 
            // gab
            // 
            this.gab.AutoSize = true;
            this.gab.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gab.Location = new System.Drawing.Point(25, 96);
            this.gab.Name = "gab";
            this.gab.Size = new System.Drawing.Size(65, 28);
            this.gab.TabIndex = 11;
            this.gab.Text = "label5";
            this.gab.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 401);
            this.Controls.Add(this.gab);
            this.Controls.Add(this.acer);
            this.Controls.Add(this.erro);
            this.Controls.Add(this.acerto);
            this.Controls.Add(this.gabarito);
            this.Controls.Add(this.radio_c);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questao);
            this.Controls.Add(this.radio_b);
            this.Controls.Add(this.radio_a);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radio_a;
        private System.Windows.Forms.RadioButton radio_b;
        private System.Windows.Forms.RichTextBox questao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox gabarito;
        private System.Windows.Forms.Label acerto;
        private System.Windows.Forms.Label erro;
        private System.Windows.Forms.Label acer;
        private System.Windows.Forms.Label gab;
    }
}