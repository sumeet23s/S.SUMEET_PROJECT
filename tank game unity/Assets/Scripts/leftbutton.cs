using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class leftbutton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    // Start is called before the first frame update.
    public float MovementSpeed;
    public GameObject player;
    bool ispressed = false;

    public void Update()
    {
        if (ispressed)
        {
            player.transform.position += new Vector3(-Time.deltaTime * MovementSpeed, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
    
 
}
