using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Message
	{
        [Key]
        public string MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

