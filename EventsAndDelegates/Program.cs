using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	class Program
	{
		static void Logger(string info)
		{
			System.Console.WriteLine(info);
		}

		static void Main(string[] args)
		{
			DelegateCreateVuelingFileEvent fileEvent = new DelegateCreateVuelingFileEvent();
			DelegateWriteVuelingFileEvent writer = new DelegateWriteVuelingFileEvent();
			fileEvent.CreateVuelingFilesEvent += new DelegateCreateVuelingFileEvent.CreateVuelingFilesHandler(Logger);
			writer.WriteVuelingFilesEvent += new DelegateWriteVuelingFileEvent.WriteVuelingFilesHandler(Logger);
			fileEvent.CreateFiles("VuelingFile.txt");
			fileEvent.CreateFiles("VuelingFile.xml");
			fileEvent.CreateFiles("VuelingFile.json");
			writer.WriteInFileTxt("VuelingFile.txt");
			writer.WriteInFileXml("VuelingFile.xml");
			writer.WriteInFileXJson("VuelingFile.json");

		}
	}
}
