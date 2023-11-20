using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethodUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*RaceFactory factory = null;
        Race2 type = Race2.Protoss;

        if (type == Race2.Terran)
        {
            factory = new TerranFactory();
        }
        else if (type == Race2.Protoss)
        {
            factory = new ProtossFactory();
        }*/

        //Race2 type = Race2.Protoss; 처럼
        //생성하고자하는 종족의 type이 Terran인지 Protoss인지 클라이언트 코드는 몰라도 된다
        //클라이언트 코드는 사용만 할 뿐 실질적인 생산은 서브 클래스에서 한다

        //FactoryMethod 클래스는 정적 클래스로 만들어 바로 사용해도 된다
        FactoryMethod factoryMethod = new FactoryMethod();

        //FactoryMethod에는 RaceFactory 타입의
        //타입별로 종족 팩토리 메서드를 실행하는 getFactory() 메소드를 가지고 있다
        RaceFactory factory = factoryMethod.getFactory();

        //하나의 팩토리 객체로 모든 건물을 다 만들 수 있다
        RaceCapacity capacity = factory.makeCapacityBuilding();
        UnitBuilding building = factory.makeUnitBuilding();

        capacity.expand();
        building.produce();
    }

   
}
/*
팩토리 메서드 패턴 적용 전 후 차이는 별로 없으나
종족별 Factory 객체를 생성하는 방식을 캡슐화 했다는 점이 다르다
*/