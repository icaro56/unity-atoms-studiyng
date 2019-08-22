
using UnityAtoms;
using UnityAtoms.Tags;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Game Actions/Decrease Player Health")]
public class DecreasePlayerHealth : ColliderGameObjectAction
{
    [FormerlySerializedAs("TagPlayer")]
    [SerializeField]
    private StringConstant _tagPlayer;


    public override void Do(Collider collider, GameObject gameObject)
    {
        if (collider.gameObject.HasTag(_tagPlayer))
        {
            collider.GetComponent<PlayerHealth>().Health.Value -= 10;
        }
    }

    
}
