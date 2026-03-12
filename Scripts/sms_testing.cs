using UnityEngine;

public class sms_testing : MonoBehaviour
{
    public SMS sm;
    public Notification notification;

    void Start()
    {
        if (sm == null)
        {
            Debug.LogError("SMS reference is not assigned!");
            return;
        }

        sm.AddMessage(false, "TESTING TESTING");
        sm.AddMessage(false, "Take The Yellow Coin");
        sm.AddMessage(true, "wakha");
        StartCoroutine(notification.SlideIn());
    }
}