using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	public abstract class Action : ScriptableObject
	{
		public abstract void Act(FighterController controller);
	}
}