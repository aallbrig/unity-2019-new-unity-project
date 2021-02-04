using System;
using MonoBehaviours.Controllers;
using ScriptableObjects.Events;
using UnityEngine;
using UnityEngine.Events;

namespace MonoBehaviours.EventListeners
{
	[Serializable] public class FighterEffectGameEventUnityEvent : UnityEvent<FighterController, float> {}

	public class FighterEffectGameEventListener : MonoBehaviour
	{
		public FighterEffectGameEvent soEvent;
		public FighterEffectGameEventUnityEvent unityEvent;

		public void OnEnable() => soEvent.RegisterListener(this);

		public void OnDisable() => soEvent.UnregisterListener(this);

		public void OnEventBroadcast(FighterController fighter, float effectValue) => unityEvent.Invoke(fighter, effectValue);
	}
}