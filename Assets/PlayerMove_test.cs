using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Vector3 respawnPosition;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        respawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        setOriginPosition();
        Vector3 dir = h * Vector3.right + v * Vector3.forward;
        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;
    }

    public void setOriginPosition()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            respawnPosition = transform.position;
            print("현재 위치 저장됨!");
            print(respawnPosition);
        }
    }
}
