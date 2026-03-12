using UnityEngine;
using System.Collections; 

public class Notification : MonoBehaviour
{

    public Vector2 hiddenPos; 
    public Vector2 visiblePos;
    public float speed = 100f; 
    public RectTransform iconRect;
    public AudioSource Notif;

    public IEnumerator SlideIn()
    {
        Notif.Play();
        
        while (Vector2.Distance(iconRect.anchoredPosition, visiblePos) > 0.1f)
        {
            iconRect.anchoredPosition = Vector2.MoveTowards(iconRect.anchoredPosition, visiblePos, speed * Time.deltaTime);
            yield return null; 
        }

       
        yield return new WaitForSeconds(5f);

        
        while (Vector2.Distance(iconRect.anchoredPosition, hiddenPos) > 0.1f)
        {
            iconRect.anchoredPosition = Vector2.MoveTowards(iconRect.anchoredPosition, hiddenPos, speed * Time.deltaTime);
            yield return null;
        }
    }
}