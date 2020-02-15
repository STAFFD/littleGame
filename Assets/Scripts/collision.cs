using UnityEngine;

public class collision : MonoBehaviour {

	public cubeMovement movement;

    private void OnCollisionEnter(Collision collision) {

        Debug.Log("You hit " + collision.collider.name);

        if (collision.collider.tag == "obstacle") {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}