using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FactoryMethodUse2 : MonoBehaviour
{
    RaceFactory2 factory = null;
   
    void Start()
    {
        factory = GetComponent<FactoryMethod2>().getFactory();

        //getFactory()의 타입에 따라 Terran/Protoss 타입의 참조 생성
        //factory = GetComponent<Terran / ProtossFactory>();
        //<Terran/ProtossFactory>에는
        //makeCapacityBuilding(), makeUnitBuilding() 메서드를 가짐
        GameObject capacity = factory.makeCapacityBuilding();
        GameObject building = factory.makeUnitBuilding();

        capacity.GetComponent<RaceCapacity2>().expand();
        building.GetComponent<UnitBuilding2>().produce();
        
    }

    
}
