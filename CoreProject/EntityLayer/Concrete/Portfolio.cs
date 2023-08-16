using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Portfolio
	{
        [Key]
        public string PortfolioID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}

