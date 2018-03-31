using Newtonsoft.Json;
using System;

namespace Zabbix
{
	public class SenderResponse
	{
		[JsonProperty(PropertyName = "response")]
		public string Response { get; set; }

		[JsonProperty(PropertyName = "")]
		public string Info { get; set; }
		public bool Success { get { return Response == "success"; }}
	}
}
