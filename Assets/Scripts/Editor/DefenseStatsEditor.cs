using ScriptableObjects.Stats;
using UnityEditor;

namespace Editor
{
  [CustomEditor(typeof(DefenseStats))]
  public class DefenseStatsEditor : UnityEditor.Editor
  {
    private DefenseStats _defenseStats;
    public override void OnInspectorGUI()
    {
      // TODO: Customize inspector (?)
      // TODO: Or just use Odin (?)
      // _defenseStats = (DefenseStats) target;

      // var serializedObject = new SerializedObject(_defenseStats);
      // serializedObject.Update();

      // var defenseStats = serializedObject.FindProperty("maxHP");
      base.OnInspectorGUI();
    }
  }
}