using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
    Marine,
    Firebat,
    Medic,
}

//UnitFactory 클래스는 입력값에 따라 무언가를 계속 생산하는 팩토리 클래스
public class UnitFactory
{
    //createUnit(UnitType type)
    //주어진 입력값에 따라 다른 유형의 객체를 반환하는 메소드
    //여러 가지 객체 생성을 한 곳에 모은다는 의미
    public static Unit createUnit(UnitType type)
    {
        Unit unit = null;

        switch (type)
        {
            case UnitType.Marine:
                unit = new Marine();
                break;
                case UnitType.Firebat:
                unit = new Firebat();
                break;
                case UnitType.Medic:
                unit = new Medic();
                break;
        }

        return unit;
    }
}