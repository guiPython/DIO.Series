# DIO.Series
Projeto de gerenciamento de séries em memória
Projeto para gerenciamento de séries na memória.

Modelei o projeto com classes de Factory, Service, Screen e as duas outras classes propostas Entitie e Repository.



Basicamente tenho uma classe chamada QueryService que faz as operações de CRUD, utilizei injeção de dependências nela, com isso consigo ler as entidades pela interface IConsole e trabalhar com a persistência dos dados na memória com a IRepository.



A Factory gera a instância da QueryService com as respectivas classes Screen que implementa IConsole e Repository que implementa IRepository, a classe Factory é chamada na main onde pode ser escolhida a entidade que vamos realizar as operações de CRUD.



Além disso foram construídos Enums para resolver problemas relacionados com os "números mágicos".

# Rodando o projeto:
```dotnet run```
