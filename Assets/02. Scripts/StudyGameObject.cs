using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos;

    void Start()
    {
        GameObject obj = CreateCharacter("캐릭");
        PrintInformation(obj);
    }
    public GameObject CreateCharacter(string objName)
    {
        GameObject obj = Instantiate(prefab);
        obj.name = objName;

        return obj;
    }


    public void PrintInformation(GameObject obj)
    {
        Debug.Log($"캐릭터 자식 오브젝트 수: {obj.transform.childCount}");
        Debug.Log($"첫번째 자식 이름: {obj.transform.GetChild(0).name}");
        Debug.Log($"마지막 자식 이름: {obj.transform.GetChild(obj.transform.childCount - 1).name}");
    }
    
    
}
