using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool weaponBoxKey = false;
    public static GameManager Instance { get; private set; }


    private void Awake()
    {
        Time.timeScale = 1f;
        if (Instance == null)
        {
            Instance = this; 
            DontDestroyOnLoad(gameObject); // 씬 전환시 파괴되지 않음
        }
        else
        {
            Destroy(gameObject);
        }
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
