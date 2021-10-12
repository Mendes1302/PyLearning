
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
            this.label1 = new System.Windows.Forms.Label();
            this.radio_a = new System.Windows.Forms.RadioButton();
            this.radio_b = new System.Windows.Forms.RadioButton();
            this.questao = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_c = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            // 
            // radio_a
            // 
            this.radio_a.AutoSize = true;
            this.radio_a.Location = new System.Drawing.Point(12, 237);
            this.radio_a.Name = "radio_a";
            this.radio_a.Size = new System.Drawing.Size(160, 19);
            this.radio_a.TabIndex = 1;
            this.radio_a.TabStop = true;
            this.radio_a.Text = "Imprimir uma mensagem";
            this.radio_a.UseVisualStyleBackColor = true;
            // 
            // radio_b
            // 
            this.radio_b.AutoSize = true;
            this.radio_b.Location = new System.Drawing.Point(12, 274);
            this.radio_b.Name = "radio_b";
            this.radio_b.Size = new System.Drawing.Size(124, 19);
            this.radio_b.TabIndex = 2;
            this.radio_b.TabStop = true;
            this.radio_b.Text = "Copiar algo da tela";
            this.radio_b.UseVisualStyleBackColor = true;
            this.radio_b.CheckedChanged += new System.EventHandler(this.radio_b_CheckedChanged);
            // 
            // questao
            // 
            this.questao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.questao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questao.Location = new System.Drawing.Point(12, 59);
            this.questao.Name = "questao";
            this.questao.ReadOnly = true;
            this.questao.Size = new System.Drawing.Size(745, 147);
            this.questao.TabIndex = 3;
            this.questao.Text = "1) Para que o comando print serve?\n\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Próximo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_c
            // 
            this.radio_c.AutoSize = true;
            this.radio_c.Location = new System.Drawing.Point(12, 314);
            this.radio_c.Name = "radio_c";
            this.radio_c.Size = new System.Drawing.Size(177, 19);
            this.radio_c.TabIndex = 5;
            this.radio_c.TabStop = true;
            this.radio_c.Text = "Nenhuma das Opções acima";
            this.radio_c.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radio_c);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questao);
            this.Controls.Add(this.radio_b);
            this.Controls.Add(this.radio_a);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_a;
        private System.Windows.Forms.RadioButton radio_b;
        private System.Windows.Forms.RichTextBox questao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_c;
    }
}