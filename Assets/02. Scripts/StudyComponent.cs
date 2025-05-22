using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh mesh;
    public Material material;
    
    void Start()
    {
        CreateCube("Cube");
    }

    public void CreateCube(string objName)
    {
        obj = new GameObject(objName);

        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();
        
        obj.GetComponent<MeshRenderer>().material = material;
        obj.GetComponent<MeshFilter>().mesh = mesh;
    }
}
