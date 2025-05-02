using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlapGameUI : FlapBaseUI
{
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
    protected override UIState GetUIState()
    {
        return UIState.Game;
    }
}
