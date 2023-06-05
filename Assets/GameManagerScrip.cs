using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScrip : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameManagerScrip instance;
    [SerializeField] Text curScore;
    // Start is called before the first frame update
    void Awake() { instance = this; }
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(GameManager.instance.health.healthCount == 0)
        {
            gameOver();
        }
      
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        curScore.text = GameManager.instance.score.score.ToString();
        Time.timeScale = 0f;
    }
}
