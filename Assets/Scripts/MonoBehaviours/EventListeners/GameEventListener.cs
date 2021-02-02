using Interfaces;
using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.Events;

namespace MonoBehaviours.EventListeners
{
	public class GameEventListener : MonoBehaviour, IEventListener
	{
		public GameEvent soEvent;
		public UnityEvent unityEvent;

		public void OnEventBroadcast()
		{
			unityEvent.Invoke();
		}

		public void OnEnable()
		{
			soEvent.RegisterListener(this);
		}

		public void OnDisable()
		{
			soEvent.RegisterListener(this);
		}
	}
}