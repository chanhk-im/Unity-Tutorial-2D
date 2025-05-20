using UnityEngine;

public class TestClass
{
    public int number;

    public TestClass(int number)
    {
        this.number = number;
    }
}

public struct TestStruct
{
    public int number;
    
    public TestStruct(int number)
    {
        this.number = number;
    }
}
    
public class StudyClass : MonoBehaviour
{
    void Start()
    {
        Debug.Log("클래스 ---------------------------");
        TestClass testClass = new TestClass(10);
        TestClass testClass2 = testClass;
        Debug.Log($"testClass = {testClass.number}, testClass2 = {testClass2.number}");

        testClass.number = 100;
        Debug.Log($"testClass = {testClass.number}, testClass2 = {testClass2.number}");
        
        Debug.Log("구조체 ---------------------------");
        TestStruct testStruct = new TestStruct(10);
        TestStruct testStruct2 = testStruct;
        Debug.Log($"testStruct = {testStruct.number}, testStruct2 = {testStruct2.number}");
        
        testStruct.number = 100;
        Debug.Log($"testStruct = {testStruct.number}, testStruct2 = {testStruct2.number}");
    }
}
