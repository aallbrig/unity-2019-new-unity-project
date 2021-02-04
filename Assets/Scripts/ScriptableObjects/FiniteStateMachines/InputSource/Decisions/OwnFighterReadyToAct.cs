using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.InputSource.Decisions
{
	[CreateAssetMenu(fileName = "Own fighter ready to act", menuName = "NUP/InputSource/Decisions/OwnFighterReadyToAct",
		order = 0)]
	public class OwnFighterReadyToAct : Decision
	{
		public override bool Decide(InputController controller)
		{
			return controller.activeFighter != null;
		}
	}
}