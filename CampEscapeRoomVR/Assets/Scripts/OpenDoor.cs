using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject yellowWall;
    public GameObject yellowKey;

    private void Awake()
    {
        this.yellowWall = GameObject.FindGameObjectWithTag("Yellow Wall");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Yellow Key")
        this.yellowWall.SetActive(false);
    }
}
