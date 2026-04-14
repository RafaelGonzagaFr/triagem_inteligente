class Program
{
    static void Main(String[] args)
    {
        List<string> pacientes = new List<string>();
        bool sair = false;
        string? entrada;
        int escolha;
        while (!sair)
        {
            Menu();
            entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out escolha))
            {
                Console.WriteLine("Escolha inválida");
                continue;
            }
            switch (escolha)
            {
                case 1:
                    while (true)
                    {
                        string? nome;
                        Console.WriteLine("Nome do paciente: ");
                        nome = Console.ReadLine();
                        if(nome == null || nome.Length < 3)
                        {
                            Console.WriteLine("Digite um valor válido\n No mínimo 3 caractéres");
                            continue;
                        }
                        AdicionarPaciente(pacientes, nome);
                        break;
                    }
                    break;
                case 2:
                    VerListaDePaciente(pacientes);
                    break;
            }
        }
        
    }

    private static void AdicionarPaciente(List<string> pacientes, String nome)
    {
        pacientes.Add(nome);
    }

    private static void VerListaDePaciente(List<string> pacientes)
    {
        foreach(string paciente in pacientes)
        {
            Console.WriteLine(paciente);
        }
    }

    private static void Menu()
    {
        Console.WriteLine("1 - Chegada de novo paciente");
        Console.WriteLine("2 - Ver lista de pacientes");
    }
}