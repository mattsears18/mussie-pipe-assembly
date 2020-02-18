using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Testscript4 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Details;
    public GameObject VB4;

    // use this for initialization
    void Start()
    {
        Details = GameObject.Find("Details");
        VB4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Details.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Details.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Details.SetActive(false);
    }
    // Update is called once per frame
    void Update() { }
};
