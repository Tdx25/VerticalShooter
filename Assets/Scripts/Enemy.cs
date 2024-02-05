using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float respawnY = 10;
    private float _respawnX;
    
    private Rigidbody2D _rigidbody2D;

    public AudioSource audioPlayer;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _respawnX = transform.position.x;
    }

    // Update is called once per frame
    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = (Vector2)new Vector2(_respawnX, respawnY);
        _rigidbody2D.velocity = Vector2.zero;
    }
    private void OnMouseDown()
    {
        Debug.Log("down");
        gameObject.SetActive(false);
        GameManager.Instance.UnlistEnemy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.CompareTag("Lazer"))
        {
            Despawn();
        }
    }
    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.Instance.UnlistEnemy(gameObject);

    }

}
