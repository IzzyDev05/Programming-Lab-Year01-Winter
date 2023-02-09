using UnityEngine;

public class EnemyChaser : EnemyBase
{
    [SerializeField] private string chaseObject = "Enemy";

    private void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            Chase(chaseObject);
        }    
    }

    public override void Chase(string name) {
        base.Chase(name);
    }
}
