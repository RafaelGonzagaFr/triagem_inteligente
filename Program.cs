class Program
{
    static void Main(String[] args)
    {
        List<string> pacientes = new List<string>();
        AdicionarPaciente(pacientes, "Rafael");
        foreach(string paciente in pacientes)
        {
            Console.WriteLine(paciente);
        }
    }

    private static void AdicionarPaciente(List<string> pacientes, String nome)
    {
        pacientes.Add(nome);
    }
}