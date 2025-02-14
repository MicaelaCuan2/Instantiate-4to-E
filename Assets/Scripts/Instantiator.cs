﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtCloneAmount;
    GameObject clon;

    public void MultiInstantiate()
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        int counter = 0;
        for (int i = counter; i < cloneAmount; i++)
        {
           clon = Instantiate(objectToClone);
            Destroy(clon, 1);
        }
    }
}
