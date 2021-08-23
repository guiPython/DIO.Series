using System;
using Enums;
using Entities;
using Interfaces;

namespace Screens
{
    public class SeriesConsole : IConsole<IEntitie>
    {
        private readonly IRepository<IEntitie> _repository;
        public SeriesConsole(IRepository<IEntitie> repository)
        {
            _repository = repository;
        }
        public IEntitie Read()
        {
            Console.WriteLine("-------------- Lendo Série -------------- ");
            Console.Write("Título da Série: ");
            String title = Console.ReadLine();

            int category;
            while (true)
            {
                try
                {
                    Console.WriteLine("Gênero da Série: ");
                    foreach (int i in Enum.GetValues<Category>())
                    {
                        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Category), i));
                    }
                    Console.Write("Digite uma das opções acima: ");
                    category = int.Parse(Console.ReadLine());
                    if (Enum.GetName(typeof(Enums.Category), category) == null) throw new NullReferenceException();
                    break;

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Insira uma Categoria Válida.");
                }
                catch (FormatException){
                     Console.WriteLine("Insira uma Categoria Válida.");
                }
            }


            Console.Write("Descrição da Série: ");
            String description = Console.ReadLine();

            int year;
            while (true)
            {
                Console.Write("Ano de lançamento da Série: ");

                try{
                    year = int.Parse(Console.ReadLine());
                    break;
                }catch(FormatException){
                    Console.WriteLine("Insira um Ano Válido.");
                }
            }
            

            return new Series(id: _repository.Id(), title, (Category)category, description, year);
        }
    }
}