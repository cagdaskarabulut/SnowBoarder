using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crashed : MonoBehaviour
{
  bool alreadyCrashed = false;
  float invokeTime = 0.5f;
  [SerializeField] ParticleSystem crushEffect;
  [SerializeField] AudioClip crashedSFX;
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Ground" && !alreadyCrashed)
    {
      HitHeadOnGround();
    }
  }
  void HitHeadOnGround()
  {
    alreadyCrashed = true;
    Debug.Log("Ouch! I hit my head");
    FindObjectOfType<PlayerController>().DisableControls();
    crushEffect.Play();
    GetComponent<AudioSource>().PlayOneShot(crashedSFX);
    Invoke("restartLevel", invokeTime);
  }
  public void restartLevel()
  {
    SceneManager.LoadScene("Level1");
  }
}
