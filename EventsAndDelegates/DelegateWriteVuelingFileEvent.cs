using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace EventsAndDelegates
{
	public class DelegateWriteVuelingFileEvent
	{
		public delegate void WriteVuelingFilesHandler(string status);
		public event WriteVuelingFilesHandler WriteVuelingFilesEvent;

		public void WriteInFileTxt(string filename)
		{
			using (var fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write))
			using (var streamWriter = new StreamWriter(fileStream))
			{
				streamWriter.AutoFlush = true;
				streamWriter.WriteLine("Hola Mundo!");
				OnWriteVuelingFilesEvent("Hola mundo!");
			}
		}

		public void WriteInFileXml(string filename)
		{
			XDocument doc = XDocument.Load(filename);
			doc.Root.Add(new XElement("Message", "Hola Mundo"));
			doc.Save(filename);
		}

		public void WriteInFileXJson(string filename)
		{
			var jsonString = "";
			var list = new List<string>();
			list.Add("Hola mundo");
			jsonString = JsonConvert.SerializeObject(list.ToArray());

			File.WriteAllText(filename, jsonString);
		}

		public void OnWriteVuelingFilesEvent(string status)
		{
			if (WriteVuelingFilesEvent != null)
				WriteVuelingFilesEvent(status);
		}
	}
}
