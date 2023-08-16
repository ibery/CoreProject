using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ConCreate
{
	public class Feature
	{
        [Key]
        public int FeatureID { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public int Title { get; set; }
    }
}

