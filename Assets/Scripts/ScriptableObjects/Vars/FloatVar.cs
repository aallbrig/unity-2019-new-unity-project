using UnityEngine;

namespace ScriptableObjects.Vars
{
	[CreateAssetMenu(fileName = "new FloatVar", menuName = "NUP/Vars/FloatVar", order = 0)]
	public class FloatVar : ScriptableObject
	{
		public float value;
	}
}