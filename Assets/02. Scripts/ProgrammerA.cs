using System;
using UnityEngine;

namespace ProgA
{
    public class ProgrammerA : MonoBehaviour
    {
        private int val = 2;
        public int publicVal = 3;
        private int privateVal = 4;
        [SerializeField] private int serializeVal = 5;
        void Start()
        {
            int local = 6;
        }
    }
}

