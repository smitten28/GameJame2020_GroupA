﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapSpawnScriptF : MonoBehaviour
{
    [SerializeField]
    private GameObject scrapPiece;
    [SerializeField]
    private float collectableCount;
    [SerializeField]
    private Vector2[] range;

    // Start is called before the first frame update
    void Start()
    {
        SpawnScrap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnScrap()
    {
        float randX;
        float randY;

        for(int i = 0; i < collectableCount; i++)
        {
            randX = Random.Range(range[0].x, range[1].x);
            randY = Random.Range(range[0].y, range[1].y);
            Instantiate(scrapPiece, new Vector3(randX, randY, 0), Quaternion.identity);
        }
    }
}
