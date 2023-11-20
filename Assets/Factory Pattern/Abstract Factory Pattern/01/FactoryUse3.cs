using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //인구수를 늘리기 위한 객체 capacity를 생성한다
        RaceCapacity capacity = CapacityFactory.makeBuilding(Race.Terran);
        //건물을 짓기 위한 building 객체를 생성한다
        UnitBuilding building = UnitBuildingFactory.makeBuilding(Race.Terran);

        //expand를 호출하여 인구를 늘린다
        capacity.expand();
        //produce를 호출하여 유닛을 생성한다
        building.produce();
        
    }
   
}

/*
 - 문제점
Terran 대신 Protoss를 사용할 경우
위 예제 main 클래스에서는 코드 11,13 라인의 인수를 Race.Protoss로 바꾸면 된다

하지만 각 종족마다 건물을 훨씬 다양하게 가지고 있다면
각각의 건물마다 팩토리 클래스가 존재할 것이기에
건물의 수 만큼 줄의 내용이 바꿔야 한다

또 새로운 Zerg를 지원해야 하는 경우,
각각의 팩토리 클래스의 switch 문 마다 case Zerg: 문을 추가해줘야 한다

- 해결책

엘리베이터는 A_Company라면 모든 부품이 A_Company일 것이다
이렇게 여러 종류의 객체를 생성할 때 객체들 사이의 관련성이 있는 경우라면
각 종류별로 별도의 Factory 클래스를 사용하는 대신
관련 객체들을 일관성 있게 생성하는 추상 팩토리 패턴을 적용하는 것이 편리하다
 */
