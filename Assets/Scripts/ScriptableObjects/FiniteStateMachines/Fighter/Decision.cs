using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	public abstract class Decision : ScriptableObject
	{
		public abstract bool Decide(FighterController controller);
	}
}