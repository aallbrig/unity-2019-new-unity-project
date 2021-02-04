using System;

namespace ScriptableObjects.FiniteStateMachines.InputSource
{
	[Serializable]
	public class Transition
	{
		public Decision decision;
		public State trueState;
	}
}