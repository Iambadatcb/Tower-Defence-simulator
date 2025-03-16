using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float cooldown=2;

    private List<GameObject> enemies = new();
    
    void Start()
    {
        InvokeRepeating("Shoot",0,cooldown);
    }

    void Shoot(){
        enemies.RemoveAll(enemy=> enemy==null);

        if(enemies.Count <=0)return;

        var bullet=Instantiate(bulletPrefab,bulletSpawn.position,bulletSpawn.rotation);
        bullet.GetComponent<Bullet>().target = enemies[0].transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Enemy")){
            enemies.Add(other.gameObject);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.transform.CompareTag("Enemy")){
            enemies.Remove(other.gameObject);
        }
    }
}
