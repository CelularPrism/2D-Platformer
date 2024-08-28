using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DeathTrigger : MonoBehaviour
{
    [SerializeField] private int PlayerLayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.layer);
        if (collision.gameObject.layer == PlayerLayer)
        {
            SceneManager.ReloadScene();
        }
    }
}
