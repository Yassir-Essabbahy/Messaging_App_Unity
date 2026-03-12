using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class SMS : MonoBehaviour
{

    public Transform Content_Parent;

    public GameObject Playersms_Ins;
    public GameObject ContactSms_Ins;


    public void AddMessage(bool Sender_Player, string Message)
    {
        if (Sender_Player)
        {
            // add player message

            GameObject go = Instantiate(Playersms_Ins, Content_Parent.transform.position, quaternion.identity);
            go.transform.SetParent(Content_Parent, false);
            Text_Finder t_Ref = go.GetComponent<Text_Finder>();
            TextMeshProUGUI txt = t_Ref.Text_Reference;
            txt.text = Message;
        }
        else
        {
            // add contact message
            GameObject go = Instantiate(ContactSms_Ins, Content_Parent.transform.position, quaternion.identity);
            go.transform.SetParent(Content_Parent, false);
            Text_Finder t_Ref = go.GetComponent<Text_Finder>();
            TextMeshProUGUI txt = t_Ref.Text_Reference;
            txt.text = Message;
        }
    }
}
