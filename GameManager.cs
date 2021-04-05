using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    public float time;
   
    public static GameManager Instance { get; private set; }
    public GameObject player1;
    public GameObject player2;
    public GameObject WinPlay, WinPlay2, WinPlay3;
    public GameObject foodSpawn;
    public GameObject WonPlayer2, WonPlayer1, TieWin;
    public Text TimeAmount;
    public bool EndGameDone;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        EndGameDone = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        time -= 1 * Time.deltaTime;
        TimeAmount.text = time.ToString("F0");
        if (time <= 0)
        {
            if (EndGameDone == false)
            {
                EndGame();
            }
        }
    }
    void EndGame()
    {
        EndGameDone = true;
        if (player1.GetComponent<FoodCollect>().Score > player2.GetComponent<FoodCollect>().Score)
        {
            print("Player 1 won");
            WonPlayer1.SetActive(true);
            Time.timeScale = 0f;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(WinPlay);
        }

        if (player1.GetComponent<FoodCollect>().Score < player2.GetComponent<FoodCollect>().Score)
        {
            print("Player 2 won");
            WonPlayer2.SetActive(true);
            Time.timeScale = 0f;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(WinPlay2);

        }
        if (player1.GetComponent<FoodCollect>().Score == player2.GetComponent<FoodCollect>().Score)
        {
            print("its a tie");
            TieWin.SetActive(true);
            Time.timeScale = 0f;
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(WinPlay3);
        }
        

    }
    
}
