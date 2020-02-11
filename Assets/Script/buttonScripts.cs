using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScripts : MonoBehaviour
{
    public GameObject BallPrefab;
    public GameObject Triangle;
    public GameObject Diamond;
    public GameObject Polygon;
    public GameObject Rect;



    public void Button_Spin()
    {
        Triangle.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x , Triangle.transform.eulerAngles.y , Triangle.transform.eulerAngles.z + 45);
        Diamond.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, Triangle.transform.eulerAngles.z + 45);
        Polygon.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, Triangle.transform.eulerAngles.z + 45);
        Rect.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, Triangle.transform.eulerAngles.z + 45);
    }

    public void Button_Shrink()
    {
   
        
         Triangle.transform.localScale = new Vector3(Triangle.transform.localScale.x - .5f, Triangle.transform.localScale.y, Triangle.transform.localScale.z);
         Diamond.transform.localScale = new Vector3(Triangle.transform.localScale.x - .5f, Triangle.transform.localScale.y, Triangle.transform.localScale.z);
         Polygon.transform.localScale = new Vector3(Triangle.transform.localScale.x - .5f, Triangle.transform.localScale.y, Triangle.transform.localScale.z);
         Rect.transform.localScale = new Vector3(Triangle.transform.localScale.x - .5f, Triangle.transform.localScale.y, Triangle.transform.localScale.z);
    }

    public void Button_Reset()
    {
        //Reset angles
        Triangle.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, 20.312f);
        Diamond.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, 26.93f);
        Polygon.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, 0);
        Rect.transform.eulerAngles = new Vector3(Triangle.transform.eulerAngles.x, Triangle.transform.eulerAngles.y, 19.026f);

        //Reset Scale
        Triangle.transform.localScale = new Vector3(2.507985f, 2.292944f, 1.9183f);
        Diamond.transform.localScale = new Vector3(1.7796f, 1.7796f, 1.7796f);
        Polygon.transform.localScale = new Vector3(2.1703f, 2.1703f, 2.1703f);
        Rect.transform.localScale = new Vector3(2.95f, 1f, 1f);
    }
}
