using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void LevelComplete() {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (!gameHasEnded) {
            gameHasEnded = true;
            if (restartDelay > 0f) Invoke("Restart", restartDelay);
            else Restart();
        }
    }

    void Restart() {
        SceneManager.LoadScene("level1");
    }

    void exitGame() {
        Application.Quit();
    }
}
