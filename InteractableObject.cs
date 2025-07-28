using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public virtual void TriggerInteraction()
    {
        Debug.Log("상호작용 했음: " + gameObject.name);
    }
}

