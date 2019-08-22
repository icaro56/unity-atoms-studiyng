using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class DangerTrigger : MonoBehaviour
{
    [SerializeField]
    private ColliderGameObjectEvent _dangerEvent;

    private void OnTriggerEnter(Collider other)
    {
        _dangerEvent.Raise(other, other.gameObject);
    }
}
