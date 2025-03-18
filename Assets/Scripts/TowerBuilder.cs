using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerBuilder : MonoBehaviour
{
    public LayerMask buildableGround;
    public Transform cursor;
    public GameObject towerPrefab;

    [Header("Tower cost")]
    public int coins;
    public int cost;
    private Health death;

    
    void Update()
    {
        //coins++;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            cursor.position = hit.point;
            if (coins >= cost)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(towerPrefab, cursor.position, cursor.rotation);
                    coins -= cost;
                }
            }
            else if (coins < cost)
            {
                print("Not enough coins");
            }
        }
            if (death.onDeath!= null )
            {
                coins += 50;
            }

    }
}
