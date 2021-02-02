namespace Interfaces
{
	public interface IEvent<in TEventListener>
	{
		void Broadcast();
		void RegisterListener(TEventListener listener);
		void UnregisterListener(TEventListener listener);
	}
}