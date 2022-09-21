using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] float setTime = 60.0f;
    [SerializeField] Text countdowntext;

    // Start is called before the first frame update
    void Start()
    {
        countdowntext.text = setTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
            Time.timeScale = 0.0f;

        countdowntext.text = Mathf.Round(setTime).ToString();
    }
}
