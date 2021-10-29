using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class WaveSpawner : MonoBehaviour


{
    public TextMeshProUGUI newRoundText;
    public Transform spawnPoint;
    public rounds[] round;
    [Space(5)]
    public int curentRound;
    private bool canSpawn;
    private bool isFinished;
    private void Start()
    {
        canSpawn = true;
    }
    void Update()
    {
        if (canSpawn && !isFinished)
        {
            StartCoroutine(NewRound());
        }
    }
    public IEnumerator NewRound()
    {
        canSpawn = false;
        curentRound++;
        yield return new WaitForSeconds(2);
        if (curentRound >= round.Length)
        {
            EndGame();
            yield return new WaitForSeconds(0);
        }
        for (int i = 0; i < round[curentRound].enemies.Length; i++)
        {
            for (int ii = 0; ii < round[curentRound].enemies[i].amount; ii++)
            {
                Spawn(round[curentRound].enemies[i].spawnItem, spawnPoint.position);
                yield return new WaitForSeconds(4);
            }
            yield return new WaitForSeconds(2.5f);
        }
        yield return new WaitForSeconds(round[curentRound].roundDuration);
        canSpawn = true;
    }
    public void EndGame()
    {
        isFinished = true;
        SceneManager.LoadScene(0);
    }
    public void Spawn(GameObject _object, Vector3 pos)
    {
        Instantiate(_object, pos, Quaternion.identity);
    }

    [System.Serializable]
    public struct rounds
    {
        public int round;
        public float roundDuration;
        public enemies[] enemies;
    }
    [System.Serializable]
    public struct enemies
    {
        public GameObject spawnItem;
        public int amount;
    }
}