using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject prefabSpawnPoint;
    [SerializeField] private GameObject prefabEnemy;
    [SerializeField] private GameObject panelNeyDay;
    [SerializeField] private TextMeshProUGUI panelNeyDayDate;
    [SerializeField] private TextMeshProUGUI dateNow;
    [SerializeField] private Slider progressDay;
    private List<Transform> pointSpawn = new List<Transform>();

    private int day = 1;
    private int spawnTime = 4;
    private int startCountEnemy = 7;
    private int enemyLevel1=0;
    private int enemyLevel2=0;
    private int enemyLevel3 = 0;

    private int sizeX = 10;

    private void Start()
    {
        enemyLevel1 = startCountEnemy;
        GenerateSpawnPoint();
        dateNow.text = day.ToString();
    }

    public void StartGame()
    {
        StartCoroutine(Spwner());
    }

    private IEnumerator Spwner()
    {
        progressDay.maxValue = enemyLevel1 + enemyLevel2 + enemyLevel3;
        progressDay.value = 0;
        yield return new WaitForSeconds(spawnTime);
        for(int i = 0; i < enemyLevel1; i++)
        {
            Spawn(1);
            yield return new WaitForSeconds(spawnTime);
        }
        for(int i = 0; i < enemyLevel2; i++)
        {
            Spawn(2);
            yield return new WaitForSeconds(spawnTime);
        }
        for(int i = 0; i < enemyLevel3; i++)
        {
            Spawn(3);
            yield return new WaitForSeconds(spawnTime);
        }
        yield return new WaitForSeconds(2);
        ChangeDay();
    }

    private void ChangeDay()
    {
        panelNeyDay.SetActive(true);
        panelNeyDayDate.text = (day+1).ToString();
    }

    public void ChangeCountEnemy()
    {
        day++;
        dateNow.text = day.ToString();
        if (day < 3)
        {
            enemyLevel1+=2;
        }
        else if (day < 7)
        {
            enemyLevel2 += 2;
        }
        else
        {
            enemyLevel3 += 2;
        }
        StartCoroutine(Spwner());
    }
    private void GenerateSpawnPoint()
    {
        float stepX = 20f / (sizeX - 3f);

        for (int i = 0; i < sizeX; i++)
        {
            float posX = -12 + i * stepX;
            Vector3 position = new Vector3(posX, -14, 0);
            GameObject point = Instantiate(prefabSpawnPoint, position, Quaternion.identity);
            pointSpawn.Add(point.transform);
        }
    }

    private void Spawn(int levelEnemy)
    {
        GameObject enemy = Instantiate(prefabEnemy, pointSpawn[Random.Range(0, pointSpawn.Count)].position, Quaternion.identity);
        progressDay.value++;
    }
}
