﻿/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 01/02/2021
 * Hora: 10:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interSERVICES
{
	/// <summary>
	/// Description of cadClientes.
	/// </summary>
	public partial class cadClientes : Form
	{
		public cadClientes()
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
			ConexaoMySQL cnx = new ConexaoMySQL("servicesti","root","123*Vasco*321");
			
			if(cnx.Open()){
				cnx.ExecutarQuery("INSERT INTO tbcliente (NOME, ENDERECO,TELEFONE) VALUES ('"+txtNOME.Text+"', '"+txtENDERECO.Text+"', '"+txtTELEFONE.Text+"')");
				MessageBox.Show("Cliente Cadastrado com Sucesso!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
		}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
