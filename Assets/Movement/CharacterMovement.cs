using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace movement
{
    public class CharacterMovement : MonoBehaviour
    {
        private Vector3 desiredDirection;
        public float speed = 1;
        public float rotationSpeed = 12;

        public void Move(Vector3 direction)
        {
            desiredDirection = direction;
        }

        private void Update()
        {
            //transform.Translate(desiredDirection * speed * Time.deltaTime);
            transform.position += desiredDirection * speed * Time.deltaTime;

            float angle = Vector3.SignedAngle(transform.forward, desiredDirection, transform.up);
            transform.Rotate(transform.up, angle + Time.deltaTime * rotationSpeed);
        }
    }
}