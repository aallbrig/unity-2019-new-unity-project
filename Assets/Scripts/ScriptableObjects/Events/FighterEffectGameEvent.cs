using System.Collections.Generic;
using MonoBehaviours.Controllers;
using MonoBehaviours.EventListeners;
using UnityEngine;

namespace ScriptableObjects.Events
{
	[CreateAssetMenu(fileName = "new fighter effect game event", menuName = "NUP/Events/FighterEffectGameEvent")]
	public class FighterEffectGameEvent : ScriptableObject
	{
		private readonly List<FighterEffectGameEventListener> _listeners = new List<FighterEffectGameEventListener>();

		public void Broadcast(FighterController fighter, float effectValue)
		{
			for (var i = _listeners.Count - 1; i >= 0; i--)
				_listeners[i].OnEventBroadcast(fighter, effectValue);
		}

		public void RegisterListener(FighterEffectGameEventListener listener)
		{
			if (!_listeners.Contains(listener))
				_listeners.Add(listener);
		}

		public void UnregisterListener(FighterEffectGameEventListener listener)
		{
			if (_listeners.Contains(listener))
				_listeners.Remove(listener);
		}
	}
}