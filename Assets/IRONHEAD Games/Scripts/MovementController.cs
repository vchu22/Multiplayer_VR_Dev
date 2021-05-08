﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MovementController : MonoBehaviour
{
    public List<XRController> controllers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (XRController xRController in controllers)
        {
            if (xRController.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 positionVector))
            {
                Debug.Log(xRController.inputDevice.name + " " + positionVector);
            }
        }
    }
}