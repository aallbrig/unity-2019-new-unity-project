using System.Collections.Generic;
using Interfaces;
using UnityEngine;

namespace ScriptableObjects.Events
{
  public abstract class Event<TEventListener> : ScriptableObject, IEvent<TEventListener> where TEventListener : IEventListener
  {
    private readonly List<TEventListener> _listeners = new List<TEventListener>();

    public void Broadcast()
    {
      for (var i = _listeners.Count - 1; i >= 0; i--)
      {
        _listeners[i].OnEventBroadcast();
      }
    }

    public void RegisterListener(TEventListener listener)
    {
      if (!_listeners.Contains(listener))
        _listeners.Add(listener);
    }

    public void UnregisterListener(TEventListener listener)
    {
      if (_listeners.Contains(listener))
        _listeners.Remove(listener);
    }
  }
}