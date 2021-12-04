using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDProto.Models
{
	public class CharacterClass : DnDAPI
	{
		public string index { get; set; }
		public string name { get; set; }
		public int hit_die { get; set; }
		public Option[] proficiency_choices { get; set; }
		public IndexUrl[] proficiencies { get; set; }
		public IndexUrl[] saving_throws { get; set; }
		public Equipment[] starting_equipment { get; set; }
		public Option[] starting_equipment_options { get; set; }
		public string class_levels { get; set; }
		public MultiClassingInfo multi_classing { get; set; }
		public IndexUrl[] subclasses { get; set; }
		public Spellcasting spellcasting { get; set; }
		public string spells { get; set; }
		public string url { get; set; }
	}
}
