using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 3f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach(Collider collider in colliderArray)
            {
                if(collider.TryGetComponent(out Interactable interactable)) {
                    interactable.StartTimer();
                }
                if(collider.TryGetComponent(out Interactable2 interactable2))
                {
                    interactable2.MadeIt();
                }
            }
        }
    }
}
