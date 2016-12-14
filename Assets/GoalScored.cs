using UnityEngine;
using System.Collections;

public class GoalScored : MonoBehaviour {

    public AudioSource goalSound;

    public void OnTriggerEnter(Collider collider) {
        if (goalSound != null) {
            goalSound.Play();
        }
    }
}
