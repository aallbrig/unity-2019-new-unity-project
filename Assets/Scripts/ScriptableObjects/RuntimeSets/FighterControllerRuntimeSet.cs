using System;
using System.Collections.Generic;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.RuntimeSets
{
	[CreateAssetMenu(fileName = "New fighter controller runtime set", menuName = "NUP/RuntimeSets/FighterController",
		order = 0)]
	public class FighterControllerRuntimeSet : ScriptableObject
	{
		public List<FighterController> list;

		public void Add(FighterController controller)
		{
			if (!list.Contains(controller)) list.Add(controller);
		}

		public void Remove(FighterController controller)
		{
			if (list.Contains(controller)) list.Remove(controller);
		}

		private void Awake()
		{
			list.Clear();
		}
		private void OnEnable()
		{
			list.Clear();
		}
		private void OnDisable()
		{
			list.Clear();
		}
		private void OnDestroy()
		{
			list.Clear();
		}
	}
}