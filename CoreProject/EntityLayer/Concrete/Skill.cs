using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Skill
	{
        [Key]
        public int SkillID { get; set; }
        public string Title { get; set; }
        public string value { get; set; }

    }
}

