using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.Stats
{
	[CreateAssetMenu(fileName = "new utility stats", menuName = "NUP/Stats/BattleMeterStats", order = 0)]
	public class BattleMeterStats : ScriptableObject
	{
		public FloatRef secondsUntilFull;
	}
}