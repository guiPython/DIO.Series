using System;
using Interfaces;
using System.Collections.Generic;

namespace Service
{
    public class QueryService{
        private IRepository<IEntitie> _repository;
        private IConsole<IEntitie> _console;

        public QueryService (IRepository<IEntitie> repository, IConsole<IEntitie> console){
            _repository = repository;
            _console = console;
        }

        public void Insert(){
            Console.WriteLine("-------------- Inserindo Item -------------- ");
            IEntitie entitie = _console.Read();
            _repository.Insert(entitie);
        }

        public void Update(){
            Console.WriteLine("-------------- Atualizando Item -------------- ");
            Console.Write("Digite o Id da Atualização: ");
            int id = int.Parse(Console.ReadLine()) - 1;

            IEntitie entitie = _console.Read();
            _repository.Update(id,entitie);
        }

        public void Select(){
            Console.WriteLine("-------------- Buscando Item -------------- ");
            Console.WriteLine("1 - Buscar Todos \n2 - Buscar por Id");

            int filtro = int.Parse(Console.ReadLine());
            

            if(filtro == 1){
                List<IEntitie> entities = _repository.Table();
                if (entities != null) entities.ForEach(e => Console.WriteLine(e));
            }

            else if (filtro  == 2){
                Console.Write("Digite o Id da Busca: ");
                int id = int.Parse(Console.ReadLine()) - 1;

                IEntitie entitie = _repository.Select(id);
                if (entitie != null) Console.WriteLine(entitie);
            }

            else throw new NullReferenceException();
            
        }

        public void Delete(){
            Console.WriteLine("-------------- Deletando Item -------------- ");
            Console.Write("Digite o Id da Deleção: ");
            int id = int.Parse(Console.ReadLine()) - 1;

            _repository.Delete(id);
        }
    }
}