using System;
using System.Text;
using Enums;
using Interfaces;

namespace Entities
{
    public class Series : Entities.Entitie, IEntitie{

        public String Title {get;  private set;}
        public Category Category {get;  private set;}
        public String Description {get;  private set;}
        public int Year {get;  private set;}
        public bool Excluded{get;  private set;}

        public Series(int id, String title, Category category, String description, int year){
            Id = id;
            Title = title;
            Category = category;
            Description = description;
            Year = year;
            Excluded = false;
            InsertedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void Exclude(){
            Excluded = true;
            UpdatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Título: " + Title);
            result.AppendLine("Categoria: " + Category);
            return result.ToString();
        }
    }
}