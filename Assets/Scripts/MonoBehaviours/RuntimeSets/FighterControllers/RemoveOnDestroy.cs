using MonoBehaviours.Controllers;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.RuntimeSets.FighterControllers
{
	public class RemoveOnDestroy : MonoBehaviour
	{
		public FighterControllerRuntimeSet set;

		private void OnDestroy()
		{
			set.Remove(GetComponent<FighterController>());
		}
	}
}