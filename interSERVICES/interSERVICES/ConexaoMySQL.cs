﻿/*
 * Created by SharpDevelop.
 * User: Rafael Gomes
 * Date: 20/01/2021
 * Time: 00:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace interSERVICES
{
	/// <summary>
	/// Description of ConexaoMySQL.
	/// </summary>
	public class ConexaoMySQL
	{
		//String de Conexão
		private string strCnx = "";
		//Conexão com o MySQL
		private MySqlConnection bdConn;
		//Estado da conexão
		public bool Conectado = false;
		
		
		public ConexaoMySQL(string database, string user, string password, string server = "localhost")
		{
			strCnx = 
				"server="+server+";"+     //Localização do Servidor (IP, por exemplo)
				"database="+database+";"+ //Nome da database(schema)
				"uid="+user+";"+          //Usuário
				"pwd='"+password+"'";	  //Senha			
		}
		
		public bool Open(){
			//Define String de Conexão
			bdConn = new MySqlConnection(strCnx);
			
			//Tenta Abrir conexão com o MySQL
			try{
				bdConn.Open();
				Conectado = true;
			}
			catch{
				Conectado = false;
			}
			return Conectado;
		}
		
		public DataTable ExecutarQuery(string ComandoSQL){
			//ExecutarQuery retorna DataTable
			if (Conectado){
				//Armazena Comando SQL
				MySqlCommand cmd = new MySqlCommand(ComandoSQL,bdConn);
				
				//Cria uma DataTable
				DataTable dT = new DataTable();
				
				//Interface de Dados
				MySqlDataAdapter dA = new MySqlDataAdapter(cmd);
				
				//Armazena dados da interface no datatable
				dA.Fill(dT);
				
				//Preenche com os dados do Datatable
				return dT;
			}
			
			return null;
		}
	}
}