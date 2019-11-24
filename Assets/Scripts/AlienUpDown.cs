using UnityEngine;

public class AlienUpDown : MonoBehaviour
{
    [SerializeField] private float heightVariance = 2f;
    [SerializeField] private float moveSpeed = 2f;

    private float startPositionY;
    private float direction = 1f;

    private void OnEnable()
    {
        startPositionY = transform.position.y;
    }

    private void Update()
    {
        if ( transform.position.y > startPositionY + heightVariance || transform.position.y < startPositionY - heightVariance )
        {
            direction *= -1;
        }
        transform.Translate( Vector3.up * direction * moveSpeed * Time.deltaTime );
    }
}
