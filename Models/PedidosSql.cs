using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlConnector;
using Atividade03.Models;

namespace Atividade03.Models
{
    public class PedidosSql
    {
        private const string dados = "DataBase=hungryburguer; Data Source=localhost; User Id=root;";
         public void cadastrar(Pedidos pedido){
            MySqlConnection con = new MySqlConnection(dados);
            con.Open();
            string query = "INSERT INTO pedidos(Nome, Endereço, Lanche, Bebida, Pag) VALUES (@nome, @endereço, @lanche, @bebida, @pag)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome",pedido.Nome);
            cmd.Parameters.AddWithValue("@endereço", pedido.Endereço);
            cmd.Parameters.AddWithValue("@lanche", pedido.Lanche);
            cmd.Parameters.AddWithValue("@bebida", pedido.Bebida);
            cmd.Parameters.AddWithValue("@pag", pedido.Pag);
            cmd.ExecuteNonQuery();
            con.Close();
        }
          public List<Pedidos> Listar(){
            MySqlConnection con = new MySqlConnection(dados);
            con.Open();
            string query = "SELECT * FROM pedidos ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
              List<Pedidos> lista = new List<Pedidos>();
            
            while(reader.Read()){
                Pedidos Usuariosco = new Pedidos();
                Usuariosco.Id = reader.GetInt32("Id");
                if(reader.IsDBNull(reader.GetOrdinal("Nome")));
                Usuariosco.Nome = reader.GetString("Nome");
                if(reader.IsDBNull(reader.GetOrdinal("Endereço")));
                Usuariosco.Endereço = reader.GetString("Endereço");
                  if(reader.IsDBNull(reader.GetOrdinal("Lanche")));
                Usuariosco.Lanche = reader.GetString("Lanche");
                  if(reader.IsDBNull(reader.GetOrdinal("Bebida")));
                Usuariosco.Bebida = reader.GetString("Bebida");
                  if(reader.IsDBNull(reader.GetOrdinal("Pag")));
                Usuariosco.Pag = reader.GetString("Pag");
                lista.Add(Usuariosco);    
            
            }
           
            con.Close();
            return lista;
    }
  }
}