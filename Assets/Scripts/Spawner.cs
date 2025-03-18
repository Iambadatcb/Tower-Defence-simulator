using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform target;
    public GameObject enemyPrefab;

    [Header("Endless mode setings")]
    public bool endless;
    public float endlessCooldown = 2;

    [Header("Wave Settings")]
    public float count = 5;
    public float cooldown = 1;
    public int waveCount = 10;
    public float waveCooldown = 5;
    
    void Start()
    {
        if (endless)
        {
            InvokeRepeating("EndlessSpawn", 0, endlessCooldown);
        }
        else
        {
            StartCoroutine(Wave());
        }
    }


    IEnumerator Wave()
    {

        for(int i = 0; i < waveCount; i++)
        {
            for (int w = 0; w < count; w++)
            {
                EndlessSpawn();
                yield return new WaitForSeconds(cooldown);
            }

            yield return new WaitForSeconds(waveCooldown);
        }
    }

    
    void EndlessSpawn()
    {
        var enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        enemy.GetComponent<Enemy>().target = target;
    }
   
        
   
}
