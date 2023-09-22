using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : ScriptableObject
{
    public virtual void Act(Entity _e){
        Debug.Log("Default Action");
    }
}