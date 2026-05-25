using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PapelX.WebApi.Data
{
    public class Product
    {
        public int Id {get;set;}
        public string? Name {get;set;}
        public decimal Price {get;set;}
        public string? Category {get;set;}
    }

    public class DataFake
    {
      public static List<Product> Products {get;set;} = new List<Product>()
      {
          new Product { Id = 145632, Name = "Caderno Universitário 10 Matérias", Price = 29.90m, Category = "Papelaria" },
          new Product { Id = 234523, Name = "Caneta Esferográfica Azul 0.7mm", Price = 12.50m, Category = "Escrita" },
          new Product { Id = 323425, Name = "Estojo Escolar Organizador", Price = 45.00m, Category = "Acessórios" },
          new Product { Id = 497846, Name = "Bloco de Notas Autocolantes Neon", Price = 8.90m, Category = "Organização" },
          new Product { Id = 508665, Name = "Lapiseira Técnica 0.5mm", Price = 22.00m, Category = "Escrita" },
          new Product { Id = 642456, Name = "Caderno Universitário 100 Matérias", Price = 39.90m, Category = "Papelaria" },
          new Product { Id = 777535, Name = "Caneta Gel Preta 0.5mm", Price = 8.50m, Category = "Escrita" },
          new Product { Id = 854574, Name = "Estojo Organizador Slim", Price = 39.90m, Category = "Acessórios" },
          new Product { Id = 935352, Name = "Bloco Adesivo Reciclado 4 Cores", Price = 14.20m, Category = "Organização" },
          new Product { Id = 100345, Name = "Grampeador Compacto de Metal", Price = 24.90m, Category = "Escritório" },
          new Product { Id = 113454, Name = "Marca-Texto Tons Pastéis (Kit c/ 6)", Price = 19.80m, Category = "Escrita" }
      };
    }
}