using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Contact
	{
        [Key]
        public string ConcactID { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
    }
}

