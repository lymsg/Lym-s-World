using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    private PlayerController player;

    public GameObject redBox_1;
    public GameObject redBox_2;
    public GameObject boxPopup;

    public WeaponHandler knifePrefab;
    public WeaponHandler bowPrefab;

    public bool isOpened = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BoxManager.currentBox = this;
            boxPopup.SetActive(true);

            Transform hasKeyUI = boxPopup.transform.Find("HasKey");
            Transform notHasKeyUI = boxPopup.transform.Find("NotHasKey");

            if (this.gameObject.CompareTag("RedBox1"))
            {
                isOpened = true;
                Debug.Log("RedBox1���� Player ����");
                SetUI(hasKeyUI, notHasKeyUI);
            }
            else if(this.gameObject.CompareTag("RedBox2"))
            {
                isOpened = true;
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
            isOpened = false;
            
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

    public void Apply()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        if (this.gameObject.CompareTag("RedBox1") && isOpened == true)
        {
            player.EquipWeapon(Instantiate(knifePrefab, player.weaponPivot));
            isOpened = false;
            GameManager.Instance.weaponBoxKey = false;
        }
        else if(this.gameObject.CompareTag("RedBox2") && isOpened == true)
        {
            player.EquipWeapon(Instantiate(bowPrefab, player.weaponPivot));
            isOpened = false;
            GameManager.Instance.weaponBoxKey = false;
        }
        Destroy(gameObject);
    }
}
