using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlapGameClearUI : FlapBaseUI
{
    [SerializeField] private Button exitButton;
    public override void Init(FlapUIManager flapUiManager)
    {
        base.Init(flapUiManager);
        // 버튼 클릭 이벤트 연결
       exitButton.onClick.AddListener(OnClickExitButton);
    }
    public void OnClickExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    protected override UIState GetUIState()
    {
        return UIState.GameClear;
    }
}
