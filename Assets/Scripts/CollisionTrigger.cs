using UnityEngine;

//[RequireComponent(typeof(BoxCollider2D))]
public class CollisionTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entered");
    }
}
