using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race
{
    Terran,
    Protoss,
    Zerg
}

//직접적으로 new를 통해 객체를 만드는 것이 아닌
//팩토리를 통해서 객체 생성
//해당 객체와 직접적인 의존도가 낮아지기 때문에 나주엥 코드를 수정할 일이 적어진다
public class CapacityFactory
{
    public static RaceCapacity makeBuilding(Race type)
    {
        RaceCapacity capacity = null;

        switch (type)
        {
            case Race.Terran:
                capacity = new SupplyDepot();
                break;
            case Race.Protoss:
                capacity = new Pylon();
                break;
        }

        return capacity;
    }
}

public class UnitBuildingFactory
{
    public static UnitBuilding makeBuilding(Race type)
    {
        UnitBuilding building = null;

        switch(type)
        {
            case Race.Terran:
                building = new Barracks();
                break;
            case Race.Protoss:
                building = new Gateway();
                break;
        }

        return building;
    }

}