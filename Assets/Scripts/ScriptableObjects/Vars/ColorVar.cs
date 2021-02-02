using UnityEngine;

namespace ScriptableObjects.Vars
{
  [CreateAssetMenu(fileName = "new ColorVar", menuName = "NUP/Vars/ColorVar", order = 0)]
  public class ColorVar : ScriptableObject
  {
    public Color value = Color.white;
  }
}