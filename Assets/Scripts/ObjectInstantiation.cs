using Unity.Mathematics;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectInstantiation : MonoBehaviour
    {
        public void inst(int x, int y, GameObject obj)
        {
            Instantiate(obj, new Vector3(x, y, 0), quaternion.identity);

        }
    }
