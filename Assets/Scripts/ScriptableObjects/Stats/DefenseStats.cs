using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.Stats
{
	[CreateAssetMenu(fileName = "new defense stats", menuName = "NUP/Stats/DefenseStats", order = 0)]
	public class DefenseStats : ScriptableObject
	{
		public FloatRef maxHP;
		public FloatRef hpRegen;
		public FloatRef armor;
	}
}