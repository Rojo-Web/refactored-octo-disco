using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProductosRepository : BaseRepository, IProductosRepository
    {
        
        public ProductosRepository(string connectionString)
        {
            this.connectionString = connectionString;
            FeedComboBoxCategorias();
        }

        

        public void add(ProductosModel productosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Productos VALUES (@name, @precio, @stock, @id_categoria)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productosModel.Name;
                command.Parameters.Add("@precio", SqlDbType.Int).Value = productosModel.Precio;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productosModel.Stock;
                command.Parameters.Add("@id_categoria", SqlDbType.Int).Value = productosModel.Categoria;
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
                command.CommandText = "DELETE FROM Productos WHERE Producto_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void edit(ProductosModel productosModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Productos SET Producto_Name = @name, Producto_Precio = @precio, Producto_Stock = @stock" +
                    " WHERE Producto_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productosModel.Name;
                command.Parameters.Add("@precio", SqlDbType.Int).Value = productosModel.Precio;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productosModel.Stock;
                //command.Parameters.Add("@id_categoria", SqlDbType.Int).Value = productosModel.Categoria;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productosModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductosModel> GetAll()
        {
            var productosList = new List<ProductosModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Productos ORDER BY Producto_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productosModel = new ProductosModel();
                        productosModel.Id = (int)reader["Producto_Id"];
                        productosModel.Name = reader["Producto_Name"].ToString();
                        productosModel.Precio = Convert.ToInt32(reader["Producto_Precio"]);
                        productosModel.Stock = Convert.ToInt32(reader["Producto_Stock"]);
                        productosModel.Categoria = Convert.ToInt32(reader["Categoria_Id"]);
                        productosList.Add(productosModel);
                    }
                }
            }
            
            return productosList;
        }

        public void FeedComboBoxCategorias()
        {
            ProductosView.comboCategorias.Items.Clear();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorias";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetInt32("Categoria_Id") + "  -  " + reader.GetString("Categoria_Name");
                        ProductosView.comboCategorias.Items.Add(item);
                    }
                }
            }

        }
            public IEnumerable<ProductosModel> GetByValue(string value)
        {
            var productosList = new List<ProductosModel>();
            int productoId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productoName = value;
            string productoPrecio = value;
            string productoStock = value;
            string productoCategoria = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Productos
                                        WHERE Producto_Id = @id or Producto_Name LIKE @name + '%' or Producto_Precio = @precio or Producto_Stock = @stock
                                        ORDER By Producto_Id DESC";
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = productoId;
                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = productoName;
                command.Parameters.Add("@precio", SqlDbType.Int).Value = productoPrecio;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productoStock;
                //command.Parameters.Add("@id_categoria", SqlDbType.Int).Value = productoCategoria;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productosModel = new ProductosModel();
                        productosModel.Id = (int)reader["Producto_Id"];
                        productosModel.Name = reader["Producto_Name"].ToString();
                        productosModel.Precio = Convert.ToInt32(reader["Producto_Precio"]);
                        productosModel.Stock = Convert.ToInt32(reader["Producto_Stock"]);
                        productosModel.Categoria = Convert.ToInt32(reader["Categoria_Id"]);
                        productosList.Add(productosModel);
                    }
                }
            }
            return productosList;
        }

    }
}
