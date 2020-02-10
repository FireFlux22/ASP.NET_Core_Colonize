using System;

namespace Colonize.Website.Data.Entities
{
    public class Product
    {
        public Product(int id, string name, string description, decimal price, 
            string articleNumber, Uri imageUrl, string urlSlug)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ArticleNumber = articleNumber;
            ImageUrl = imageUrl;
            UrlSlug = urlSlug;
        }

        public Product()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ArticleNumber { get; set; }
        public Uri ImageUrl { get; set; }
        public string UrlSlug { get; set; }
    }
}
