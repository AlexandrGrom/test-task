using System;
using UnityEngine;

public class TimeParser : MonoBehaviour
{
    [SerializeField] private Transform t;
    private void Awake()
    {
        TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTime gmtTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, gmtTimeZone);
        
        Debug.Log("Current Time in GMT: " + gmtTime.Hour);
        t.rotation = Quaternion.Euler(0f, 360f / gmtTime.Hour, 0f);
    }
}
