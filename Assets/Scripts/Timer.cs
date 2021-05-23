using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer MyTimer;

    public static float predictedTime;
    public Motor objA, objB; //objA = Target, objB = Missile

    [Header("Can be decreased for increasing accuracy, but not recommended")]
    public float timeStep = 0.02f;

    [Header("Canvas")]
    public Text targetInfo;
    public Text missileInfo, reachedInfo, predictedInfo;
    public GameObject panel;

    private void Awake()
    {
        if(MyTimer == null)
            MyTimer = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        Time.fixedDeltaTime = timeStep;

        //calculating distance between objects
        float h = objA.transform.position.x - objB.transform.position.x;

        //calculating for solving quadratic equation
        float a = objB.acceleration - objA.acceleration;
        float b = 2 * (objB.initialVelocity - objA.initialVelocity);
        float c = -2 * h;

        predictedTime = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);

        predictedInfo.text = "Predicted ETA = " + predictedTime;

        panel.SetActive(false);
        SetObjectInfo("Missile", missileInfo);
        SetObjectInfo("Target", targetInfo);
    }

    private void SetObjectInfo(string motorType, Text texter)
    {
        foreach(var player in GameObject.FindGameObjectsWithTag("Player"))
        {
            if(player.name.Equals(motorType))
            {
                texter.text = "Missile Info:\nInitial Velocity : " + player.GetComponent<Motor>().initialVelocity + " m/s2";
                texter.text += "\nAcceleration : " + player.GetComponent<Motor>().acceleration + " m/s2";
                return;
            }
        }
    }

    public void MissileReached(float time)
    {
        reachedInfo.text = "Missile Reached Target in " + time;
    }
}
