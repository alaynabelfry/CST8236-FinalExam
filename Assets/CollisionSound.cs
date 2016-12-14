using UnityEngine;
using System.Collections;

public class CollisionSound : MonoBehaviour
{
    public AudioSource hitSound;

    public void OnCollisionEnter(Collision collision)
    {
        if(hitSound != null) {
            hitSound.Play();
        }
    }
}