using System;
using Interfaces;
using Repository;
using Service;
using Screens;

namespace Factories{
    public class QueryFactory {
        private IRepository<IEntitie> _repository;
        private IConsole<IEntitie> _console;
        public QueryService Factory(String type){
            if (type.Equals("Séries")){
                
                _repository = new SeriesRepository();
                _console = new SeriesConsole(_repository);
                
            }
            else{
                throw new NotImplementedException("Query Factory falhou em instanciar.");
            }   
            return new QueryService(_repository, _console);
        }
    }
}