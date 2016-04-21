using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class EntidadEstudiante
    {
        private int id_estudiante;
        private string nombre;
        private string apellido;
        private string direccion;
        private int edad;
        private int id_curso;

        public int Id_estudiante
        {
            get
            {
                return id_estudiante;
            }

            set
            {
                id_estudiante = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public int Id_curso
        {
            get
            {
                return id_curso;
            }

            set
            {
                id_curso = value;
            }
        }

        public EntidadEstudiante()
        {
            Id_estudiante = int.MinValue;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            Edad = int.MinValue;
            Id_curso = int.MinValue;
        }
    }
}
