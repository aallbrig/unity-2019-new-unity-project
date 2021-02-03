using MonoBehaviours.Controllers;
using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter.Decisions
{
	[CreateAssetMenu(fileName = "New fighter agent velocity", menuName = "NUP/Fighter/Decisions/FighterAgentVelocity",
	order = 0)]
	public class FighterAgentVelocity : Decision
	{
		public FloatRef velocity;
		public bool greaterThan = true;

		public override bool Decide(FighterController controller)
		{
			var velocityMagnitude = controller.agent.velocity.magnitude;
			return greaterThan ? velocityMagnitude > velocity.Value : velocityMagnitude <= velocity.Value;
		}
	}
}