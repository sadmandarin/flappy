using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;

    private void Start()
    {
        StartCoroutine(SpawPipe());
    }

    IEnumerator SpawPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);

            Vector3 spawnPos = new Vector3 (5, Random.Range(-2, 2), 1);

            Instantiate(pipePrefab, spawnPos, Quaternion.identity);
        }
    }
}
