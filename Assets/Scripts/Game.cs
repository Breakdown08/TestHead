using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; } // реализация паттерна синглтон
    [Header("Префабы противников")] public List<GameObject> enemyList;
    [Header("Префабы бустеров")] public List<GameObject> boosterList;
    [Header("Максимальное количество противников на карте")] public int maxEnemyCount = 2;
    [Header("Заработано очков")] public int score = 0;
    [Header("Игра окончена")] public bool isGameOver = true;
    [Header("Имя игрока")] public InputField playerName;
    public bool isFirstEntryGame = true;
    private float flashEffect = 0f;
    private float spawnSpeed = 10f;
    public float movementEnemySpeed = 10f;
    public float maxEnemyHealth = 10f;
    public bool canSpawn = true;

    private void Awake()
    {
        Instance = this; // присваеваем объект самого себя в статичное свойство синглтона
    }

    private void Start()
    {
        //Interface.Instance.ActivateMenu();
    }


    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }


    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            /*
            if (isGameOver == false && Time.timeScale == 1)
            {
                GameObject enemyInstance;
                int spawnPoint = System.Convert.ToInt32(UnityEngine.Random.Range(0, spawnPoints.transform.childCount));
                int enemyIndex = System.Convert.ToInt32(UnityEngine.Random.Range(0, enemyList.Count));
                int waitTime = System.Convert.ToInt32(UnityEngine.Random.Range(0, 7));
                yield return new WaitForSeconds(waitTime + spawnSpeed);
                if (canSpawn)
                {
                    enemyInstance = Instantiate(enemyList[enemyIndex], spawnPoints.transform.GetChild(spawnPoint).transform.position, Quaternion.Euler(0f, 0f, 0f)) as GameObject;
                    enemyInstance.transform.SetParent(aliveEnemyStorage.transform, false);
                    enemyInstance.transform.position = spawnPoints.transform.GetChild(spawnPoint).transform.position;
                }
                StartCoroutine(SpawnEnemy());
            }
            */
            yield break;
        }
    }


    public void Restart()
    {
        /*
        if (Interface.Instance.continueGameText.activeSelf == false)
        {
            player.GetComponent<Player>().SetDefaultPosition();
            Time.timeScale = 1;
            isFirstEntryGame = false;
            
            if (GetEnemyCount() > 0)
            {
                foreach (Transform child in aliveEnemyStorage.transform) 
                {
                    Destroy(child.gameObject);
                }
            }
            isGameOver = false;
            StartCoroutine(SpawnEnemy());
        }
        else
        {

        }
        Interface.Instance.OpenGame();
        */
    }

    public void Exit()
    {
        Application.Quit();
    }
}