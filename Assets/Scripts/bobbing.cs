using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobbing : MonoBehaviour
{
    public float movement_amplitude = 0.1f;
    public float movement_frequency = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x,
                                              Mathf.Cos((transform.position.z )* movement_frequency) * movement_amplitude,
                                              transform.localPosition.z);
        
    }
    
}
