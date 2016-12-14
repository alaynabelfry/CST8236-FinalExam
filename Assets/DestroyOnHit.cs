using UnityEngine;
using System.Collections;

public class DestroyOnHit : MonoBehaviour {

    public void OnCollisionEnter(Collision collision)
    {
        if (name.Contains("Clone")) { 
            GameObject.Destroy(gameObject);
            Debug.Log("Bullet Destroyed");
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (name.Contains("Clone"))
        {
            GameObject.Destroy(gameObject);
            Debug.Log("Bullet Destroyed");
        }
    }
}
