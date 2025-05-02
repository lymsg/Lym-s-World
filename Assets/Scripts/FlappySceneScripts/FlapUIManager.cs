using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum UIState
{
    Home,
    Game,
    GameOver,
    GameClear,
}
public class FlapUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI restartText;
    public GameObject gameOverUi;

    FlapHomeUI flapHomeUI;
    FlapGameUI flapGameUI;
    FlapGameOverUI flapGameOverUI;
    FlapGameClearUI flapGameClearUI;
    private UIState currentState;
    private void Awake()
    {
        flapHomeUI = GetComponentInChildren<FlapHomeUI>(true);
        flapHomeUI.Init(this);
        flapGameUI = GetComponentInChildren<FlapGameUI>(true);
        flapGameUI.Init(this);
        flapGameOverUI = GetComponentInChildren<FlapGameOverUI>(true);
        flapGameOverUI.Init(this);
        flapGameClearUI = GetComponentInChildren<FlapGameClearUI>(true);
        flapGameClearUI.Init(this);

        ChangeState(UIState.Home);
    }
    public void SetPlayGame()
    {
        ChangeState(UIState.Game);
    }

    public void SetGameOver()
    {
        ChangeState(UIState.GameOver);
    }
    //public void UpdateScore(int score)
    //{
    //    scoreText.text = score.ToString();
    //}

    public void SetGameClear()
    {
        ChangeState(UIState.GameClear);
    }
    public void ChangeState(UIState state)
    {
        currentState = state;
        flapHomeUI.SetActive(currentState);
        flapGameUI.SetActive(currentState);
        flapGameOverUI.SetActive(currentState);
        flapGameClearUI.SetActive(currentState);
    }

    
}
