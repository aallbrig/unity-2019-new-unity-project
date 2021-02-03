using MonoBehaviours.Controllers;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.RuntimeSets.FighterControllers
{
	public class RemoveOnDisable : MonoBehaviour
	{
		public FighterControllerRuntimeSet set;

		private void OnDisable()
		{
			set.Remove(GetComponent<FighterController>());
		}
	}
}