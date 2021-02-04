using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.InputSource
{
	public abstract class Decision : ScriptableObject
	{
		public abstract bool Decide(InputController controller);
	}
}