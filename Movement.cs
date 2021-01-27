using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    float Xdir; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Xdir = Input.GetAxis("Horizontal");
        if(Xdir > 0 )
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
        else if (Xdir < 0 )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    void MovePreform(float dir )
    {
        rb.velocity = Vector2.right * dir * speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        MovePreform(Xdir);
    }

}
