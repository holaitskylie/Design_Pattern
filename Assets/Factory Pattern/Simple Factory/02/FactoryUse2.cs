using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse2 : MonoBehaviour
{
    FactoryUnit factory = null;
    GameObject unit1 = null;
    GameObject unit2 = null;
    GameObject unit3 = null;

    private void Start()
    {
        factory = GetComponent<FactoryUnit>();

        unit1 = factory.createUnit(UnitType2.Marine);
        unit2 = factory.createUnit(UnitType2.Firebat);
        unit3 = factory.createUnit(UnitType2.Firebat);

        StartCoroutine("UnitAction");
    }

    IEnumerator UnitAction()
    {
        yield return new WaitForSeconds(0.2f);

        //추상클래스 Unit을 이용하여 Marine, Firebat의 구분 없이 접근하여 사용할 수 있다
        //Unit의 move()호출
        unit1.GetComponent<Unit2>().move2();
        unit2.GetComponent<Unit2>().move2();
        unit3.GetComponent<Unit2>().move2();
    }
}
