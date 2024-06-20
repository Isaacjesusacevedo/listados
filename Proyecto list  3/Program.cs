using System;

namespace listado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            int op;
            do
            {
                Console.WriteLine("Seleccione la opción que desea realizar:");
                Console.WriteLine("1. Agregar los datos de un alumno.");
                Console.WriteLine("2. Ver el listado completo de alumnos.");
                Console.WriteLine("3. Buscar un alumno por nombre y apellido.");
                Console.WriteLine("4. Eliminar un alumno por DNI.");
                Console.WriteLine("5. Mostrar el promedio de notas.");
                Console.WriteLine("6. Salir del programa.");
                Console.WriteLine("Solo es posible usar las opciones mostradas.");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (op)
                {
                    case 1:
                        {
                            Console.Write("Ingrese el nombre del alumno: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el apellido del alumno: ");
                            string apellido = Console.ReadLine();
                            Console.Write("Ingrese el DNI del alumno: ");
                            if (int.TryParse(Console.ReadLine(), out int dni))
                            {
                                Console.Write("Ingrese la nota del alumno: ");
                                if (double.TryParse(Console.ReadLine(), out double nota))
                                {
                                    var alumno = new Alumno(dni, nombre, apellido);
                                    alumno.AgregarNota(nota);
                                    alumnos.Add(alumno);
                                    Console.WriteLine("Alumno agregado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Nota inválida.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("DNI inválido.");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Listado completo de alumnos:");
                            foreach (var alumno in alumnos)
                            {
                                Console.WriteLine(alumno);
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Ingrese el nombre del alumno a buscar: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el apellido del alumno a buscar: ");
                            string apellido = Console.ReadLine();
                            var resultado = alumnos.Where(a => a.NOMBRE == nombre && a.APELLIDO == apellido).ToList();
                            if (resultado.Any())
                            {
                                Console.WriteLine("Resultados de la búsqueda:");
                                foreach (var alumno in resultado)
                                {
                                    Console.WriteLine(alumno);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron alumnos con ese nombre y apellido.");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Ingrese el DNI del alumno a eliminar: ");
                            if (int.TryParse(Console.ReadLine(), out int dni))
                            {
                                var alumnoAEliminar = alumnos.FirstOrDefault(a => a.DNI == dni);
                                if (alumnoAEliminar != null)
                                {
                                    alumnos.Remove(alumnoAEliminar);
                                    Console.WriteLine("Alumno eliminado correctamente.");
                                }

                                else
                                {
                                    Console.WriteLine("No se encontró un alumno con ese DNI.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("DNI invalido.");
                            }
                        }
                        break;
                    case 5:
                        {
                            if (alumnos.Any())
                            {
                                double promedioGeneral = alumnos.Average(a => a.CalcularPromedio());
                                Console.WriteLine($"El promedio general de notas es: {promedioGeneral}");
                            }
                            else
                            {
                                Console.WriteLine("No hay alumnos en la lista.");
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("No vuelva.");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 6.");
                        }
                        break;
                }
            } while (op != 6);
        }
    }
}