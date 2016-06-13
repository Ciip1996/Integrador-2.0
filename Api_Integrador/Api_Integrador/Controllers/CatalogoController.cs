using Api_Integrador.Models;
using RNConexion.ISSC211.DataAbstractionLayer;
using RNConexion.ISSC211.DataStorageLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using System.Xml.Linq;

namespace Api_Integrador.Controllers
{
    public class CatalogoController : ApiController
    {
        // GET: api/Catalogo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Catalogo/5
        public string Get(int id)
        {
            return "dd";
        }

        // POST: api/Catalogo
        public void Post(Catalogo catalogo)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.insertarCatalogo", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@Codigo", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, catalogo.Codigo);
            conexion.SetParameterProcedure("@Estilo", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, catalogo.Estilo);
            conexion.SetParameterProcedure("@Descripcion", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, catalogo.Descripcion);
            conexion.SetParameterProcedure("@marca", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, catalogo.Marca);
            conexion.SetParameterProcedure("@PrecioCompra", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, catalogo.PrecioCompra);
            conexion.SetParameterProcedure("@PrecioVenta", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, catalogo.PrecioVenta);
            conexion.SetParameterProcedure("@Estatus", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, catalogo.Estatus);
            conexion.ExecuteNonQuery();
            conexion.Close();
        }

        // PUT: api/Catalogo/5
        public void Put(int id, Catalogo c)
        {
            // public void Put(string codigo, int cantidad, int operacion)//BAJA CATALOGO

            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.BajaCatalogo", System.Data.CommandType.StoredProcedure);
           // conexion.SetParameterProcedure("@codigo", System.Data.ParameterDirection.Input, enumTipo.Cadena, codigo);
           // conexion.SetParameterProcedure("@mensaje", System.Data.ParameterDirection.Output, enumTipo.Cadena, "");
            conexion.ExecuteStoredOutPut();
            conexion.Close();
        }

        // DELETE: api/Catalogo/5
        public void Delete(int id)
        {
        }
    }
}
