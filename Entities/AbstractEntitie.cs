using System;

namespace Entities
{
    public abstract class Entitie{
        public int Id {get; protected set;}
        public DateTime InsertedAt{get; protected set;}
        public DateTime UpdatedAt{get; protected set;}
    }
}