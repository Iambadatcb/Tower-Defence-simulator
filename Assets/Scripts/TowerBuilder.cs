using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerBuilder : MonoBehaviour
{
    public LayerMask buildableGround;
    public Transform cursor;
    public GameObject towerPrefab;

    
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            cursor.position = hit.point;

            if(Input.GetMouseButtonDown(0)){
                Instantiate(towerPrefab, cursor.position, cursor.rotation);
            }
        }
    }
}
