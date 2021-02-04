using ScriptableObjects.Stats;
using UnityEngine;

namespace ScriptableObjects.Fighter
{
	[CreateAssetMenu(fileName = "New fighter data", menuName = "NUP/Fighter/FighterData", order = 0)]
	public class FighterData : ScriptableObject
	{
		public DefenseStats defenseStats;
		public UtilityStats utilityStats;
		public BattleMeterStats battleMeterStats;
	}
}