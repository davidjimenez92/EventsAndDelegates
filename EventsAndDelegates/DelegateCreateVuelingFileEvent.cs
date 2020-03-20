namespace EventsAndDelegates
{
	public class DelegateCreateVuelingFileEvent
	{
		public delegate void CreateVuelingFilesHandler(string status);
		public event CreateVuelingFilesHandler CreateVuelingFilesEvent;

		public void CreateFiles(string filename)
		{
			CreateVuelingFile file = new CreateVuelingFile();
			file.CreateVuelingFiles(filename);
			OnCreateVuelingFilesEvent($"Created File {filename}");
		}

		public void OnCreateVuelingFilesEvent(string status)
		{
			if (CreateVuelingFilesEvent != null)
				CreateVuelingFilesEvent(status);
		}
	}
}
