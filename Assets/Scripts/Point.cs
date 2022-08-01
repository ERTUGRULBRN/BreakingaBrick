using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private int point;
   public void PointUP()
    {
        point++;
    }
    public int PointGET()
    {
        return point;
    }
    public void ResetScore()
    {
        point = 0; 
    }
}
