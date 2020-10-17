using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void startFunction() {
        SceneManager.LoadScene("Level_1");
    }
    public void QuitGame() {
        Application.Quit();
    }
}
