using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApplication1
{
    public class ControladorEstudiante
    {
        Modelo mod = new Modelo();
        EntidadEstudiante entidad = new EntidadEstudiante();
        string sql;

        public DataTable leer()
        {
            sql = "select "
                + "id_estudiante,"
                + "nombre,"
                + "apellido,"
                + "direccion,"
                + "edad,"
                + "id_curso"
                + " from "
                + "estudiante";
            return mod.llenarDT(sql);
        }

        public DataTable buscar(int id)
        {
            sql = "select "
                + "id_estudiante,"
                + "nombre,"
                + "apellido,"
                + "direccion,"
                + "edad,"
                + "id_curso"
                + " from "
                + "estudiante"
                + " where "
                + "id_estudiante = " + id;
            return mod.llenarDT(sql);
        }

        public void insertar(EntidadEstudiante entidad)
        {
            sql = "insert into estudiante ("
                + "id_estudiante,"
                + "nombre,"
                + "apellido,"
                + "direccion,"
                + "edad,"
                + "id_curso"
                + ") VALUES ("
                + entidad.Id_estudiante + ","
                + "'" + entidad.Nombre + "',"
                + "'" + entidad.Apellido + "',"
                + "'" + entidad.Direccion + "',"
                + "" + entidad.Edad + ","
                + entidad.Id_curso
                + ")";
            mod.ejecutarSQL(sql);
        }

        public void modificar(EntidadEstudiante entidad)
        {
            sql = "update estudiante set "
                + "nombre ='" + entidad.Nombre + "',"
                + "apellido = '" + entidad.Apellido + "',"
                + "direccion = '" + entidad.Direccion + "',"
                + "edad = " + entidad.Edad + ","
                 + "id_curso = " + entidad.Id_curso
                + " where "
                + "id_estudiante = " + entidad.Id_estudiante;
            mod.ejecutarSQL(sql);
        }

        public void eliminar(int id)
        {
            sql = "delete estudiante "
                + "where "
                + "id_estudiante = " + id;
            mod.ejecutarSQL(sql);
        }
    }
}
