using System.Collections;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.Fighter
{
	// [CreateAssetMenu(fileName = "New fighter action", menuName = "NUP/Fighter/FighterAction", order = 0)]
	public abstract class FighterAction : ScriptableObject
	{
		public abstract IEnumerator Perform(FighterController self);
	}
}