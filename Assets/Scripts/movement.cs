using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float max_speed = 5.5f;
    public float acceleration = 5f;
    public float jforce = 400f;
    public float jumping_cooldown = 1.5f;
    private float timer = 0f;
    private float speed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += acceleration * Time.deltaTime;       
        
        if (speed > max_speed) speed = max_speed;
        transform.position += speed * Vector3.forward * Time.deltaTime;

        timer -= Time.deltaTime;
        

        if (Input.GetKeyDown("up"))
        {
            if (timer <= 0f)
            {
                timer = jumping_cooldown;

                this.GetComponent<Rigidbody>().AddForce(Vector3.up * jforce);
                

                       

            }

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obs")
        {
            Debug.Log("OUUUUUUUUUUUUUUUTTTTTTTTTTTTTTT");
            speed *= 0.5f;
        }
    }
}
