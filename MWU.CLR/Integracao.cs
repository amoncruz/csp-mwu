using System;
using System.Collections.Generic;
using System.Text;

namespace MWU.CLR
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using System.Net;
    using Microsoft.SqlServer.Server;
    using MWU.CLR;

    namespace MWU.CLR
    {
        public partial class StoredProcedures
        {

            [SqlProcedure]
            public static void IntegracaoCLR()
            {
                // Put your code here
                using (SqlConnection connection = new SqlConnection("context connection=true"))
                {
                    //connection.Open();
                    //SqlCommand command = new SqlCommand("sp_SelecionarMotoristasEVeiculosD_1", connection);
                    //SqlDataReader reader = command.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    new NWAY2MES_IdentificacaoVeiculoEMotorista()
                    //    {
                    //        Nome = reader["Nome"].ToString(),
                    //        Tipo = reader["Tipo"].ToString(),
                    //        Chave = reader["Chave"].ToString(),
                    //        Ativo = reader["Ativo"].ToString(),
                    //        Modelo = reader["Modelo"].ToString(),
                    //        Tag_Veicular = reader["Tag_Veicular"].ToString()
                    //    };

                    //    // Implementacao da fila.

                    //}
                    var wc = new WebClient();
                    var html = wc.DownloadString("https://localhost:44335/api/integracoes");
                }
            }
        }
    }

}
