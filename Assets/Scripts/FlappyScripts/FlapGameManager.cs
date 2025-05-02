using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlapGameManager : MonoBehaviour
{
    static FlapGameManager flapGameManager;
    FlapUIManager flapUiManager;

    [SerializeField]
    private FlapGameUI flapGameUI;

    public static bool isFirstLoading = true;
    public int targetScore = 2;
    public static FlapGameManager Instance
    {
        get { return flapGameManager; }
    }

    private int currentScore = 0;

    public FlapUIManager UIManager
    {
        get { return flapUiManager; }
    }
    private void Awake()
    {
        flapGameManager = this;
        flapUiManager = FindObjectOfType<FlapUIManager>();
        Time.timeScale = 0;

    }
    private void Start()
    {
        if (!isFirstLoading)
        {
            StartGame();
        }
        else
        {
            isFirstLoading = false;
            
        }
        //flapUiManager.UpdateScore(0);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        flapUiManager.SetPlayGame();
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        flapUiManager.SetGameOver();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        if (currentScore >= targetScore)
        {
            UIManager.SetGameClear();
            Time.timeScale = 0f;
        }
        else
        {
            flapGameUI.UpdateScoreText(currentScore);
            Debug.Log("Score: " + currentScore);
        }
    }

    public void Clear(int score)
    {
        if (score < targetScore) return;

        else 
        {

        }
    }
}
