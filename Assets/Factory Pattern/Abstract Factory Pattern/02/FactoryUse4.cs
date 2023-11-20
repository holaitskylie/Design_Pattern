using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse4 : MonoBehaviour
{    
    void Start()
    {
        RaceFactory factory = null;
        Race2 type = Race2.Protoss;

        if(type == Race2.Terran)
        {
            factory = new TerranFactory();
        }
        else if(type == Race2.Protoss)
        {
            factory = new ProtossFactory();
        }

        //하나의 팩토리 객체로 모든 건물을 다 만들 수 있다
        //factory 객체는 위에 타입에 따라서 다른 팩토리가 생성된다
        //factory의 makeCapacityBuilding이 RaceCapacity 타입의 메소드로 만들어짐
        RaceCapacity capacity = factory.makeCapacityBuilding();
        UnitBuilding building = factory.makeUnitBuilding();

        //RaceCapacity의 추상메서드 expand() 호출
        capacity.expand();
        building.produce();
        
    }
    
}

/*
 * 
 * 앞의 예제에서는 건물마다 팩토리를 만들어기 때문에 
 * 건물이 많아지면 많아질 수록 모든 코드의 Race 타입을 변경해줘야 함.
 *  RaceCapacity capacity = CapacityFactory.makeBuilding(Race.Terran);
 *  UnitBuilding building = UnitBuildingFactory.makeBuilding(Race.Terran);
 * 
 * 앞의 예제와의 차이점
 * 종족별로 Factory 클래스를 정의해 종족별 생산 건물을 아주 간단히 생성할 수 있다
 * 즉, Terran 종족을 이용할 때는 TerranFactory 객체를 생성할 수 있고
 * Protoss의 건물을 이용할 때는 ProtossFactory 객체를 생성할 수 있다
 * 
 * Terran 대신 Protoss를 사용할 경우, 10 라인의 Race 타입만 바꾸면 된다
 * Race2 type = Race2.Terran; -> Race2 type = Race2.Protoss;
 */
