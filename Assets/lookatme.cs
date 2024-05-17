using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatme : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationforenemy = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        gameObject.transform.LookAt(rotationforenemy);
    }
}
/*    //public GameObject player;
public Transform facing;

// Start is called before the first frame update
void Start()
{
    //player = GameObject.FindWithTag("Player");
}

// Update is called once per frame
void Update()
{

    //gameObject.transform.LookAt(player.transform.position);
    transform.LookAt(new Vector3(0, transform.position.y, 0));
}*/