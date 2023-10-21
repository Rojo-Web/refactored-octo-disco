using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategoriaRepository : BaseRepository, ICategoriaRepository
    {

        public CategoriaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void add(CategoriasModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categorias VALUES (@name, @descripcion)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaModel.Name;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = categoriaModel.Descripcion;
                command.ExecuteNonQuery();
            }
        }

        public void delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categorias WHERE Categoria_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void edit(CategoriasModel categoriaModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Categorias SET Categoria_Name = @name, Categoria_Descripcion = @descripcion" +
                    " WHERE Categoria_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriaModel.Name;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = categoriaModel.Descripcion;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriaModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriasModel> GetAll()
        {
            var categoriaList = new List<CategoriasModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorias ORDER BY Categoria_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaModel = new CategoriasModel();
                        categoriaModel.Id = (int)reader["Categoria_Id"];
                        categoriaModel.Name = reader["Categoria_Name"].ToString();
                        categoriaModel.Descripcion = reader["Categoria_Descripcion"].ToString();
                        categoriaList.Add(categoriaModel);
                    }
                }
            }
            return categoriaList;
        }

        public IEnumerable<CategoriasModel> GetByValue(string value)
        {
            var categoriaList = new List<CategoriasModel>();
            int categoriaId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriaName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categorias
                                        WHERE Categoria_Id = @id or Categoria_Name LIKE @name + '%'
                                        ORDER By Categoria_Id DESC";
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = categoriaId;
                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = categoriaName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriaModel = new CategoriasModel();
                        categoriaModel.Id = (int)reader["Categoria_Id"];
                        categoriaModel.Name = reader["Categoria_Name"].ToString();
                        categoriaModel.Descripcion = reader["Categoria_Descripcion"].ToString();
                        categoriaList.Add(categoriaModel);
                    }
                }
            }
            return categoriaList;
        }
    }
}
