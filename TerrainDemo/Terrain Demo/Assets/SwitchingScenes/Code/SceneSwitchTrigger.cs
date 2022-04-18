using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitchTrigger : MonoBehaviour
{
    bool canSwitchScenes;
    public int spawnPositionToLoad;

    private void Start()
    {
        canSwitchScenes = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter");
        if (other.tag == "Player")
        {
            SceneSwitchManager.Instance.MoveToSpawnPoint(other.transform, spawnPositionToLoad);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("OnCollisionEnter");
        if (collision.gameObject.tag == "Player")
        {
            SceneSwitchManager.Instance.MoveToSpawnPoint(collision.transform, spawnPositionToLoad);
        }
    }
}
