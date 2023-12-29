using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSystem : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject enemy1;

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

            int spawnPos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos1 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos1].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos2 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos2].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos3 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos3].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos4 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos4].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            wave++;
        }

        if (wave == 2)
        {
            yield return new WaitForSeconds(20);

            waveText.text = "Wave " + wave;
            anim.SetTrigger("Popup");

            yield return new WaitForSeconds(2);

            int spawnPos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos1 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos1].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos2 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos2].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos3 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos3].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos4 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos4].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos5 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos5].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos6 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos6].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos7 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos7].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos8 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos8].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            int spawnPos9 = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy1, spawnPoints[spawnPos9].position, Quaternion.identity);
            yield return new WaitForSeconds(1);

            wave++;
        }

        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnEnemies());
    }
}
