using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] float  minTime, MaxTime;
    float speed =3.5f;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        StartCoroutine(spawnEnemy());
    }
    IEnumerator spawnEnemy()
    {
        yield return new WaitForSeconds(Random.Range(minTime, MaxTime));
        GameObject e = Instantiate(enemy, transform.position, Quaternion.identity);
        e.AddComponent<moveEnemy>();
        e.GetComponent<moveEnemy>().speed = speed+=0.3f;
        Destroy(e, 8f);
        StartCoroutine(spawnEnemy());
    }
}
