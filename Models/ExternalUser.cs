using System;

namespace myvideogamelist.Models
{
	public class ExternalUser
	{
		public string id { get; set; }
		public string name { get; set; }
		public string given_name { get; set; }
		public string family_name { get; set; }
		public string email { get; set; }
		public string picture { get; set; }
		public string externalToken { get; set; }
		public string externalProvider { get; set; }
	}
}
