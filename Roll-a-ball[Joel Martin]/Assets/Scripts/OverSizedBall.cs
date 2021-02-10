using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverSizedBall : MonoBehaviour
{
    public GameObject Ball;
    public void chengeScale(bool overSized)
    {
        if (overSized == true)
            Ball.transform.localScale = new Vector3(2, 2, 2);
        if (overSized == false)
            Ball.transform.localScale = new Vector3(1, 1, 1);
    }
}
