using System;
using Factories;
using Service;

namespace DIO.Series
{
    class Program
    {
        private static QueryFactory _queryFactory = new QueryFactory();
        private static ConsoleKey _key;
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Bem Vindo ----------------");
            while (true)
            {
                try
                {

                    Console.WriteLine("Digite uma das opções abaixo:");
                    foreach (int i in Enum.GetValues<Enums.Entitie>())
                    {
                        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Enums.Entitie), i));
                    }

                    Console.WriteLine("Q - Sair");
                    _key = Console.ReadKey().Key;
                    if (_key.Equals(ConsoleKey.Q)) break;

                    int entitie = int.Parse(Console.ReadLine());
                    QueryService queryService = _queryFactory.Factory(Enum.GetName(typeof(Enums.Entitie), entitie));

                    while (true)
                    {
                        Console.WriteLine("---------------- {0} ----------------", Enum.GetName(typeof(Enums.Entitie), entitie));
                        foreach (int i in Enum.GetValues<Enums.Query>())
                        {
                            Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Enums.Query), i));
                        }

                        int query = int.Parse(Console.ReadLine());

                        try
                        {
                            String queryString = Enum.GetName(typeof(Enums.Query), query);

                            if (queryString == "INSERT") queryService.Insert();
                            else if (queryString == "SELECT") queryService.Select();
                            else if (queryString == "UPDATE") queryService.Update();
                            else queryService.Delete();

                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("Digite uma opção de query válida.");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Digite uma opção de query válida.");
                        }
                        Console.WriteLine("Precione qualquer tecla para continuar.");
                        Console.WriteLine("Q - Sair");
                        _key = Console.ReadKey().Key;

                        if (_key.Equals(ConsoleKey.Q)) break;
                        Console.Clear();
                    }

                    Console.WriteLine("\nQ - Sair");
                    _key = Console.ReadKey().Key;

                    if (_key.Equals(ConsoleKey.Q)) break;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Digite uma opção de entidade válida.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite uma opção de entidade válida.");
                }
            }
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar este programa.\nBy: guiPython");
        }
    }
}
