using RNConexion.ISSC211.DataAbstractionLayer;
using RNConexion.ISSC211.DataStorageLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api_Integrador.Models;
using System.Data;

namespace Api_Integrador.Controllers
{
    public class InventarioController : ApiController
    {
        // GET: api/Inventario YA SIRVE
        public IEnumerable<Inventario> Get()
        {

            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("SELECT * FROM dbo.ConsultaInventarioFT()", System.Data.CommandType.Text);
            DataTable table = conexion.ReturnTable();
            List<Inventario> lstInventario = new List<Inventario>();
            Inventario objInventario = new Inventario();
            objInventario = null;
            var resultado = from tabla1 in table.AsEnumerable()
                            where (tabla1["codigo"].ToString().Contains(""))
                            orderby tabla1["NoEntrada"]
                            select new
                            {
                                NoEntrada = tabla1[0].ToString(),
                                Codigo = tabla1[1].ToString(),
                                Cantidad = tabla1[2].ToString(),
                                Categoria = tabla1[3].ToString(),
                                Observaciones = tabla1[4].ToString(),
                                FechaEntrada = tabla1[5].ToString(),
                                FechaSalida = tabla1[6].ToString(),
                                Estatus = tabla1[7].ToString(),
                            };

            foreach (var item in resultado)
            {
                objInventario = new Inventario();

                objInventario.NoEntrada = int.Parse(item.NoEntrada);
                objInventario.Codigo = item.Codigo;
                objInventario.Cantidad = int.Parse(item.Cantidad);
                objInventario.Categoria = int.Parse(item.Categoria);
                objInventario.FechaEntrada = Convert.ToDateTime(item.FechaEntrada);
                objInventario.FechaSalida = Convert.ToDateTime(item.FechaSalida);
                objInventario.Observaciones = item.Observaciones;
                objInventario.Estatus = int.Parse(item.Estatus);
                lstInventario.Add(objInventario);


            }
            conexion.Close();
            return lstInventario;
        }

        // GET: api/Inventario YA SIRVE
        public IEnumerable<Inventario> Get(int id)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.consultaPorID", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@id", System.Data.ParameterDirection.Input, enumTipo.Entero, id);
            DataTable table = conexion.ReturnTable();
            List<Inventario> listaObj = new List<Inventario>();
            Inventario objeto = new Inventario();
            foreach (DataRow Obj in table.Rows)
            {
                objeto = new Inventario();
                objeto.NoEntrada = int.Parse(Obj[0].ToString());
                objeto.Codigo = Obj[1].ToString();
                objeto.Cantidad = int.Parse(Obj[2].ToString());
                objeto.Categoria = int.Parse(Obj[3].ToString());
                objeto.FechaEntrada = (DateTime)Obj[4];
                try { objeto.FechaSalida = (DateTime)Obj[5]; }
                catch (Exception e) { }
                try { objeto.Observaciones = Obj[6].ToString(); }
                catch (Exception e) { }
                try { objeto.Estatus = int.Parse(Obj[7].ToString()); }
                catch (Exception e) { }
                listaObj.Add(objeto);
            }
            conexion.Close();
            return listaObj;
        }
         
        // GET: api/Inventario/5  YA SIRVE
        public IEnumerable<Inventario> Get(string codigo)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("SELECT * FROM dbo.ConsultaInventarioFT()", System.Data.CommandType.Text);
            DataTable table = conexion.ReturnTable();
            List<Inventario> lstInventario = new List<Inventario>();
            Inventario objInventario = new Inventario();
            objInventario = null;
            var resultado = from tabla1 in table.AsEnumerable()
                            where (tabla1["codigo"].ToString().Contains(codigo))
                            orderby tabla1["NoEntrada"]
                            select new
                            {
                                NoEntrada = tabla1[0].ToString(),
                                Codigo = tabla1[1].ToString(),
                                Cantidad = tabla1[2].ToString(),
                                Categoria = tabla1[3].ToString(),
                                Observaciones = tabla1[4].ToString(),
                                FechaEntrada = tabla1[5].ToString(),
                                FechaSalida = tabla1[6].ToString(),
                                Estatus = tabla1[7].ToString(),
                            };

            foreach (var item in resultado)
            {
                objInventario = new Inventario();

                objInventario.NoEntrada = int.Parse(item.NoEntrada);
                objInventario.Codigo = item.Codigo;
                objInventario.Cantidad = int.Parse(item.Cantidad);
                objInventario.Categoria = int.Parse(item.Categoria);
                objInventario.Observaciones = item.Observaciones;
                objInventario.FechaEntrada = Convert.ToDateTime(item.FechaEntrada);
                objInventario.FechaSalida = Convert.ToDateTime(item.FechaSalida);
                objInventario.Estatus = int.Parse(item.Estatus);
                lstInventario.Add(objInventario);


            }
            conexion.Close();
            return lstInventario;
        }

        // POST: api/Inventario YA SIRVE 
        public void Post(Inventario inventario)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.insertarInventario", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@codigo", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, inventario.Codigo);
            conexion.SetParameterProcedure("@fechaEntrada", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Date, inventario.FechaEntrada);
            conexion.SetParameterProcedure("@cantidad", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, inventario.Cantidad);
            conexion.SetParameterProcedure("@categoria", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, inventario.Categoria);
            conexion.SetParameterProcedure("@estatus", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, inventario.Estatus);
            conexion.SetParameterProcedure("@observaciones", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, inventario.Observaciones);
            conexion.ExecuteNonQuery();
            conexion.Close();
        }

        // PUT: api/Inventario/5 NO SIRVE
        public void Put( Inventario inv)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.BajaInventario", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@ID", System.Data.ParameterDirection.Input, enumTipo.Entero, inv.NoEntrada);
            try
            {
                conexion.SetParameterProcedure("@cantidad", System.Data.ParameterDirection.Input, enumTipo.Entero, inv.Cantidad);
                conexion.SetParameterProcedure("@operacion", System.Data.ParameterDirection.Input, enumTipo.Entero, 2);
            }
            catch (Exception ex)
            {
                conexion.SetParameterProcedure("@cantidad", System.Data.ParameterDirection.Input, enumTipo.Entero, inv.Cantidad);
                conexion.SetParameterProcedure("@operacion", System.Data.ParameterDirection.Input, enumTipo.Entero, 1);
                
            }
            conexion.SetParameterProcedure("@mensaje", System.Data.ParameterDirection.Output, enumTipo.Cadena, "");
            conexion.ExecuteStoredOutPut();
            conexion.Close();
        }

        // DELETE: api/Inventario/5
        public void Delete(int id)
        {
        }
    }
}
