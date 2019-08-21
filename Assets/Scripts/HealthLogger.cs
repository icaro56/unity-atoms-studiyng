using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Game Actions/Health Logger")]
public class HealthLogger : IntAction
{
    public override void Do(int health)
    {
        Debug.Log("Vida: " + health);
    }
}
