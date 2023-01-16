using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalController : MonoBehaviour
{
    
    private byte _pools;
    private readonly int _balls = 144;

    void Start()
    {
        BallCheck();
    }

    private void BallCheck()
    {
        int totalBalls = _balls;
      
        for (int i = 0; i < _pools; i++)
        {
            int poolBalls = _pools;
            float ratio = (float)poolBalls / totalBalls;
           
        }
    }
}

