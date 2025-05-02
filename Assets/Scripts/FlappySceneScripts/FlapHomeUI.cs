using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlapHomeUI : FlapBaseUI
{
    
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;
    private void Awake()
    {
        if (flapGameManager == null)
            flapGameManager = FindObjectOfType<FlapGameManager>();
    }
    public override void Init(FlapUIManager flapUiManager)
    {
        base.Init(flapUiManager);
        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void OnClickStartButton()
    {
        flapGameManager.StartGame();
    }

    public void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    protected override UIState GetUIState()
    {
        return UIState.Home;
    }
}
