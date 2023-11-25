using System;
using UnityEngine;

public class TimeParser : MonoBehaviour
{
    [SerializeField] private Transform arrowH;
    [SerializeField] private Transform arrowM;
    [SerializeField] private Transform arrowS;

    private void Update()
    {
        TimeZoneInfo gmtTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTime gmtTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, gmtTimeZone);
        
        float rotationAngleX = -gmtTime.Hour % 12 * (360f / 12f);
        arrowH.localRotation = Quaternion.Euler(rotationAngleX, 0f, 0f);

        rotationAngleX = -gmtTime.Minute * (360f / 60f);
        arrowM.localRotation = Quaternion.Euler(rotationAngleX, 0f, 0f);
        
        rotationAngleX = -gmtTime.Second * (360f / 60f);
        arrowS.localRotation = Quaternion.Euler(rotationAngleX, 0f, 0f);
    }
}
