using UnityEngine;

public class PlayerChaser : EnemyBase
{
    [SerializeField] private string chaseObject = "Player";

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            Chase(chaseObject);
        }    
    }

    public override void Chase(string name) {
        base.Chase(name);
    }
}