using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Platform;
    float maxY = 1.5f;
    float miniY = 0.3f;
    int TotalPlatform = 200;

    float distance = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 span = new Vector3();
        for (int i = 0; i < TotalPlatform; i++)
        {
            span.y += Random.Range(miniY, maxY);
            span.x = Random.Range(distance, -distance);
            Instantiate(Platform, span, Quaternion.identity);
        }
    }


}
