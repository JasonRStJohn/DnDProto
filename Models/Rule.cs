using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNDProto.Models
{
	public class Rule : DnDAPI
	{
		public string name { get; set; }
		public string index { get; set; }
		public string desc { get; set; }
		public RuleSection[] subsections { get; set; }
		public string url { get; set; }

		internal void GetSubSections()
		{
			foreach (var sec in subsections)
			{
				sec.desc = this.GetObject("rules", sec as IndexUrl).ToObject<RuleSection>().desc;
			}
		}
	}
}
