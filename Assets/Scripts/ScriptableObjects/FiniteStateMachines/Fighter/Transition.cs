namespace ScriptableObjects.FiniteStateMachines.Fighter
{
	[System.Serializable]
	public class Transition
	{
		public Decision decision;
		public State trueState;
	}
}