/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 10:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace interSERVICES
{
	partial class CadServicos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtTELEFONE;
		private System.Windows.Forms.MaskedTextBox txtDATA;
		private System.Windows.Forms.MaskedTextBox txtHORA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSERVICO;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtATENDENTE;
		private System.Windows.Forms.TextBox txtCLIENTE;
		private System.Windows.Forms.Label label3;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadServicos));
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSERVICO = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtATENDENTE = new System.Windows.Forms.TextBox();
			this.txtCLIENTE = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTELEFONE = new System.Windows.Forms.MaskedTextBox();
			this.txtDATA = new System.Windows.Forms.MaskedTextBox();
			this.txtHORA = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(302, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(118, 44);
			this.button2.TabIndex = 7;
			this.button2.Text = "FECHAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(21, 232);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 44);
			this.button1.TabIndex = 6;
			this.button1.Text = "CADASTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(89, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(260, 24);
			this.label7.TabIndex = 46;
			this.label7.Text = "Agendamento de Serviço";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(56, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 18);
			this.label6.TabIndex = 42;
			this.label6.Text = "HORA:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(56, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 18);
			this.label5.TabIndex = 41;
			this.label5.Text = "DATA:";
			// 
			// txtSERVICO
			// 
			this.txtSERVICO.Location = new System.Drawing.Point(123, 138);
			this.txtSERVICO.Name = "txtSERVICO";
			this.txtSERVICO.Size = new System.Drawing.Size(292, 20);
			this.txtSERVICO.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(35, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 18);
			this.label4.TabIndex = 39;
			this.label4.Text = "SERVIÇO:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 18);
			this.label2.TabIndex = 38;
			this.label2.Text = "ATENDENTE:";
			// 
			// txtATENDENTE
			// 
			this.txtATENDENTE.Location = new System.Drawing.Point(123, 112);
			this.txtATENDENTE.Name = "txtATENDENTE";
			this.txtATENDENTE.Size = new System.Drawing.Size(292, 20);
			this.txtATENDENTE.TabIndex = 2;
			// 
			// txtCLIENTE
			// 
			this.txtCLIENTE.Location = new System.Drawing.Point(123, 57);
			this.txtCLIENTE.Name = "txtCLIENTE";
			this.txtCLIENTE.Size = new System.Drawing.Size(292, 20);
			this.txtCLIENTE.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 18);
			this.label3.TabIndex = 35;
			this.label3.Text = "TELEFONE:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 18);
			this.label1.TabIndex = 34;
			this.label1.Text = "CLIENTE:";
			// 
			// txtTELEFONE
			// 
			this.txtTELEFONE.Location = new System.Drawing.Point(123, 83);
			this.txtTELEFONE.Mask = "(00)0.0000-0000";
			this.txtTELEFONE.Name = "txtTELEFONE";
			this.txtTELEFONE.Size = new System.Drawing.Size(88, 20);
			this.txtTELEFONE.TabIndex = 50;
			// 
			// txtDATA
			// 
			this.txtDATA.Location = new System.Drawing.Point(123, 168);
			this.txtDATA.Mask = "00/00/0000";
			this.txtDATA.Name = "txtDATA";
			this.txtDATA.Size = new System.Drawing.Size(65, 20);
			this.txtDATA.TabIndex = 51;
			this.txtDATA.ValidatingType = typeof(System.DateTime);
			// 
			// txtHORA
			// 
			this.txtHORA.Location = new System.Drawing.Point(123, 196);
			this.txtHORA.Mask = "00:00";
			this.txtHORA.Name = "txtHORA";
			this.txtHORA.Size = new System.Drawing.Size(38, 20);
			this.txtHORA.TabIndex = 52;
			this.txtHORA.ValidatingType = typeof(System.DateTime);
			// 
			// CadServicos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(434, 286);
			this.Controls.Add(this.txtHORA);
			this.Controls.Add(this.txtDATA);
			this.Controls.Add(this.txtTELEFONE);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtSERVICO);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtATENDENTE);
			this.Controls.Add(this.txtCLIENTE);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadServicos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agendamento de Serviços (inFOSERVICES v1.0)";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
