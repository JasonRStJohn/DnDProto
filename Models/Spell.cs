using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDProto.Models
{
	public class Spell : DnDAPI
	{
		public string index { get; set; }
		public string name { get; set; }
		public string[] desc { get; set; }
		public string[] higher_level { get; set; }
		public string range { get; set; }
		public ComponentType[] components { get; set; }
		public string material { get; set; }
		public bool ritual { get; set; }
		public string duration { get; set; }
		public bool concentration { get; set; }
		public string casting_time { get; set; }
		public int level { get; set; }
		public string attack_type { get; set; }
		public DamageObject damage { get; set; }
		public IndexUrl school { get; set; }
		public IndexUrl[] classes { get; set; }
		public IndexUrl[] subclasses { get; set; }
		public string url { get; set; }
	}

}
