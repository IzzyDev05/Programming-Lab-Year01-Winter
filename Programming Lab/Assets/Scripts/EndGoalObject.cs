using UnityEngine;

public class EndGoalObject : MonoBehaviour
{
    EndGoal fakeEndGoal = new EndGoal();

    [SerializeField] private EndGoalType endGoalType;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            if (endGoalType == EndGoalType.Real) {
                print("You won!");
            }
            else if (endGoalType == EndGoalType.Fake) {
                print("That's a fake win you bozo :(");
            }
        }
    }
}