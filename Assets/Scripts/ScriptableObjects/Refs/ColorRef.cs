using System;
using ScriptableObjects.Vars;
using UnityEngine;

namespace ScriptableObjects.Refs
{
  [Serializable]
  public class ColorRef
  {
    public bool useConstant = true;
    public Color constantValue;
    public ColorVar var;

    public Color Value => useConstant ? constantValue : var.value;
  }
}