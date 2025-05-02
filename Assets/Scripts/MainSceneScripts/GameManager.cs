using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool weaponBoxKey = false;
    public GameObject flappyEnter;
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        Time.timeScale = 1f;
        if (Instance == null)
        {
            Instance = this; // 이 객체를 인스턴스로 설정
            DontDestroyOnLoad(gameObject); // 씬 전환시 파괴되지 않음
        }
        else
        {
            // 이미 인스턴스가 존재하면 이 객체를 파�
            Destroy(gameObject);
        }
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (weaponBoxKey)
        //{
        //    flappyEnter.SetActive(false);
        //}
    }
}
