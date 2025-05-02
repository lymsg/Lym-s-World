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
        // ��ư Ŭ�� �̺�Ʈ ����
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
