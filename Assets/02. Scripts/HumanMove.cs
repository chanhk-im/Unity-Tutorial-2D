using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    
    private Vector3 moveDirection;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }
        
    }
}
// using UnityEngine;
//
// public class HumanMove : MonoBehaviour
// {
//     public float moveSpeed = 1.0f;
//     
//     private Vector3 _moveDirection;
//     void Update()
//     {
//         _moveDirection = Vector3.zero;
//         
//         if (Input.GetKey(KeyCode.W))
//         {
//             _moveDirection += Vector3.forward;
//         }
//         if (Input.GetKey(KeyCode.A))
//         {
//             _moveDirection += Vector3.left;
//         }
//         if (Input.GetKey(KeyCode.S))
//         {
//             _moveDirection += Vector3.back;
//         }
//         if (Input.GetKey(KeyCode.D))
//         {
//             _moveDirection += Vector3.right;
//         }
//         
//         _moveDirection.y = 0;
//         _moveDirection = Vector3.Normalize(_moveDirection) * (moveSpeed * Time.deltaTime);
//         
//         transform.position += _moveDirection;
//     }
// }
