using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//Script for moving a gameObject smoothly
//Usage: Attach the character controller component to the gameobject that you want to move

namespace UnityLibary
{
    public class zoomin : MonoBehaviour
    {
        // place the gameobject that you want to move to the controller placeholder
        public CharacterController controller;

        public float speed = 5f;

        void Update()
        {
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            //Rotate clockwise
            if (Input.GetKey(KeyCode.E))
            {
                transform.RotateAround(transform.position, Vector3.up, 100 * Time.deltaTime);
            }

            // Rotate anticlockwise
            if (Input.GetKey(KeyCode.Q))
            {
                transform.RotateAround(transform.position, -Vector3.up, 100 * Time.deltaTime);
            }

        }

    }
}