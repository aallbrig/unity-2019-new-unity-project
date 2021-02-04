using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Harnesses
{
	public class NavMeshAgentMovesToTarget : MonoBehaviour
	{
		public Transform target;
		[SerializeField] private NavMeshAgent agent;
		private void Awake() => agent = GetComponent<NavMeshAgent>();

		private void Update() => agent.SetDestination(target.position);
	}
}