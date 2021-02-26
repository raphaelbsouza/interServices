/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 09:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace interSERVICES
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadCadastro;
		private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadCadastro = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cadastroToolStripMenuItem,
			this.agendamentoToolStripMenuItem,
			this.consultarToolStripMenuItem1,
			this.sobreToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(407, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cadCadastro,
			this.funcionárioToolStripMenuItem});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			// 
			// cadCadastro
			// 
			this.cadCadastro.Name = "cadCadastro";
			this.cadCadastro.Size = new System.Drawing.Size(151, 22);
			this.cadCadastro.Text = "Cliente";
			this.cadCadastro.Click += new System.EventHandler(this.ClienteToolStripMenuItemClick);
			// 
			// funcionárioToolStripMenuItem
			// 
			this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
			this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.funcionárioToolStripMenuItem.Text = "Funcionário";
			this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.FuncionárioToolStripMenuItemClick);
			// 
			// agendamentoToolStripMenuItem
			// 
			this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.serviçosToolStripMenuItem});
			this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
			this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.agendamentoToolStripMenuItem.Text = "Agendamento";
			// 
			// serviçosToolStripMenuItem
			// 
			this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
			this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.serviçosToolStripMenuItem.Text = "Serviços";
			this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.ServiçosToolStripMenuItemClick);
			// 
			// consultarToolStripMenuItem1
			// 
			this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
			this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
			this.consultarToolStripMenuItem1.Text = "Consultar";
			this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.ConsultarToolStripMenuItem1Click);
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(422, 76);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(12, 289);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(384, 73);
			this.button1.TabIndex = 2;
			this.button1.Text = "FECHAR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(98, 115);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(407, 365);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Serviços para Informática (inFOSERVICES v 1.0)";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
