using System.Collections;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.Fighter
{
	public abstract class FighterAction : ScriptableObject
	{
		public abstract IEnumerator Perform(FighterController controller);
	}
}