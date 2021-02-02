namespace Interfaces
{
	public interface IEventListener
	{
		void OnEventBroadcast();
		void OnEnable();
		void OnDisable();
	}
}