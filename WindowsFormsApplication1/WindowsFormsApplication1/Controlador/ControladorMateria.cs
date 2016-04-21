using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ControladorMateria
    {
        Modelo mod = new Modelo();
        EntidadMateria entidad = new EntidadMateria();
        string sql;

        public DataTable leer()
        {
            sql = "select "
                + "id_materia,"
                + "nombre,"
                + "id_profesor"
                + " from "
                + "materia";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "select "
                + "id_materia,"
                + "nombre,"
                + "id_profesor"
                + " from "
                + "materia"
                + " where "
                + "id_materia = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadMateria entidad)
        {
            sql = "insert into materia ("
                + "id_materia,"
                + "nombre,"
                + "id_profesor"
                + ") VALUES ("
                + entidad.Id_materia + ","
                + "'" + entidad.Nombre + "',"
                + entidad.Id_profesor
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadMateria entidad)
        {
            sql = "update materia set "
                + "nombre ='" + entidad.Nombre + "',"
                + "id_profesor = " + entidad.Id_profesor
                + " where "
                + "id_materia = " + entidad.Id_materia;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "delete materia "
                + "where "
                + "id_materia = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
