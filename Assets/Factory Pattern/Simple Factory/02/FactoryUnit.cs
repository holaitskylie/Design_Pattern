using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UniType
{
    Marine,
    Firebat,
}

//FactoryUnit : 심플팩토리 패턴 클래스
public class FactoryUnit : MonoBehaviour
{
    public GameObject marine = null;
    public GameObject firebat = null;

    //주어진 입력을 기반으로 다른 유형의 객체를 반환하는 createUnit() 메소드
    public GameObject createUnit(UnitType type)
    {
        //Unit unit = null;
        GameObject unit = null;

        float x = (float)Random.Range(0, 6);
        float z = (float)Random.Range(0, 6);

        //들어온 타입에 따라 프리팹을 생성한다
        switch (type)
        {
            case UnitType.Marine:
                //unit = new Marine();
                unit = Instantiate(marine, new Vector3(x,1.0f,z), Quaternion.identity);
                break;

            case UnitType.Firebat:
                //unit = new Firebar();
                unit = Instantiate(firebat, new Vector3(x,0.5f,z), Quaternion.identity);
                break;

        }

        return unit;
    }
}