using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager Instance;

    [SerializeField] private GameObject[] enemyArray;
    [SerializeField] private List<GameObject> activeEnemyList;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        activeEnemyList = new List<GameObject>(enemyArray);
    }

    public void UnlistEnemy(GameObject enemy)
    {
      activeEnemyList.Remove(enemy);
        if (activeEnemyList.Count == 0)
        {

            StartCoroutine(Co_ResetAllEnemiesDelayed(2f));
        }
    }

    private void StartCoroutine(IEnumerable enumerable)
    {

    }

    private IEnumerable Co_ResetAllEnemiesDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        ResetAllEnemies();
    }
    private void ResetAllEnemies()
    {
        foreach (var enemy in enemyArray)
        {
            enemy.GetComponent<Enemy>().Respawn();
            activeEnemyList[0].GetComponent<Enemy>().Respawn();
        }
    }
}
