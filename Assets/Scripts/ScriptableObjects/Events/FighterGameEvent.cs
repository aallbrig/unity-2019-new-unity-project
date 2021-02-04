using System.Collections.Generic;
using MonoBehaviours.Controllers;
using MonoBehaviours.EventListeners;
using UnityEngine;

namespace ScriptableObjects.Events
{
	[CreateAssetMenu(fileName = "new fighter game event", menuName = "NUP/Events/FighterGameEvent")]
	public class FighterGameEvent : ScriptableObject
	{
		private readonly List<FighterGameEventListener> _listeners = new List<FighterGameEventListener>();

		public void Broadcast(FighterController fighter)
		{
			for (var i = _listeners.Count - 1; i >= 0; i--)
				_listeners[i].OnEventBroadcast(fighter);
		}

		public void RegisterListener(FighterGameEventListener listener)
		{
			if (!_listeners.Contains(listener))
				_listeners.Add(listener);
		}

		public void UnregisterListener(FighterGameEventListener listener)
		{
			if (_listeners.Contains(listener))
				_listeners.Remove(listener);
		}
	}
}