using UnityEngine;

public class progressCheck : MonoBehaviour {

    public bool isEnd = false;

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            if (isEnd) {
                Debug.Log("END");
                FindObjectOfType<GameManager>().LevelComplete();
            } else FindObjectOfType<cubeMovement>().forwardForce *= 1.2f;
        }
    }
}
