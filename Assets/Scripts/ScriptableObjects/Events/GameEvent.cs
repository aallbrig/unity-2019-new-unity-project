using MonoBehaviours.EventListeners;
using UnityEngine;

namespace ScriptableObjects.Events
{
	[CreateAssetMenu(fileName = "new game event", menuName = "NUP/Events/GameEvent")]
	public class GameEvent : Event<GameEventListener>
	{
	}
}