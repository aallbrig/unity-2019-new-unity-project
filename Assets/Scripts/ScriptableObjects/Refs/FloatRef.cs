using System;
using ScriptableObjects.Vars;

namespace ScriptableObjects.Refs
{
	[Serializable]
	public class FloatRef
	{
		public bool useConstant = true;
		public float constantValue;
		public FloatVar var;

		public float Value => useConstant ? constantValue : var.value;
	}
}