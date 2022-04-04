using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : Create
{


    public GameObject obstacle,coin,bomb;
    public Transform tr;
    public int NumberOfObstacle;
    public float obstacleWidth;
     int score = 0;
     public TextMeshProUGUI scoreText,lastScoreText;
   
    public float minY, maxY;


    private static Game _instance;

    void Awake()
    {

        if (_instance == null)
        {

            _instance = this;
           
            tr = obstacle.GetComponent<Transform>();
            Vector3 spawnKonum = new Vector3();
            Vector2 newScale = new Vector2();


            for (int i = 0; i < NumberOfObstacle; i++)
            {
                newScale.x = Random.Range(0.4f, 0.5f);
                newScale.y = Random.Range(0.4f, 0.5f);

                tr.localScale = newScale;

                spawnKonum.y += Random.Range(minY, maxY);
                spawnKonum.x = Random.Range(-obstacleWidth, obstacleWidth);

                
                createObstacle(obstacle, spawnKonum);
                int rand = Random.Range(1, 4);
                if (rand == 1 || rand == 2)
                {
                    createCoin(coin, spawnKonum + new Vector3(0, 1, 0));
                   
                }

                if (rand == 3)
                {
                    createBomb(bomb, spawnKonum + new Vector3(0, 1, 0));

                }

            }

        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {

    }

    public void newGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

   
    void Update()
    {
        if(Time.timeScale ==1)
        {
            score += 1;
            scoreText.text = score.ToString();
        }
        else
        {
            lastScoreText.text = score.ToString();
        }
        

    }

   
}
