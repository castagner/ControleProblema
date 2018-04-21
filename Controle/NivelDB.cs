using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class NivelDB
    {

        private DB db;

        public bool insert(Nivel nivel)
        {

            try
            {

                string sql = "INSERT INTO TB_NIVEL (DESCRICAO)" +
                    "VALUES (' " + nivel.Descricao + "')";

                using (db = new DB())
                {

                    db.ExecutaComando(sql);
                }

            }

            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<Nivel> ListarNivel()
        {

            using (db = new DB()) //Instancia a clase DB
                                  //Delimitando o inicio e o fim
                                  //Inicio > Construtor da classe
                                  //Abre a conexao com a base de dados
                                  //Fim > Chama o método Dispose()
                                  //Interface (IDisposable)
                                  //Fecha a conexao com o banco de dados
            {


                var sql = "Select id, descricao From TB_NIVEL";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);


            }


        }


        private List<Nivel> TransformaSQLReaderEmList
            (SqlDataReader retorno)
        {

            var listNivel = new List<Nivel>();
            while (retorno.Read())
            {

                var item = new Nivel()
                {

                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),

                };

                listNivel.Add(item);
            }

            return listNivel;
        }

    }
}
