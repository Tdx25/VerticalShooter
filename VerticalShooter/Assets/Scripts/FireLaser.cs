using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    [SerializeField] private Transform spawnLocation;

    [SerializeField] private GameObject laserPrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    private void Fire()
    {

        Instantiate(laserPrefab, spawnLocation.position, spawnLocation.rotation);
    }
}
