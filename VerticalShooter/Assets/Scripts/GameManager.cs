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
        enemyArray = new GameObject.FindGameObjectsWithTag("Enemy");
        activeEnemyList = new List<GameObject>(enemyArray);
    }

    public void UnlistEnemy(GameObject enemy)
    {
        activeEnemyList.Remove(enemy);
    }
}
