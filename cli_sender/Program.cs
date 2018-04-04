using System;
using Zabbix;

namespace cli_sender
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			if(args.Length < 1){
				Environment.Exit(1);
			}

			string host = args[0];

			var val1 = new SendValue { Host = "host1", Key = "key1", Value = "Тест кириллицы" };
			var val2 = new SendValue { Host = "host1", Key = "key1", Value = "Значение 2"};

			// Example1
			var msg = new Message(val1);
			var sender = new Sender(host);
			var response = sender.Send(msg);
			Console.WriteLine(response.Success);

			var arr = new SendValue[] { val1, val2};
			var msg2 = new Message(arr);
			var sender2 = new Sender(host);
			var response2 = sender2.Send(msg2);
			System.Console.WriteLine(response2.Success);
		}
	}
}
