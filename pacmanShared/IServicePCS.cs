
namespace Shared
{
	public interface IServicePCS
	{
		void StartServer(string arguments);
		void StartSecondaryServer(string arguments);
		void StartClient(string arguments);
		void QuitAllPrograms();
	}
}