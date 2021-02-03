using System;
using ScriptableObjects.Vars;

namespace ScriptableObjects.Refs
{
	[Serializable]
	public class FloatRef
	{
		public bool useConstant = true;
		public FloatVar constantValue;
		public float var;

		public float Value => useConstant ? constantValue.value : var;
	}
}