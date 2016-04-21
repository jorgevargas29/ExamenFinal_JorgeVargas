using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ControladorProfesor
    {
        Modelo mod = new Modelo();
        EntidadProfesor entidad = new EntidadProfesor();
        string sql;

        public DataTable leer()
        {
            sql = "select "
                + "id_profesor,"
                + "nombre,"
                + "apellido"
                + " from "
                + "profesor";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "select "
                + "id_profesor,"
                + "nombre,"
                + "apellido"
                + " from "
                + "profesor"
                + " where "
                + "id_profesor = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadProfesor entidad)
        {
            sql = "insert into profesor ("
                + "id_profesor,"
                + "nombre,"
                + "apellido"
                + ") VALUES ("
                + entidad.Id_profesor + ","
                + "'" + entidad.Nombre+ "',"
                + "'" + entidad.Apellido + "'"
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadProfesor entidad)
        {
            sql = "update profesor set "
                + "nombre ='" + entidad.Nombre + "',"
                + "apellido = '" + entidad.Apellido + "'"
                + " where "
                + "id_profesor = " + entidad.Id_profesor;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "delete profesor "
                + "where "
                + "id_profesor = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
