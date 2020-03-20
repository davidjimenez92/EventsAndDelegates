using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace EventsAndDelegates
{
	public class CreateVuelingFile
	{
		public void CreateVuelingFiles(string fileName)
		{
			if (fileName.Contains("xml"))
			{
				new XDocument(new XElement("Vueling")).Save(fileName);
			}
			else
			{
				using (var fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
				using (var streamWriter = new StreamWriter(fileStream))
				{
					streamWriter.AutoFlush = true;
				}
			}
		}
	}
}
