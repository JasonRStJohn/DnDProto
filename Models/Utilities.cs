using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDProto.Models
{
	public enum ComponentType
	{
		V,
		S,
		M,
	}

	public class DamageObject
	{
		public IndexUrl damage_type { get; set; }
		public Dictionary<int, string> damage_at_slot_level { get; set; }
	}

	public class Equipment
	{
		public IndexUrl equipment { get; set; }
		public int quantity { get; set; }
	}

	public class MultiClassingInfo
	{
		public PreReq[] prerequisites { get; set; }
		public IndexUrl[] proficiencies { get; set; }
		public Option[] proficiency_choices { get; set; }
	}

	public class Spellcasting
	{
		public int level { get; set; }
		public IndexUrl spellcasting_ability { get; set; }
		public InfoObj[] info { get; set; }
	}

	public class PreReq
	{
		public IndexUrl ability_score { get; set; }
		public int minimum_score { get; set; }
	}

	public class Option
	{
		public int choose { get; set; }
		public string type { get; set; }
		public IndexUrl[] from { get; set; }
	}

	public class RuleSection : IndexUrl
	{
		public string desc { get; set; }
	}

	public class IndexUrl
	{
		public string index { get; set; }
		public string name { get; set; }
		public string url { get; set; }
	}

	public class InfoObj
	{
		public string[] desc { get; set; }
		public string name { get; set; }
	}

}
