using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{

    Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = GetComponent<Transform>().position;
        // Debug.Log("i'm at frame " + Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        Transform siblingTransform = GetComponent<Transform>();

        float offset = Mathf.Sin(Time.time);
        siblingTransform.position = startingPosition + Vector3.right * offset;

        // Debug.Log("i'm in update at frame " + Time.frameCount);
    }
}
