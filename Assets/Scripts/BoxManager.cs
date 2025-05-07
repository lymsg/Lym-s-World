using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    
    public static BoxTrigger currentBox;  

    public void OnBoxButtonClick()
    {
        if (currentBox != null)
        {
            currentBox.Apply();
        }
    }
}
