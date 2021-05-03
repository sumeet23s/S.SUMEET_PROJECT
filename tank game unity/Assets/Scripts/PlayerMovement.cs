
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 1f;

    void Update()
    {

        GetPlayerMovement();
        
    }


    private void GetPlayerMovement()
    {
        
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

       


    }
    
}
