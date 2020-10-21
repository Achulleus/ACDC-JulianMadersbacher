using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjekt_Beispiel.Models
{
    public class Article
    {
        private decimal _price;

        public int ArticleId { get; set; }
        public string Articlename { get; set; }
        public decimal Price
        {
            get { return this._price;  }
            set
            {
                if (value >= 0.0m)
                {
                    this._price = value;
                }
            }
        }
        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        // Custroctors
        public Article() : this(0,"", 0.0m, "", null) { }
        public Article(int id, string articlename, decimal price, string description, DateTime? releaseDate)
        {
            this.ArticleId = id;
            this.Articlename = articlename;
            this.Price = price;
            this.Description = description;
            this.ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return this.ArticleId + " " + this.Articlename + " " + this.Price + "Euro";
        }
    }
}
