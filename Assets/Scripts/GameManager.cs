using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public GameObject winCon;
    public TMP_Text txtWin;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            WinCondition("Player L Win!");
        }
        else if (PlayerScoreR == 20)
        {
            WinCondition("Player R Win!");
        }
    }

    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            //StartCoroutine(ShakeCam(0.7f));
            PlayerScoreR = PlayerScoreR + 10; //menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            //StartCoroutine(ShakeCam(0.7f));
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }

    private void WinCondition(string text)
    {
        winCon.SetActive(true);
        txtWin.text = text;
        Time.timeScale = 0;
    }
}