using MonoBehaviours.Controllers;
using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter.Actions
{
	[CreateAssetMenu(fileName = "New draw line to agent destination",
		menuName = "NUP/Fighter/Action/DrawLineToAgentDestination",
		order = 0)]
	public class DrawLineToAgentDestination : Action
	{
		public ColorRef gizmoColor;
		public override void Act(FighterController controller)
		{
			Gizmos.color = gizmoColor.Value;
			Gizmos.DrawLine(controller.gameObject.transform.position, controller.agent.destination);
		}
	}
}