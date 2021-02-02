using System.Collections;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.Fighter.Actions
{
	[CreateAssetMenu(fileName = "New move action", menuName = "NUP/Fighter/Actions/Move", order = 0)]
	public class MoveAction : FighterAction
	{
		public override IEnumerator Perform(FighterController self)
		{
			self.agent.SetDestination(self.destination);

			yield return ReachedDestination(self);
		}

		private static IEnumerator ReachedDestination(FighterController self)
		{
			while (self.agent.remainingDistance < 0.1)
			{
				yield return null;
			}
		}
	}
}