using System.Collections.Generic;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	[CreateAssetMenu(fileName = "New fighter state", menuName = "NUP/Fighter/StateMachine/State", order = 0)]
	public class State : ScriptableObject
	{
		[Header("Every Update")] public List<Action> updateActions;
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