using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Loulou
{

    public class InputManager : MonoBehaviour
    {
        public UnityEvent onRight, onLeft, onUp, onDown, onAction;

        private void Update()
        {
            if(Input.GetAxis("Horizontal")>=0.2)
            {
                onRight.Invoke();
            }
            if (Input.GetAxis("Horizontal") <= -0.2)
            {
                onLeft.Invoke();
            }
            if(Input.GetAxis("Vertical")>=0.2)
            {
                onUp.Invoke();
            }
            if (Input.GetAxis("Vertical") <= -0.2)
            {
                onDown.Invoke();
            }
            if(Input.GetAxis("Fire1")>=0.2)
            {
                onAction.Invoke();
            }
        }

    }
}
