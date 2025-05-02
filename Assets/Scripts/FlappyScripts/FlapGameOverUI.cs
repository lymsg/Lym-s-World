using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlapGameOverUI : FlapBaseUI
{
    [SerializeField] private Button retryButton;
    [SerializeField] private Button exitButton;
    public override void Init(FlapUIManager flapUiManager)
    {
        base.Init(flapUiManager);
        // 버튼 클릭 이벤트 연결
        retryButton.onClick.AddListener(OnClickRetryButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void OnClickRetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    public void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    protected override UIState GetUIState()
    {
        return UIState.GameOver;
    }
}
