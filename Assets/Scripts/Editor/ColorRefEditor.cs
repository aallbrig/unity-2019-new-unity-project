using ScriptableObjects.Refs;
using UnityEditor;

namespace Editor
{
	[CustomEditor(typeof(ColorRef))]
	public class ColorRefEditor : UnityEditor.Editor
	{
		private ColorRef colorRef;
		// public override void OnInspectorGUI()
		// {
		//   if (GUILayout.Button("Test Button"))
		//   {
		//     Debug.Log("Test button clicked");
		//   }
		// }
	}
}