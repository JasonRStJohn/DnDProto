using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DNDProto.Models
{
	public class DnDAPI
	{
		public string rootUrl = "https://www.dnd5eapi.co";

		public IndexUrl[] GetList(string type)
		{
			var jsonString = new WebClient().DownloadString($"https://www.dnd5eapi.co/api/{type}/");
			return JObject.Parse(jsonString)["results"].ToObject<IndexUrl[]>();
		}

		public IndexUrl[] SearchList(string type, string search)
		{
			var jsonString = new WebClient().DownloadString($"https://www.dnd5eapi.co/api/{type}/");
			return JObject.Parse(jsonString)["results"].ToObject<IndexUrl[]>().Where(x => x.name.ToLower().Contains(search.ToLower())).ToArray();
		}

		public dynamic GetObject(string type, IndexUrl index)
		{
			var urlString = this.rootUrl + index.url;
			var jsonString = new WebClient().DownloadString(urlString);
			var obj = JObject.Parse(jsonString).ToObject<dynamic>();
			return obj;
		}
	}

}