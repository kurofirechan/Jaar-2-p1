using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveStarter: MonoBehaviour
{
	public Transform enemyPrefab;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	private int waveIndex = 0;

	void Update (){
		if (countdown <= 0f){
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;
	}
	IEnumerator SpawnWave ()
	{
		
		for (int i = 0; i < waveNumber; i++)
		{
			SpawnEnemy ();
			yield return new WaitForSeconds(0.5f);
		}

		waveNumber++;
		}

		void SpawnEnemy ()
		{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
		}
}
