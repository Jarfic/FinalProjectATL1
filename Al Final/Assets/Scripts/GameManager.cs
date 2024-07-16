using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get;private set;}
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject victoryTextObject;
    public GameObject gameOverObject;
    public GameObject optionsObject;
    public GameObject playerHealth;
    public GameObject objective;

    public AudioSource soundPlayer;
    public AudioClip playerDieSound;

    // public GameObject pickupParent;

    [SerializeField] private int _killTotal = 0;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("Cannot have more than one instance of 'GameManager' in the scene!");
            Destroy(this.gameObject);
        }
    }

    public void UpdateUI()
    {
        scoreText.text = score.ToString();
    }

    public void WinGame()
    {

        foreach(EnemyFollower enemy in FindObjectsOfType<EnemyFollower>())
        {
            enemy.gameObject.SetActive(false);
            playerHealth.SetActive(false);
            objective.SetActive(false);
            
        }


        if(SceneManager.GetActiveScene().name == "Level 1") SceneManager.LoadScene("Level 2");
        else if(SceneManager.GetActiveScene().name == "Level 2") SceneManager.LoadScene("Level 3");
        else victoryTextObject.SetActive(true);
    }
    
    public void GameOver()
    {
        gameOverObject.SetActive(true);
        foreach(EnemyFollower enemy in FindObjectsOfType<EnemyFollower>())
        {
            enemy.gameObject.SetActive(false);
        }
        soundPlayer.PlayOneShot(playerDieSound);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        playerHealth.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateUI();
        if(score >= _killTotal)
        {
            WinGame();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateUI();
        victoryTextObject.SetActive(false);
        gameOverObject.SetActive(false);
        optionsObject.SetActive(false);

        
    }
    // Update is called once per frame
    void Update()
    {

    }


}
