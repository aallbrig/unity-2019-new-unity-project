using System;
using MonoBehaviours.Controllers;
using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.Events;

namespace MonoBehaviours.EventListeners
{
	[Serializable] public class FighterGameEventUnityEvent : UnityEvent<FighterController> {}

	public class FighterGameEventListener : MonoBehaviour
	{
		public FighterGameEvent soEvent;
		public FighterGameEventUnityEvent unityEvent;

		public void OnEnable() => soEvent.RegisterListener(this);

		public void OnDisable() => soEvent.UnregisterListener(this);

		public void OnEventBroadcast(FighterController fighter) => unityEvent.Invoke(fighter);
	}
}