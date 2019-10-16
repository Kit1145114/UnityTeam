using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Material[] _materials;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("joystick button 0"))
        {
            i++;
            if(i == 4)
            {
                i = 0;
            }

            this.GetComponent<Renderer>().material = _materials[i];
        }
    }
}
