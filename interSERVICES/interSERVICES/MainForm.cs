/*
 * Criado por SharpDevelop.
 * Usuário: Raphael Souza
 * Data: 01/02/2021
 * Hora: 09:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace interSERVICES
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ClienteToolStripMenuItemClick(object sender, EventArgs e)
		{
			cadClientes cad1 = new cadClientes();
			cad1.Show();
		}
		void FuncionárioToolStripMenuItemClick(object sender, EventArgs e)
		{
			CadFuncionarios cad2 = new CadFuncionarios();
			cad2.Show();
		}
		void ServiçosToolStripMenuItemClick(object sender, EventArgs e)
		{
			CadServicos cad3 = new CadServicos();
			cad3.Show();
		}
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Consultar con = new Consultar();
			con.Show();
		}
		
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("inFOSERVICES @ Copywright 2021 \n\nAutores: \nRaphael Souza, \n Michel Santos, \n Athaylson, \n Jhon. \n\nwww.infoservices.com");
		}
		
		void ConsultarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Consultar con = new Consultar();
			con.Show();
		}
	}
}
