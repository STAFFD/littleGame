using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            restart();
        }
    }

    void restart() {
        SceneManager.LoadScene("level1");
    }
}
