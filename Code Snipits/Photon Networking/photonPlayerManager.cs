﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class photonPlayerManager : MonoBehaviour
{
    PhotonView photonView;


    public Behaviour[] componentsToDisable;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>(); 
        if (!photonView.IsMine) //if not local do stuff here
        {

            for (int i = 0; i < componentsToDisable.Length; i++) //disabe scripts that are not on local player that are added to list
            {
                componentsToDisable[i].enabled = false;
                CharacterController cc = GetComponent(typeof(CharacterController)) as CharacterController;
                cc.enabled = false; // Turn off the component
                //ui.SetActive(false);


            }

        }

        if (photonView.IsMine) // if local do stuff here
        {
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
