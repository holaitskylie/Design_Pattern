using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the 'Product A1' class
/// </summary>

//RaceCapacity�� MonoBehaviour�� ��� �޾ұ� ������
//Start(), Update() �޼��带 ����� �� �ִ�
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
