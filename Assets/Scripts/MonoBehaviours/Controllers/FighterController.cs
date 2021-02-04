using System.Collections;
using System.Collections.Generic;
using Interfaces;
using ScriptableObjects.Fighter;
using ScriptableObjects.FiniteStateMachines.Fighter;
using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Controllers
{
	public class FighterController : MonoBehaviour, IDamageable, IHealable
	{
		[Header("Static data")] public FighterData data;

		// Dynamic data
		[HideInInspector] public List<FighterController> targets = new List<FighterController>();
		[HideInInspector] public bool dead;

		// agent can be used for some state (e.g. destination)
		public float health;
		public float battleMeter;
		[HideInInspector] public NavMeshAgent agent;
		[SerializeField] private float armor;

		public State currentState;
		private IEnumerator _actionCoroutine;

		private void Awake()
		{
			health = Random.Range(data.defenseStats.minHP.Value, data.defenseStats.maxHP.Value);
			SetDeadStatus();
			armor = data.defenseStats.armor.Value;

			agent = GetComponent<NavMeshAgent>();
		}

		private void Update()
		{
			currentState.StateUpdate(this);
		}

		private void OnDrawGizmos()
		{
			currentState.StateOnDrawGizmos(this);
		}

		public void Damage(float damage)
		{
			var healthUpdate = Mathf.Clamp(health - damage, 0.0f, data.defenseStats.maxHP.Value);
			health = healthUpdate;
			SetDeadStatus();
		}

		public void Heal(float heal)
		{
			var healthUpdate = Mathf.Clamp(health + heal, 0.0f, data.defenseStats.maxHP.Value);
			health = healthUpdate;
			SetDeadStatus();
		}

		public void TransitionToState(State nextState)
		{
			currentState = nextState;
		}

		public void PerformAction(ActionPerformance actionPerformance)
		{
			if (_actionCoroutine != null) StopCoroutine(_actionCoroutine);

			_actionCoroutine = actionPerformance.Perform(this);
			StartCoroutine(_actionCoroutine);
		}

		private void SetDeadStatus()
		{
			dead = health <= 0;
		}
	}
}