using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheOtherDoor : MonoBehaviour
{
    public GameObject redWall;
    public GameObject redKey;

    private void Awake()
    {
        this.redWall = GameObject.FindGameObjectWithTag("Red Wall");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Red Key")
        {
            this.redWall.SetActive(false);
        }
    }
}