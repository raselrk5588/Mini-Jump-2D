using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject uIManager;
    public GameObject GameManager;
    
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "DoraPlay")
        {
            Debug.Log("Game Over");
            uIManager.SetActive(true);
            GameManager.SetActive(false);
        }
    }
}