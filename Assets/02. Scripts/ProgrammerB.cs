using UnityEngine;
using ProgA;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA;

    void Start()
    {
        pA.publicVal = 11;
    }
}
