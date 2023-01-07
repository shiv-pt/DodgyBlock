using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    // Start is called before the first frame update
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
    public void EndGame() {
        if(!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
    }
     public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}
