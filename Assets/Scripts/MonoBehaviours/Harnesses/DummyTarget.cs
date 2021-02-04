using UnityEngine;

namespace MonoBehaviours.Harnesses
{
	public class DummyTarget : MonoBehaviour
	{
		private void OnDrawGizmos() => Gizmos.DrawWireSphere(transform.position, 1);
	}
}