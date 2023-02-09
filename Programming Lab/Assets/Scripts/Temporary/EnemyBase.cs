using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public virtual void Chase(string name) {
        print($"I am chasing {name}");
    }
}
