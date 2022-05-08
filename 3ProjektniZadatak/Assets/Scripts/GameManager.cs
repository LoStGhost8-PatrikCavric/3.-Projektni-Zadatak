using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject GameUI;
    public GameObject PauseUI;
    public GameObject InventoryUI;
    public int coins = 0;
    public int health = 0;
    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(gameObject); 
        }
    }
}
