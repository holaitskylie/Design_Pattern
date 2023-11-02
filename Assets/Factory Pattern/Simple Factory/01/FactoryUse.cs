using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//심플팩토리를 사용하기 위한 클래스
public class FactoryUse : MonoBehaviour
{   
    void Start()
    {
        //UnitFactory : 심플팩토리
        //createUnit : 심플팩토리 안의 메소드 호출
        Unit unit1 = UnitFactory.createUnit(UnitType.Marine);
        Unit unit2 = UnitFactory.createUnit(UnitType.Firebat);
        Unit unit3 = UnitFactory.createUnit(UnitType.Medic);

        //생성한 객체의 move() 메서드 호출
        unit1.move();
        unit2.move();
        unit3.move();
        
    }

}
