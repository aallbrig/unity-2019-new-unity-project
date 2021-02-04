using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.InputSource
{
	public abstract class Action : ScriptableObject
	{
		public abstract void Act(InputController controller);
	}
}