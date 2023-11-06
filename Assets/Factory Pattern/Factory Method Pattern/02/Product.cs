using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Database
{
    public string name;
    public double rows;

    //�߻�޼���
    public abstract void ConnectDatabase();

    //���� �޼���
    public void InserData()
    {
        Debug.Log(name + " �� �����͸� �߰��߽��ϴ�");
    }

    public void SelectData()
    {
        Debug.Log(name + " ���� �����͸� " + rows + "�� ��ȸ�߽��ϴ�.");
    }
}

//�߻� Ŭ���� Database�� ��ӹ��� ���� Ŭ����
public class MySQL : Database
{   
    public MySQL()
    {
        name = "MySQL";
        rows = 20;
    }

    public override void ConnectDatabase()
    {
        Debug.Log(name + " �� �����߽��ϴ�.");

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
        Debug.Log(name + " �� �����߽��ϴ�.");
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
        Debug.Log(name + " �� �����߽��ϴ�.");
    }
}