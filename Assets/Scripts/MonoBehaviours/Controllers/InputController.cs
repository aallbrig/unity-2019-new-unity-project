using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ScriptableObjects.Events;
using ScriptableObjects.Fighter;
using ScriptableObjects.FiniteStateMachines.InputSource;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
	public class InputController : MonoBehaviour
	{
		public FighterControllerRuntimeSet ownFighters;
		public FighterControllerRuntimeSet enemyFighters;
		public State currentState;

		// Input
		public FighterController activeFighter;
		public ActionPerformance actionPerformance;
		public List<FighterController> targets = new List<FighterController>();

		// Battle meter + input queue
		public FighterGameEvent onBattleMeterTick;
		private readonly Queue<FighterController> _inputQueue = new Queue<FighterController>();
		private IEnumerator _battleMeterTick;
		private IEnumerator _manageInputQueue;

		private void Awake()
		{
			_battleMeterTick = BattleMeterTick();
			_manageInputQueue = ManageInputQueue();
			StartCoroutine(_battleMeterTick);
			StartCoroutine(_manageInputQueue);
		}

		public void Clear()
		{
			activeFighter = null;
			actionPerformance = null;
			targets = new List<FighterController>();
		}

		public void QueueFighter(FighterController fighter)
		{
			_inputQueue.Enqueue(fighter);
		}

		public void TransitionToState(State nextState)
		{
			currentState.Exit(this);
			currentState = nextState;
			currentState.Enter(this);
		}

		private void HandleBattleMeterTick(FighterController fighter)
		{
			// No reason to spend cycles filling up an already full battle meter
			if (!(fighter.battleMeter <= 1.0))
				return;

			var tickUpdate = 1 / fighter.data.battleMeterStats.secondsUntilFull.Value * Time.deltaTime;
			var newBattleMeterValue = Mathf.Clamp(fighter.battleMeter + tickUpdate, 0.0f, 1.0f);

			if (newBattleMeterValue >= 1.0 && !_inputQueue.Contains(fighter))
				QueueFighter(fighter);

			fighter.battleMeter = newBattleMeterValue;
			onBattleMeterTick.Broadcast(fighter);
		}

		private IEnumerator BattleMeterTick()
		{
			while (true)
			{
				ownFighters.list.Where(fighter => !fighter.dead).ToList().ForEach(HandleBattleMeterTick);
				yield return null;
			}
		}

		private IEnumerator ManageInputQueue()
		{
			while (true)
			{
				if (activeFighter == null && _inputQueue.Count > 0)
				{
					var potentialFighter = _inputQueue.Dequeue();
					if (!potentialFighter.dead)
						activeFighter = potentialFighter;
					else
						potentialFighter.battleMeter = 0.0f;
				}
				yield return null;
			}
		}
	}
}