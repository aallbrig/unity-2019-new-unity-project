using ScriptableObjects.Refs;
using UnityEngine;

namespace MonoBehaviours.Customizers
{
  [ExecuteInEditMode]
  public class UpdateMeshColor : MonoBehaviour
  {
    public ColorRef meshColor;
    private Renderer _renderer;

    private void Update() => _renderer.material.color = meshColor.Value;
    private void Awake() => _renderer = GetComponent<Renderer>();
  }
}