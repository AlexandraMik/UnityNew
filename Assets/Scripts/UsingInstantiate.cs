using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    public GameObject TheGameObject; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 10);
        } 
    }
    void OnCollisionEnter(Collision myCollision) {
      if(myCollision.gameObject.CompareTag("Destroy")){
         Destroy (TheGameObject);//уничтожает обьект при косании с любой поверхностью
      }
  
}
}
