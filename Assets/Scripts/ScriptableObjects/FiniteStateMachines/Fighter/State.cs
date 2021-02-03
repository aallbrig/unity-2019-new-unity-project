using System.Collections.Generic;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	[CreateAssetMenu(fileName = "New fighter state", menuName = "NUP/Fighter/StateMachine/State", order = 0)]
	public class State : ScriptableObject
	{
		[Header("Update Actions")] public List<Action> updateActions;

		// TODO: Explore commented ideas below?
		// [Header("On Trigger Actions")] public List<Action> onTriggerActions
		// [Header("On Trigger Enter Actions")] public List<Action> onTriggerEnterActions;
		// [Header("On Trigger Exit Actions")] public List<Action> onTriggerExitActions;
		public List<Transition> transitions;

		public void UpdateState(FighterController controller)
		{
			updateActions.ForEach(action => action.Act(controller));
			CheckTransitions(controller);
		}

		private void CheckTransitions(FighterController controller)
		{
			transitions.ForEach(transition =>
			{
				if (transition.decision.Decide(controller))
					controller.TransitionToState(transition.trueState);
			});
		}
	}
}