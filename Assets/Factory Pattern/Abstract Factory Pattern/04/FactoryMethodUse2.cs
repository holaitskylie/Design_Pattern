using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FactoryMethodUse2 : MonoBehaviour
{
    RaceFactory2 factory = null;
   
    void Start()
    {
        factory = GetComponent<FactoryMethod2>().getFactory();

        //getFactory()�� Ÿ�Կ� ���� Terran/Protoss Ÿ���� ���� ����
        //factory = GetComponent<Terran / ProtossFactory>();
        //<Terran/ProtossFactory>����
        //makeCapacityBuilding(), makeUnitBuilding() �޼��带 ����
        GameObject capacity = factory.makeCapacityBuilding();
        GameObject building = factory.makeUnitBuilding();

        capacity.GetComponent<RaceCapacity2>().expand();
        building.GetComponent<UnitBuilding2>().produce();
        
    }

    
}
