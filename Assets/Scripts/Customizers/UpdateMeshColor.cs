using UnityEngine;

namespace Customizers
{
  public class UpdateMeshColor : MonoBehaviour
  {
    private Renderer _renderer;

    public void ToRandomColor() => _renderer.material.color = new Color(Random.value, Random.value, Random.value);
    private void Awake() => _renderer = GetComponent<Renderer>();
  }
}