using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{   public Vector3 movement = new Vector3(0, 30, 0);
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement);
    }
}


