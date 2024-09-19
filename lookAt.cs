using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{

    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.position - transform.position;
        direction.y = 0f;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.Rotate(0, 180, 0);
    }
}
