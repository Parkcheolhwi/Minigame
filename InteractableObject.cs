using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public virtual void TriggerInteraction()
    {
        Debug.Log("��ȣ�ۿ� ����: " + gameObject.name);
    }
}

