using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ApiRelacionamentos.Repository.DAO;

public class DAO
{
    string connectionString = "Server=FELIPE\\SQLEXPRESS;Database=DbRelacionamento;Integrated Security=true;TrustServerCertificate=True";

    public void Executar(string NomeProcedure)
    {
        SqlCommand comando = new SqlCommand();
        SqlConnection conexao = new SqlConnection(connectionString);

        conexao.Open();

        comando.Connection = conexao;
        comando.CommandType = System.Data.CommandType.StoredProcedure;
        comando.CommandText = NomeProcedure;

        comando.Parameters.AddWithValue("@ID_CLIENTE", 1);

        SqlDataAdapter adapter = new SqlDataAdapter(comando);
        DataTable dataTable = new DataTable();

        adapter.Fill(dataTable);

        // Exiba os resultados
        foreach (DataRow row in dataTable.Rows)
        {
            Console.WriteLine(row["Nome"]);
            Console.WriteLine(row["IdPedido"]);
        }

    }
}
