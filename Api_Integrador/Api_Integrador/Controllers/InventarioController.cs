using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiCustomer.Models;//se pone el using el nombre del proyecto y su modelos
using RNConexion.ISSC211.DataAbstractionLayer;
using RNConexion.ISSC211.DataStorageLayer;
using System.Data;
using Newtonsoft.Json;

namespace apiCustomer.Controllers
{
    public class InventarioController : ApiController
    {
        // GET: api/Customer
        public IEnumerable<Inventario> Get()//se pone el tipo CustomerModel o la clase que se va a enviar
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.consultaInventario", System.Data.CommandType.StoredProcedure);
            DataTable table = conexion.ReturnTable();
            return turnTableToInventario(table);
        }
        public IEnumerable<Inventario> turnTableToInventario(DataTable table)
        {
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
            return listaObj;
        }
        // GET: api/Customer/5
        public IEnumerable<Inventario> Get(int id)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.consultaPorID", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@id", System.Data.ParameterDirection.Input, enumTipo.Entero, id);
            DataTable table = conexion.ReturnTable();
            return turnTableToInventario(table);
        }
        public IEnumerable<Inventario> Get(string codigo)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.consultaPorCodigo", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@codigo", System.Data.ParameterDirection.Input, enumTipo.Cadena, codigo);
            DataTable table = conexion.ReturnTable();
            return turnTableToInventario(table);
        }

        // POST: api/Customer
        public void Post(Inventario inventario)//INSERT 
        {
            
        }

        // PUT: api/Customer/5
        public void Put(int id, Object inventario)//UPDATE 
        {

        }
        // DELETE: api/Customer/5
        public void Delete(string id)//Bajas
        {
           
        }
    }
}
