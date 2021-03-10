using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//Script for moving a gameObject smoothly
//Usage: Attach the character controller component to the gameobject that you want to move

namespace UnityLibary
{
    public class dooropen : MonoBehaviour
    {
        // place the gameobject that you want to move to the controller placeholder
        public CharacterController controller;

        public float speed = 5f;

        void Update()
        {
            //Rotate clockwise
            if (Input.GetKey(KeyCode.Z))
            {
                transform.RotateAround(transform.position, Vector3.up, 100 * Time.deltaTime);
            }

            // Rotate anticlockwise
            if (Input.GetKey(KeyCode.C))
            {
                transform.RotateAround(transform.position, -Vector3.up, 100 * Time.deltaTime);
            }

        }

    }
}