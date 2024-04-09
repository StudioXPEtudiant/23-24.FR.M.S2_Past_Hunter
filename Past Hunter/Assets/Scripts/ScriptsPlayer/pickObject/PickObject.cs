using System;
using UnityEngine;
using UnityEngine.EventSystems;


namespace ScriptsPlayer.pickObject
{
    public class PickObject : MonoBehaviour
    {
        [Header("Pickup Settings")] [SerializeField]
        private Transform holdAera;

        private GameObject helObj;


        [Header("Physycs Parameters")] [SerializeField]
        private float pickupRange = 5.0f;

        [SerializeField] private float pickupForce = 150.0f;
        [SerializeField] private KeyCode pickKey = KeyCode.Mouse0;
        [SerializeField] private KeyCode dropKey = KeyCode.Mouse1;


        private void Update()
        {
            if (helObj == null)
            {
                RaycastHit hit;
                if (Input.GetKey(pickKey))
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickupRange))
                    {
                        PickupObjectHello(hit.transform.gameObject);
                        //Debug.Log("Tête de nueil");
                    }
                    
                }
                
            }
            else if(Input.GetKey(dropKey))
            {
                DropObject();
            }

            if (helObj != null)
            {
                MoveObject();
            }

            
            
        } 
        void MoveObject()
         {
             if (Vector3.Distance(helObj.transform.position, holdAera.position) > 0.1f)
             {
                 Vector3 moveDirection = (holdAera.position - helObj.transform.position);
                 helObj.GetComponent<Rigidbody>().AddForce(moveDirection * pickupForce);
             }

         }

        void PickupObjectHello(GameObject pickObj)
        {
            if (pickObj.GetComponent<Rigidbody>()&& helObj == null)
            {
               Rigidbody helObjRB = pickObj.GetComponent<Rigidbody>();
                helObjRB.useGravity = false;
                helObjRB.drag = 10;
                helObjRB.constraints = RigidbodyConstraints.FreezeRotation;

                helObjRB.transform.parent = holdAera;
                helObj = pickObj;
            }
        }

        void DropObject()
        {
            if (helObj != null)
            {
                //Debug.Log("Ho fuking dino qui ne marche pas");
                Rigidbody helObjRB = helObj.GetComponent<Rigidbody>();
                helObjRB.useGravity = true;
                helObjRB.drag = 1; 
                helObjRB.constraints = RigidbodyConstraints.None;
                
                helObjRB.transform.parent = null;
                helObj = null;
            }

        }
        
    }

}
  