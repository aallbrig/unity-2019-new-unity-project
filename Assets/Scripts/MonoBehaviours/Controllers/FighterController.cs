using System.Collections;
using System.Collections.Generic;
using ScriptableObjects.Fighter;
using ScriptableObjects.FiniteStateMachines.Fighter;
using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Controllers
{
	public class FighterController : MonoBehaviour
	{
		[Header("Static data")] public FighterData data;

		// Dynamic data
		[HideInInspector] public Vector3 destination;
		[HideInInspector] public List<FighterController> targets = new List<FighterController>();
		[HideInInspector] public bool dead;

		[HideInInspector] public NavMeshAgent agent;
		[SerializeField] private float armor;
		[SerializeField] private float health;

		public State currentState;
		private IEnumerator _actionCoroutine;
		private State _startingState;

		private void Awake()
		{
			health = Random.Range(data.defenseStats.minHP.Value, data.defenseStats.maxHP.Value);
			SetDeadStatus();
			armor = data.defenseStats.armor.Value;

			_startingState = currentState;
			agent = GetComponent<NavMeshAgent>();
		}

		private void Update()
		{
			currentState.UpdateState(this);
		}

		public void TransitionToState(State nextState)
		{
			currentState = nextState;
		}

		public void PerformAction(FighterAction action)
		{
			if (_actionCoroutine != null) StopCoroutine(_actionCoroutine);

			_actionCoroutine = action.Perform(this);
			StartCoroutine(_actionCoroutine);
		}

		private void SetDeadStatus()
		{
			dead = health <= 0;
		}
	}
}