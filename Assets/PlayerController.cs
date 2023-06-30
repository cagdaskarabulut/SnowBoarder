using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2s;
    // Start is called before the first frame update
    void Start()
    {
       rb2s = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2s.AddTorque(torqueAmount);    
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2s.AddTorque(-torqueAmount);    
        }
    }
}
