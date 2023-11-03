using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Firebat3 : Unit3
{
    public Firebat3()
    {
        type = UnitType3.Firebat;
        name = "Firebat";
        hp = 120;
        exp = 15;

        Debug.Log(this.name + " : 생성!!");
    }

    public override void Attack()
    {
        Debug.Log(this.name + " : 공격");
    }
}
