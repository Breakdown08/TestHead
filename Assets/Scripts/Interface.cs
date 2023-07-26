using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Interface : MonoBehaviour
{
    public static Interface Instance { get; private set; } // Паттерн синглтон

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 0;
    }


    public void UpdateScore()
    {
        //killedCounter.text = Game.Instance.score.ToString();
        //killedCounterGameOver.text = Game.Instance.score.ToString();
    }
}
