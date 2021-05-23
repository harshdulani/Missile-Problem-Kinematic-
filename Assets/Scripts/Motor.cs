using System;
using UnityEngine;

public class Motor : MonoBehaviour
{
    public float initialVelocity;
    public float acceleration;

    private float currentVelocity;
    private static bool resultPrinted = false, targetHit;

    private void Start()
    {
        currentVelocity = initialVelocity;
    }
    
    private void FixedUpdate()
    {
        if (Time.fixedTime < Timer.predictedTime)
        {
            currentVelocity += acceleration * Time.fixedDeltaTime;
            transform.Translate(Vector3.right * currentVelocity * Time.fixedDeltaTime);
        }
        else if(!resultPrinted)
        {
            resultPrinted = true;

            Timer.MyTimer.MissileReached(Time.time);
        }
    }
}
