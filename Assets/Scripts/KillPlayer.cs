using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class KillPlayer : MonoBehaviour
{
    private void OnTriggerEnter( Collider other )
    {
        //In case this was not a minigame it would be better to put several scripts that were the different forms of death of the player and a game controller that will be in charge. 
        if ( other.gameObject.GetComponent<Mover>() && ( this.gameObject.GetComponent<Alien>()?.AlienCurrentState == Alien.AlienState.AlienOpq ) )
            SceneManager.LoadScene( 0 );
    }

    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }

}
