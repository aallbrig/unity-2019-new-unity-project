using System.Collections.Generic;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.InputSource
{
	[CreateAssetMenu(fileName = "New input source state", menuName = "NUP/InputSource/StateMachine/State", order = 0)]
	public class State : ScriptableObject
	{
		public List<Action> enterActions;
		public List<Action> updateActions;
		public List<Action> exitActions;
		public List<Transition> transitions;

		public void Enter(InputController controller)
		{
			enterActions.ForEach(action => action.Act(controller));
		}
		public void Exit(InputController controller)
		{
			exitActions.ForEach(action => action.Act(controller));
		}

		// Console errors if this is just called Update
		public void StateUpdate(InputController controller)
		{
			updateActions.ForEach(action => action.Act(controller));
			CheckTransitions(controller);
		}

		private void CheckTransitions(InputController controller)
		{
			transitions.ForEach(transition =>
			{
				if (transition.decision.Decide(controller))
					controller.TransitionToState(transition.trueState);
			});
		}
	}
}