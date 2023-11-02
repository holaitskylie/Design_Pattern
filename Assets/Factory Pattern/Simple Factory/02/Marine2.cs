using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine2 : Unit2
{
    void Start()
    {
        Debug.Log("Marine 생성!!");
    }

    public override void move2()
    {
        Debug.Log("Marine 이동!!");
    }
}
