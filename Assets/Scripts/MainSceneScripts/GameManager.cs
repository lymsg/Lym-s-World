using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool weaponBoxKey = false;
    public Image closedBoxImage;
    public Image openBoxImage;
    public static GameManager Instance { get; private set; }

    [SerializeField] private AnimationHandler animationHandler;


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
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        closedBoxImage = GameObject.Find("ClosedBoxImage").GetComponent<Image>();
        openBoxImage = GameObject.Find("OpenBoxImage").GetComponent<Image>();
        animationHandler = FindObjectOfType<AnimationHandler>();
    }

    void Start()
    {
        animationHandler = FindObjectOfType<AnimationHandler>();
        if (animationHandler == null)
        {
            Debug.LogWarning("AnimationHandler를 씬에서 찾지 못했습니다!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponBoxKey == false && closedBoxImage != null && openBoxImage != null)
        {
            closedBoxImage.gameObject.SetActive(true);
            openBoxImage.gameObject.SetActive(false);
        }
        else if(weaponBoxKey == true && closedBoxImage != null && openBoxImage != null)
        {
            animationHandler.SetIsOpen(true);
            closedBoxImage.gameObject.SetActive(false);
            openBoxImage.gameObject.SetActive(true);
        }
    }
    
}
