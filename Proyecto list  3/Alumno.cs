public class Alumno
{
    public int DNI { get; set; }
    public string NOMBRE { get; set; }
    public string APELLIDO { get; set; }
    public List<double> NOTAS { get; set; }
    public Alumno(int dni, string nombre, string apellido)
    {
        DNI = dni;
        NOMBRE = nombre;
        APELLIDO = apellido;
        NOTAS = new List<double>();
    }
    public void AgregarNota(double nota)
    {
        NOTAS.Add(nota);
    }

    public double CalcularPromedio()
    {
        if (NOTAS.Count == 0) return 0;
        return NOTAS.Average();
    }
    public override string ToString()
    {
        return $"DNI: {DNI}, Nombre: {NOMBRE}, Apellido: {APELLIDO}, Nota: {NOTAS}";
    }
}