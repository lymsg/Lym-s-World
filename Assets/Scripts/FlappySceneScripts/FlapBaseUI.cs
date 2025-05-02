using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlapBaseUI : MonoBehaviour
{
    protected FlapUIManager flapUiManager;
    protected FlapGameManager flapGameManager;

    public virtual void Init(FlapUIManager flapUiManager)
    {
        this.flapUiManager = flapUiManager;
    }

    protected abstract UIState GetUIState();
    public void SetActive(UIState state)
    {
        this.gameObject.SetActive(GetUIState() == state);
    }
}
