using MonoBehaviours.Controllers;
using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter.Decisions
{
	[CreateAssetMenu(fileName = "New fighter health decision", menuName = "NUP/Fighter/Decisions/FighterHealth", order = 0)]
	public class FighterHealth : Decision
	{
		public bool greaterThanCheck = true;
		public FloatRef targetHealth;

		public override bool Decide(FighterController controller)
		{
			var currentHealth = controller.health;
			var targetHealthValue = targetHealth.Value;

			return greaterThanCheck ? currentHealth > targetHealthValue : currentHealth <= targetHealthValue;
		}
	}
}