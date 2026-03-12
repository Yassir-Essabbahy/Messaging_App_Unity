using UnityEngine;

public class SMS_Opener : MonoBehaviour
{
    public GameObject SMS_Canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !SMS_Canvas.activeSelf)
        {
            SMS_Canvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && SMS_Canvas.activeSelf)
        {
            SMS_Canvas.SetActive(false);
                        Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}