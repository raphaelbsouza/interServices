/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 10:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interSERVICES
{
	/// <summary>
	/// Description of Consultar.
	/// </summary>
	public partial class Consultar : Form
	{
		public Consultar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			dgvCliente con1 = new dgvCliente();
			con1.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			ConFuncionarios con2 = new ConFuncionarios();
			con2.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			ConServicos con3 = new ConServicos();
			con3.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
