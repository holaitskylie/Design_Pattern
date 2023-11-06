using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFactoryMethod2 : MonoBehaviour
{
    DatabaseFactory factory = null;
    Database db = null;

    private void Start()
    {
        factory = GetComponent<DatabaseGenerator>();

        db = factory.MakeDatabase();
        
        //Database의 추상 메서드
        db.ConnectDatabase();

        //Database의 공통 메서드
        db.InserData();
        db.SelectData();
    }
}
