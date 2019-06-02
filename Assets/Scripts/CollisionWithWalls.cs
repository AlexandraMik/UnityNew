using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithWalls : MonoBehaviour
{
        void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Destroy"){
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        }
}
