using System;

namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	[Serializable]
	public class Transition
	{
		public Decision decision;
		public State trueState;
	}
}