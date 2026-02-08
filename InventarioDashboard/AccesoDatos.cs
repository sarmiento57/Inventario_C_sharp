using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioDashboard
{
    public class AccesoDatos
    {
        SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Inventario;Data Source=localhost\\SQLEXPRESS");

        #region Categoria
        public void InsertarCategoria(Categoria categoria)
        {
            try
            {
                conexion.Open();
                string query = @"
                                INSERT INTO Categoria (NombreCategoria) VALUES (@NombreCategoria)
                                ";

                SqlParameter nombre = new SqlParameter("@NombreCategoria", categoria.NombreCategoria);

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.Add(nombre);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Categoria> GetCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                conexion.Open();
                string query = "SELECT IdCategoria, NombreCategoria FROM Categoria";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        IdCategoria = int.Parse(reader["IdCategoria"].ToString()),
                        NombreCategoria = reader["NombreCategoria"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return categorias;
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            try
            {
                conexion.Open();
                string query = @"
                                UPDATE Categoria SET NombreCategoria = @NombreCategoria WHERE
                                IdCategoria = @IdCategoria
                                ";

                SqlParameter id = new SqlParameter("@IdCategoria", categoria.IdCategoria);
                SqlParameter nombre = new SqlParameter("@NombreCategoria", categoria.NombreCategoria);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(id);
                cmd.Parameters.Add(nombre);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void DeleteCategoria(int id)
        {
            try
            {
                conexion.Open();
                string query = "DELETE FROM Categoria WHERE IdCategoria = @id";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion

        #region Producto
        public void InsertarProducto(Producto producto)
        {
            try
            {
                conexion.Open();
                string query = @"
                                INSERT INTO Producto (CodigoProducto, NombreProducto, IdCategoria, TallaProducto, ColorProducto, PrecioUnitario, FechaIngreso, StockProducto)
                                VALUES (@CodigoProducto, @NombreProducto, @IdCategoria, @TallaProducto, @ColorProducto, @PrecioUnitario, @FechaIngreso, @StockProducto)
                                ";

                SqlParameter codigoProducto = new SqlParameter("@CodigoProducto", producto.CodigoProducto);
                SqlParameter nombreProducto = new SqlParameter("@NombreProducto", producto.NombreProducto);
                SqlParameter idCategoria = new SqlParameter("@IdCategoria", producto.IdCategoria);
                SqlParameter tallaProducto = new SqlParameter("@TallaProducto", producto.TallaProducto);
                SqlParameter colorProducto = new SqlParameter("@ColorProducto", producto.ColorProducto);
                SqlParameter precioUnitario = new SqlParameter("@PrecioUnitario", producto.PrecioUnitario);
                SqlParameter fechaIngreso = new SqlParameter("@FechaIngreso", producto.FechaIngreso.Date);
                SqlParameter stockProducto = new SqlParameter("@StockProducto", producto.StockProducto);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(codigoProducto);
                cmd.Parameters.Add(nombreProducto);
                cmd.Parameters.Add(idCategoria);
                cmd.Parameters.Add(tallaProducto);
                cmd.Parameters.Add(colorProducto);
                cmd.Parameters.Add(precioUnitario);
                cmd.Parameters.Add(fechaIngreso);
                cmd.Parameters.Add(stockProducto);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Producto> GetProductos(string buscar = null)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                conexion.Open();
                string query = @"
                                SELECT IdProducto, CodigoProducto, NombreProducto, IdCategoria, TallaProducto, ColorProducto, PrecioUnitario, FechaIngreso, StockProducto
                                FROM Producto
                                ";

                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @"WHERE CodigoProducto LIKE @buscar OR IdCategoria LIKE @buscar";
                    cmd.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }
                cmd.CommandText = query;
                cmd.Connection = conexion;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        CodigoProducto = reader["CodigoProducto"].ToString(),
                        NombreProducto = reader["NombreProducto"].ToString(),
                        IdCategoria = int.Parse(reader["IdCategoria"].ToString()),
                        TallaProducto = reader["TallaProducto"].ToString(),
                        ColorProducto = reader["ColorProducto"].ToString(),
                        PrecioUnitario = decimal.Parse(reader["PrecioUnitario"].ToString()),
                        FechaIngreso = (DateTime)reader["FechaIngreso"],
                        StockProducto = int.Parse(reader["StockProducto"].ToString())
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return productos;
        }

        public void UpdateProducto(Producto producto)
        {
            try
            {
                conexion.Open();
                string query = @"
                                UPDATE Producto SET 
                                CodigoProducto = @CodigoProducto, 
                                NombreProducto = @NombreProducto, 
                                IdCategoria = @IdCategoria, 
                                TallaProducto = @TallaProducto, 
                                ColorProducto = @ColorProducto, 
                                PrecioUnitario = @PrecioUnitario, 
                                FechaIngreso = @FechaIngreso, 
                                StockProducto = @StockProducto
                                WHERE IdProducto = @IdProducto
                                ";

                SqlParameter idProducto = new SqlParameter("@IdProducto", producto.IdProducto);
                SqlParameter codigoProducto = new SqlParameter("@CodigoProducto", producto.CodigoProducto);
                SqlParameter nombreProducto = new SqlParameter("@NombreProducto", producto.NombreProducto);
                SqlParameter idCategoria = new SqlParameter("@IdCategoria", producto.IdCategoria);
                SqlParameter tallaProducto = new SqlParameter("@TallaProducto", producto.TallaProducto);
                SqlParameter colorProducto = new SqlParameter("@ColorProducto", producto.ColorProducto);
                SqlParameter precioUnitario = new SqlParameter("@PrecioUnitario", producto.PrecioUnitario);
                SqlParameter fechaIngreso = new SqlParameter("@FechaIngreso", producto.FechaIngreso.Date);
                SqlParameter stockProducto = new SqlParameter("@StockProducto", producto.StockProducto);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(idProducto);
                cmd.Parameters.Add(codigoProducto);
                cmd.Parameters.Add(nombreProducto);
                cmd.Parameters.Add(idCategoria);
                cmd.Parameters.Add(tallaProducto);
                cmd.Parameters.Add(colorProducto);
                cmd.Parameters.Add(precioUnitario);
                cmd.Parameters.Add(fechaIngreso);
                cmd.Parameters.Add(stockProducto);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto. " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Producto WHERE IdProducto = @id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion

        #region Movimiento
        public void InsertarMovimiento(Movimiento movimiento)
        {
            try
            {
                conexion.Open();
                string query = @"
                                INSERT INTO Movimiento (IdProducto, TipoMovimiento, CantidadMovimiento, FechaMovimiento, Observacion)
                                VALUES (@IdProducto, @TipoMovimiento, @CantidadMovimiento, @FechaMovimiento, @Observacion)
                                ";

                SqlParameter idProducto = new SqlParameter("@IdProducto", movimiento.IdProducto);
                SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimiento.TipoMovimiento);
                SqlParameter cantidadMovimiento = new SqlParameter("@CantidadMovimiento", movimiento.CantidadMovimiento);
                SqlParameter fechaMovimiento = new SqlParameter("@FechaMovimiento", movimiento.FechaMovimiento.Date);
                SqlParameter observacion = new SqlParameter("@Observacion", movimiento.Observacion);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(idProducto);
                cmd.Parameters.Add(tipoMovimiento);
                cmd.Parameters.Add(cantidadMovimiento);
                cmd.Parameters.Add(fechaMovimiento);
                cmd.Parameters.Add(observacion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Movimiento> GetMovimientos(string buscar = null)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            try
            {
                conexion.Open();
                string query = @"
                                SELECT IdMovimiento, IdProducto, TipoMovimiento, CantidadMovimiento, FechaMovimiento, Observacion
                                FROM Movimiento
                                ";

                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(buscar))
                {
                    query += @"
                              WHERE TipoMovimiento LIKE @buscar
                              ";

                    cmd.Parameters.Add(new SqlParameter("@buscar", $"%{buscar}%"));
                }

                cmd.CommandText = query;
                cmd.Connection = conexion;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    movimientos.Add(new Movimiento
                    {
                        IdMovimiento = int.Parse(reader["IdMovimiento"].ToString()),
                        IdProducto = int.Parse(reader["IdProducto"].ToString()),
                        TipoMovimiento = reader["TipoMovimiento"].ToString(),
                        CantidadMovimiento = int.Parse(reader["CantidadMovimiento"].ToString()),
                        FechaMovimiento = (DateTime)reader["FechaMovimiento"],
                        Observacion = reader["Observacion"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return movimientos;
        }

        public void UpdateMovimiento(Movimiento movimiento)
        {
            try
            {
                conexion.Open();
                string query = @"
                                UPDATE Movimiento SET 
                                IdProducto = @IdProducto, 
                                TipoMovimiento = @TipoMovimiento, 
                                CantidadMovimiento = @CantidadMovimiento, 
                                FechaMovimiento = @FechaMovimiento, 
                                Observacion = @Observacion
                                WHERE IdMovimiento = @IdMovimiento
                                ";

                SqlParameter idMovimiento = new SqlParameter("@IdMovimiento", movimiento.IdMovimiento);
                SqlParameter idProducto = new SqlParameter("@IdProducto", movimiento.IdProducto);
                SqlParameter tipoMovimiento = new SqlParameter("@TipoMovimiento", movimiento.TipoMovimiento);
                SqlParameter cantidadMovimiento = new SqlParameter("@CantidadMovimiento", movimiento.CantidadMovimiento);
                SqlParameter fechaMovimiento = new SqlParameter("@FechaMovimiento", movimiento.FechaMovimiento.Date);
                SqlParameter observacion = new SqlParameter("@Observacion", movimiento.Observacion);

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(idMovimiento);
                cmd.Parameters.Add(idProducto);
                cmd.Parameters.Add(tipoMovimiento);
                cmd.Parameters.Add(cantidadMovimiento);
                cmd.Parameters.Add(fechaMovimiento);
                cmd.Parameters.Add(observacion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar. " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void DeleteMovimiento(int id)
        {
            try
            {
                conexion.Open();
                string query = @"DELETE FROM Movimiento WHERE IdMovimiento = @id";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion

        #region Login
        public Usuario ValidarAcceso(string user, string clave)
        {
            Usuario usuario = null;

            try
            {
                conexion.Open();
                string query = @"SELECT Usuario, NombreUsuario, EmailUsuario, Rol, Clave FROM Usuario
                                WHERE Usuario = @user AND Clave = @clave
                                ";
                SqlParameter userr = new SqlParameter("@user", user);
                SqlParameter contra = new SqlParameter("@clave", clave);
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Add(userr);
                cmd.Parameters.Add(contra);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Users = reader["Usuario"].ToString(),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        EmailUsuario = reader["EmailUsuario"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return usuario;
        }
        #endregion
    }
}
