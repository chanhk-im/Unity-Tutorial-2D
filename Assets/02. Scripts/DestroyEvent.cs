using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime;
    void Start()
    {   
        Destroy(this.gameObject, destroyTime);
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }
}
