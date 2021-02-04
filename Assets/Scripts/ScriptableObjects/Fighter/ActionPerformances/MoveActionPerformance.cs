using System.Collections;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.Fighter.ActionPerformances
{
	[CreateAssetMenu(fileName = "New move action", menuName = "NUP/Fighter/Actions/Move", order = 0)]
	public class MoveActionPerformance : ActionPerformance
	{
		public Vector3 destination;

		public override IEnumerator Perform(FighterController self)
		{
			self.agent.SetDestination(destination);
			yield return ReachedDestination(self);
		}

		private static IEnumerator ReachedDestination(FighterController self)
		{
			while (self.agent.remainingDistance < 0.1) yield return null;
		}
	}
}