using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSystem : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject enemy1, enemy2;

    int wave = 0;

    public TMP_Text waveText;
    public Animator anim;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        if (wave == 0)
        { 
            wave++;
        }

        if (wave == 1)
        {
            yield return new WaitForSeconds(10);

            waveText.text = "Wave " + wave;
            anim.SetTrigger("Popup");

            yield return new WaitForSeconds(2);

            for (int i = 0; i < 5; i++)
            {
                int spawnPos = Random.Range(0, spawnPoints.Length);
                Instantiate(enemy1, spawnPoints[spawnPos].position, Quaternion.identity);
                yield return new WaitForSeconds(1);
            }

            wave++;
        }

        if (wave == 2)
        {
            yield return new WaitForSeconds(20);

            waveText.text = "Wave " + wave;
            anim.SetTrigger("Popup");

            yield return new WaitForSeconds(2);

            for (int i = 0; i < 7; i++)
            {
                int spawnPos = Random.Range(0, spawnPoints.Length);
                Instantiate(enemy1, spawnPoints[spawnPos].position, Quaternion.identity);
                yield return new WaitForSeconds(1);

                if (i % 2 == 0)
                {
                    int spawnPos2 = Random.Range(0, spawnPoints.Length);
                    Instantiate(enemy2, spawnPoints[spawnPos2].position, Quaternion.identity);
                    yield return new WaitForSeconds(1);
                }

            }

            wave++;
        }

        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnEnemies());
    }
}
