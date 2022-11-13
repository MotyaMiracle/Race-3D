using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float angle; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posOffset = gameObject.transform.position;
        Vector3 rotOffset = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            posOffset += Time.deltaTime * speed * transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            posOffset -= Time.deltaTime * speed * transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
        }
        gameObject.transform.position = posOffset;
        gameObject.transform.Rotate(rotOffset);
    }
}
