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
    public class EmpleadoController : ApiController
    {
        // GET: api/Empleado
        public IEnumerable<String> Get()
        {
            List<String> listaEmpleado = new List<String>();
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            //bool cn = conexion.Open("Data Source=#IPAQUI#\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.traerListaEmpleados", System.Data.CommandType.StoredProcedure);
            //conexion.SetParameterProcedure("@Nombre", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, "Ivan");
            conexion.SetParameterProcedure("@Resultado", System.Data.ParameterDirection.ReturnValue, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.XML, "");
            XmlReader xmlr = conexion.ExecuteXMLReader();
            XDocument XDocEsquema = XDocument.Load(xmlr);
            var CursorCredenciales = from Valores in XDocEsquema.Descendants("Empleado") select Valores;
            foreach (var Obj in CursorCredenciales)
            {
                string nombre = Obj.Element("nombre").Value.ToString();
                listaEmpleado.Add(nombre);
            }
            return listaEmpleado;
        }
        // GET: api/Empleado/5
        public IEnumerable<Empleado> Get(int pId)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.traerEmpleado", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@id", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, pId);
            conexion.SetParameterProcedure("@Resultado", System.Data.ParameterDirection.ReturnValue, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.XML, "");
            XmlReader xmlr = conexion.ExecuteXMLReader();
            XDocument XDocEsquema = XDocument.Load(xmlr);
            List<Empleado> ListaEmpleado = new List<Empleado>();
            Empleado empleado = new Empleado();
            var CursorCredenciales = from Valores in XDocEsquema.Descendants("Empleado") select Valores;
            foreach (var Obj in CursorCredenciales)
            {
                empleado = new Empleado();
                empleado.IdEmpleado = int.Parse(Obj.Element("idEmpleado").Value.ToString());
                empleado.Nombre = Obj.Element("nombre").Value.ToString();
                empleado.Estatus = int.Parse(Obj.Element("estatus").Value.ToString());
                empleado.Puesto = int.Parse(Obj.Element("puesto").Value.ToString());
                empleado.FechaIngreso = Convert.ToDateTime(Obj.Element("fechaIngreso").Value.ToString());
                empleado.FechaEgreso = Convert.ToDateTime(Obj.Element("fechaEgreso").Value.ToString());
                empleado.Contraseña = Obj.Element("contraseña").Value.ToString();
                ListaEmpleado.Add(empleado);
            }
            conexion.Close();
            return ListaEmpleado;
        }
        // POST: api/Empleado
        public void Post(Empleado empleado)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.insertarEmpleado", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@Nombre", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Nombre);
            conexion.SetParameterProcedure("@Puesto", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, empleado.Puesto);
            conexion.SetParameterProcedure("@Contraseña", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Contraseña);
            conexion.SetParameterProcedure("@Pregunta", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Pregunta);
            conexion.SetParameterProcedure("@Respuesta", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Respuesta);
            conexion.ExecuteNonQuery();
            conexion.Close();
        }
        // PUT: api/Empleado/5
        public void Put(Empleado empleado)
        {
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source=DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.modificarEmpleado", System.Data.CommandType.StoredProcedure);
            conexion.SetParameterProcedure("@id", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, empleado.IdEmpleado);
            conexion.SetParameterProcedure("@Nombre", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Nombre);
            conexion.SetParameterProcedure("@Puesto", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, empleado.Puesto);
            conexion.SetParameterProcedure("@Contraseña", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Contraseña);
            conexion.SetParameterProcedure("@Pregunta", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Pregunta);
            conexion.SetParameterProcedure("@Respuesta", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Cadena, empleado.Respuesta);
            conexion.SetParameterProcedure("@FechaIngreso", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Date, empleado.FechaIngreso);
            conexion.SetParameterProcedure("@FechaEgreso", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Date, empleado.FechaEgreso);
            conexion.SetParameterProcedure("@Estatus", System.Data.ParameterDirection.Input, RNConexion.ISSC211.DataAbstractionLayer.enumTipo.Entero, empleado.Estatus);
            conexion.ExecuteNonQuery();
            conexion.Close();
        }
        // DELETE: api/Empleado/5
        public void Delete(int id)
        {
        }
    }
}
