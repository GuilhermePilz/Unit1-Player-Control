using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    public float turnSpeed; 
    private Vector3 offset = new Vector3(0, 5, -7);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
