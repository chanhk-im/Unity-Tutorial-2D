using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력: {dir}");
        
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}