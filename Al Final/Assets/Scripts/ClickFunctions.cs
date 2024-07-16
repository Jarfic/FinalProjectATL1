using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LevOne()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LevTwo()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LevThree()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void LevFour()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void LevFive()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Controls()
    {
        GameManager.instance.optionsObject.SetActive(true);
    }

    public void GameOverFunction()
    {
        GameManager.instance.optionsObject.SetActive(false);
    }
}
