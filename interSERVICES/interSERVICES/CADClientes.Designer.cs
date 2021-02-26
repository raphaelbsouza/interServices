/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 10:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace interSERVICES
{
	partial class cadClientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtENDERECO;
		private System.Windows.Forms.TextBox txtNOME;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadClientes));
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtENDERECO = new System.Windows.Forms.TextBox();
			this.txtNOME = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTELEFONE = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(99, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 24);
			this.label4.TabIndex = 17;
			this.label4.Text = "Cadastro de Cliente";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(299, 214);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 44);
			this.button2.TabIndex = 4;
			this.button2.Text = "FECHAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(18, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 44);
			this.button1.TabIndex = 3;
			this.button1.Text = "CADASTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtENDERECO
			// 
			this.txtENDERECO.Location = new System.Drawing.Point(120, 122);
			this.txtENDERECO.Name = "txtENDERECO";
			this.txtENDERECO.Size = new System.Drawing.Size(297, 20);
			this.txtENDERECO.TabIndex = 1;
			// 
			// txtNOME
			// 
			this.txtNOME.Location = new System.Drawing.Point(120, 92);
			this.txtNOME.Name = "txtNOME";
			this.txtNOME.Size = new System.Drawing.Size(297, 20);
			this.txtNOME.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "ENDEREÇO:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "TELEFONE:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 18);
			this.label1.TabIndex = 5;
			this.label1.Text = "NOME: ";
			// 
			// txtTELEFONE
			// 
			this.txtTELEFONE.Location = new System.Drawing.Point(120, 154);
			this.txtTELEFONE.Mask = "(00)0.0000-0000";
			this.txtTELEFONE.Name = "txtTELEFONE";
			this.txtTELEFONE.Size = new System.Drawing.Size(88, 20);
			this.txtTELEFONE.TabIndex = 2;
			// 
			// cadClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(434, 286);
			this.Controls.Add(this.txtTELEFONE);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtENDERECO);
			this.Controls.Add(this.txtNOME);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "cadClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Cliente (inFOSERVICES v 1.0)";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox txtTELEFONE;
	}
}
