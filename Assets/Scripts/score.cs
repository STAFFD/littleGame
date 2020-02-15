using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public Vector3 lastPosition;
    public Vector3 initPosition;

    // Start is called before the first frame update
    void Start() {
        scoreText.text = "Go";
        lastPosition = initPosition = player.position;
    }

    // Update is called once per frame
    void Update() {
        if (lastPosition.z != player.position.z) {
            scoreText.text = (player.position.z - initPosition.z).ToString("0");
            lastPosition = player.position;
        }
    }
}
