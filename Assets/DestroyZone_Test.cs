using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone_Test: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            Debug.Log("DestoryZone_Test.Log");
            //other.transform.position = other.GetComponent<PlayerMove_test>().respawnPosition;
        }
    }
}
