using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���丮 �޼��尡 ���� ��ũ��Ʈ
//���� ����ϴ� �ڵ�� FactoryMethodUse.cs

public class FactoryMethod2 : MonoBehaviour
{
    public Race_2 type = Race_2.Terran;

    public RaceFactory2 getFactory()
    {
        RaceFactory2 facotry = null;

        switch (type)
        {
            case Race_2.Terran:
                //factory = new TerranFactory();
                facotry = GetComponent<TerranFactory2>();
                break;
            case Race_2.Protoss:
                //factory = new ProtossFactory();
                facotry = GetComponent<ProtossFactory2>();
                break;
        }

        return facotry;
    }
}