using UnityEngine;

public class sms_testing1 : MonoBehaviour
{
    public SMS sm;
    public Notification notification;

    public void Test()
    {
        if (sm == null)
        {
            Debug.LogError("SMS reference is not assigned!");
            return;
        }

        sm.AddMessage(false, "Good Job");
        sm.AddMessage(false, "Ending Test");
        StartCoroutine(notification.SlideIn());
    }
}