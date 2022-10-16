using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
    public GameObject spawn;

    public void Add() {
        Instantiate(spawn, transform.position, transform.rotation);
    }
       
}