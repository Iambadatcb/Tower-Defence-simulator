using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCost : MonoBehaviour
{
    public int coins;
    public int cost;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (coins >= cost)
        {
            coins -= cost;
            
        }
    }
}
