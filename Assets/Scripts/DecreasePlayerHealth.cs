using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Game Actions/Decrease Player Health")]
public class DecreasePlayerHealth : ColliderGameObjectAction
{
    public override void Do(Collider collider, GameObject gameObject)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<PlayerHealth>().Health.Value -= 10;
        }
    }

    
}
