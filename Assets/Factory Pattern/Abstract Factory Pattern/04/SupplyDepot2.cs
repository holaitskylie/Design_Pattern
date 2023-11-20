using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the 'Product A1' class
/// </summary>

//RaceCapacity가 MonoBehaviour를 상속 받았기 때문에
//Start(), Update() 메서드를 사용할 수 있다
public class SupplyDepot2 : RaceCapacity2
{
    public override void expand()
    {
        Debug.Log("Terran Capacity +8 !!!");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
