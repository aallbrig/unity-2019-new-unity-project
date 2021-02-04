using MonoBehaviours.Controllers;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.RuntimeSets.FighterControllers
{
	public class AddOnAwake : MonoBehaviour
	{
		public FighterControllerRuntimeSet set;

		private void Awake() => set.Add(GetComponent<FighterController>());
	}
}