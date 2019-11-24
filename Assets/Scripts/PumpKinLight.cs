using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpKinLight : MonoBehaviour
{

    private void OnTriggerEnter( Collider other )
    {
        if ( other.gameObject.GetComponent<Alien>() )
        {
            Debug.Log( "Entre al alien" );
            var alien = other.gameObject.GetComponent<Alien>();
            //alien.AlienCurrentState = Alien.AlienState.AlienTrans;
            //alien?.BecomeTras();
            alien?.BecomeLit();
        }
    }

    private void OnTriggerExit( Collider other )
    {
        if ( other.gameObject.GetComponent<Alien>() )
        {
            Debug.Log( "Sali al alien" );
            var alien = other.gameObject.GetComponent<Alien>();
            //alien.AlienCurrentState = Alien.AlienState.AlienOpq;
            //alien?.BecomeTras();
            alien?.BecomeUnLit();
        }
    }

}

