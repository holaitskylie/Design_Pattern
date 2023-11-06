using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Database
{
    public string name;
    public double rows;

    //추상메서드
    public abstract void ConnectDatabase();

    //공통 메서드
    public void InserData()
    {
        Debug.Log(name + " 에 데이터를 추가했습니다");
    }

    public void SelectData()
    {
        Debug.Log(name + " 에서 데이터를 " + rows + "개 조회했습니다.");
    }
}

//추상 클래스 Database를 상속받은 하위 클래스
public class MySQL : Database
{   
    public MySQL()
    {
        name = "MySQL";
        rows = 20;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다.");

    }
}

public class Oracle : Database
{
    public Oracle()
    {
        name = "Oracle";
        rows = 10;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다.");
    }
}

public class Infomix : Database
{
    public Infomix()
    {
        name = "Infomix";
        rows = 40;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " 에 접속했습니다.");
    }
}