using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if( _instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if ( _instance == null )
                {
                   GameObject singletone = new GameObject(typeof(GameManager).Name);
                    _instance = singletone.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }
}
