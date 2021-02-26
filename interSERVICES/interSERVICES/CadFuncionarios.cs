/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 10:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interSERVICES
{
	/// <summary>
	/// Description of CadFuncionarios.
	/// </summary>
	public partial class CadFuncionarios : Form
	{
		public CadFuncionarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			ConexaoMySQL cnx = new ConexaoMySQL("servicesti","root","123*Vasco*321");
			
			if(cnx.Open()){
				cnx.ExecutarQuery("INSERT INTO tbfuncionarios (NOME, TELEFONE,FUNCAO) VALUES ('"+txtNOME.Text+"', '"+txtTELEFONE.Text+"', '"+txtFUNCAO.Text+"')");
				MessageBox.Show("Funcionario Cadastrado!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
		}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
