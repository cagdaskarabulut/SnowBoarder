using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float torqueAmount = 1f;
  [SerializeField] float boostSpeed = 30f;
  [SerializeField] float baseSpeed = 20f;
  Rigidbody2D rb2s;
  SurfaceEffector2D surfaceEffector2D;
  // Start is called before the first frame update
  void Start()
  {
    rb2s = GetComponent<Rigidbody2D>();
    surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
  }

  // Update is called once per frame
  void Update()
  {
    RotatePlayer();
    RespondToBoost();
  }

  private void RespondToBoost()
  {
    if(Input.GetKey(KeyCode.Space)){
        surfaceEffector2D.speed = boostSpeed;
    } else {
        surfaceEffector2D.speed = baseSpeed;
    }
  }

  private void RotatePlayer()
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
