using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Menu
    {
        static int opcion = 0;

        static string edadmayores = "";
        static string edadmenores = "";
        static string cupo_materias = "";
        public static void menu()
        {
            int seleccion = 0;
            Console.Clear();
            Console.WriteLine(" ************ Colegio ************");
            Console.WriteLine("");
            Console.WriteLine("      1. Generar");
            Console.WriteLine("      2. Mostrar");
            Console.WriteLine("      3. Imprimir");
            Console.WriteLine("      4. Salir");
            Console.WriteLine("");
            Console.WriteLine(" **********************************");
            Console.WriteLine("    Seleccione que desea realizar ");
            Console.WriteLine(" **********************************");
            seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    generar();
                    break;
                case 2:
                    mostrar();
                    break;
                case 3:
                    imprimir();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void generar()
        {
            Modelo mod = new Modelo();
            DataTable dt = new DataTable();

            string emayor = "select count(edad)from estudiante where edad > 18";
            dt = mod.llenarDT(emayor);
            edadmayores = dt.Rows[0][0].ToString();

            string emenor = "select count(edad)from estudiante where edad < 18";
            dt = mod.llenarDT(emenor);
            edadmenores = dt.Rows[0][0].ToString();

            string cupo = "select materia.nombre, count(*) as numeroestudiantes from estudiante join materia on estudiante.id_curso = materia.id_materia group by materia.nombre";
            dt = mod.llenarDT(cupo);
            foreach (DataRow row in dt.Rows)
            {
                cupo_materias += Environment.NewLine;
                cupo_materias += "Curso: " + row[0] + " Estudiantes: " + row[1];
            }
            menu();
        }
        public static void mostrar()
        {
            Console.Clear();
            Console.WriteLine("Estudiantes mayores de edad: " + edadmayores);
            Console.WriteLine("Estudiantes menores de edad: " + edadmenores);
            Console.WriteLine("Estudiantes por materia: " + cupo_materias);
        }
        public static void imprimir()
        {

        }
    }
}
