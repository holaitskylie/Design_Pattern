using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���丮 �޼��尡 ���� ��ũ��Ʈ
//���� ����ϴ� �ڵ�� FactoryMethodUse.cs

public class FactoryMethod : MonoBehaviour
{
    public Race2 type = Race2.Terran;

    public RaceFactory getFactory()
    {
        RaceFactory facotry = null;

        switch (type)
        {
            case Race2.Terran:
                facotry = new TerranFactory();
                break;
            case Race2.Protoss:
                facotry = new ProtossFactory();
                break;
        }

        return facotry;
    }
}
