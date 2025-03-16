using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<Vector3> path;
    public float speed = 2.0f;

    private int index = 0;


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, path[index])< 0.3f)
        {
            index++;

            if (index >= path.Count)
            {
                index = 0;
            }
        }
        
        transform.LookAt(path[index]);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < path.Count-1; i++) 
        {
            Gizmos.DrawLine(path[i], path[i+1]);
        }
    }

}
