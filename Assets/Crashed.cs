using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crashed : MonoBehaviour
{
  float invokeTime = 0.5f;
  [SerializeField] ParticleSystem crushEffect;
  [SerializeField] AudioClip crashedSFX;
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Ground")
    {
      HitHeadOnGround();
    }
  }
  void HitHeadOnGround()
  {
    crushEffect.Play();
    GetComponent<AudioSource>().PlayOneShot(crashedSFX);
    Invoke("restartLevel", invokeTime);
  }
  void restartLevel()
  {
    Debug.Log("Ouch! I hit my head");
    SceneManager.LoadScene("Level1");
  }
}
