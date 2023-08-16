using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Experience
	{
        [Key]
        public int ExperienceID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
        public string Description{ get; set; }
    }
}

