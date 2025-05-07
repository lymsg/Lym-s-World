using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject redBox_1;
    public GameObject redBox_2;
    public GameObject boxPopup;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            boxPopup.SetActive(true);

            Transform hasKeyUI = boxPopup.transform.Find("HasKey");
            Transform notHasKeyUI = boxPopup.transform.Find("NotHasKey");

            if (this.gameObject.CompareTag("RedBox1"))
            {
                Debug.Log("RedBox1���� Player ����");
                SetUI(hasKeyUI, notHasKeyUI);
            }
            else
            {
                Debug.Log("RedBox2���� Player ����");
                SetUI(hasKeyUI, notHasKeyUI);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && boxPopup != null)
        {
            boxPopup.SetActive(false);
        }
    }

    void SetUI(Transform hasKeyUI, Transform notHasKeyUI)
    {
        if (hasKeyUI != null && notHasKeyUI != null)
        {
            if (GameManager.Instance.weaponBoxKey == true)
            {
                hasKeyUI.gameObject.SetActive(true);
                notHasKeyUI.gameObject.SetActive(false);
            }
            else
            {
                hasKeyUI.gameObject.SetActive(false);
                notHasKeyUI.gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("Haskey �Ǵ� NotHaskey ������Ʈ�� boxPopup���� ã�� �� �����ϴ�.");
        }
    }
}
