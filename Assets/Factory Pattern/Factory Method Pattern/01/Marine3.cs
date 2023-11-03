using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Marine3 : Unit3
{
    //생성자
    public Marine3()
    {
        type = UnitType3.Marine;
        name = "Marine";
        hp = 100;
        exp = 50;

        Debug.Log(this.name + " : 생성!!");
    }

    //추상 메서드 오버라이드
    public override void Attack()
    {
        //Attack() 구현
        Debug.Log(this.name + " :공격!!");
    }
}
