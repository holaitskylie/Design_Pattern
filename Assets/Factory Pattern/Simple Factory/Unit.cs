using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상 클래스 Unit
public abstract class Unit
{
    //추상 메소드 move
    public abstract void move();
}

//추상 클래스 Unit을 상속 받은 클래스들은
//Unit 클래스의 추상 메소드 move()를 반드시 구현해야 한다
public class Marine : Unit
{
    //생성자
    public Marine()
    {
        Debug.Log("Marine 생성!!");
    }

    //상속받은 추상 메서드 move()를 오버라이드하여 구현
    public override void move()
    {
        Debug.Log("Marine 이동!!");
    }
}

public class Firebat : Unit
{
    public Firebat()
    {
        Debug.Log("Firebat 생성!!");
    }

    public override void move()
    {
        Debug.Log("Firebat 이동!!");
    }
}

public class Medic : Unit
{
    public Medic()
    {
        Debug.Log("Medic 생성!!");
    }

    public override void move()
    {
        Debug.Log("Medic 이동!!");
    }
}

