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
    internal class ProveedoresRepository : BaseRepository, IProveedoresRepository
    {

        public ProveedoresRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void add(ProveedoresModel proveedorModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Proveedores VALUES (@name, @descripcion)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = proveedorModel.Name;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = proveedorModel.Descripcion;
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
                command.CommandText = "DELETE FROM Proveedores WHERE Proveedor_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void edit(ProveedoresModel proveedorModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Proveedores SET Proveedor_Name = @name, Proveedor_Descripcion = @descripcion" +
                    " WHERE Proveedor_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = proveedorModel.Name;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = proveedorModel.Descripcion;
                command.Parameters.Add("@id", SqlDbType.Int).Value = proveedorModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProveedoresModel> GetAll()
        {
            var proveedorList = new List<ProveedoresModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Proveedores ORDER BY Proveedor_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var proveedorModel = new ProveedoresModel();
                        proveedorModel.Id = (int)reader["Proveedor_Id"];
                        proveedorModel.Name = reader["Proveedor_Name"].ToString();
                        proveedorModel.Descripcion = reader["Proveedor_Descripcion"].ToString();
                        proveedorList.Add(proveedorModel);
                    }
                }
            }
            return proveedorList;
        }

        public IEnumerable<ProveedoresModel> GetByValue(string value)
        {
            var proveedorList = new List<ProveedoresModel>();
            int proveedorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string proveedorName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Proveedores
                                        WHERE Proveedor_Id = @id or Proveedor_Name LIKE @name + '%'
                                        ORDER By Proveedor_Id DESC";
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = proveedorId;
                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = proveedorName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var proveedorModel = new ProveedoresModel();
                        proveedorModel.Id = (int)reader["Proveedor_Id"];
                        proveedorModel.Name = reader["Proveedor_Name"].ToString();
                        proveedorModel.Descripcion = reader["Proveedor_Descripcion"].ToString();
                        proveedorList.Add(proveedorModel);
                    }
                }
            }
            return proveedorList;
        }
    }
}
