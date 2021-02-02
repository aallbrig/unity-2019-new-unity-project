using ScriptableObjects.Refs;
using UnityEngine;

namespace ScriptableObjects.Stats
{
  [CreateAssetMenu(fileName = "new utility stats", menuName = "NUP/Stats/UtilityStats", order = 0)]
  public class UtilityStats : ScriptableObject
  {
    public FloatRef movementSpeed;
  }
}