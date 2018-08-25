using System;
using UnityEngine;

public class Clock : MonoBehaviour
{

    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;




    void Update()
    {
        DateTime time = DateTime.Now;
        secondsTransform.localRotation =
           Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
        minutesTransform.localRotation =
            Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
    }


}
