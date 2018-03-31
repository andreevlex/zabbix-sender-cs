using System;
using Zabbix;

namespace cli_sender
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var msg = new Message(new SendValue { Host = "host1", Key = "key1", Value = "test3" });
			var sender = new Sender("192.168.0.3");
			var response = sender.Send(msg);
			Console.WriteLine(response.Success);
		}
	}
}
