using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerDestruction : MonoBehaviour
{
    [SerializeField] float health;

    [SerializeField] Sprite sprite1; // Drag your first sprite here
    [SerializeField] Sprite sprite2; // Drag your second sprite here
    [SerializeField] Sprite sprite3; // Drag your third sprite here

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        BulletBlockerDestruction();
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }

    void BulletBlockerDestruction()
    {
        if(health <= 30)
        {
            spriteRenderer.sprite = sprite1;
            if (health <= 20)
            {
                spriteRenderer.sprite = sprite2;
                if (health <= 10)
                {
                    spriteRenderer.sprite = sprite3;
                    if (health <= 0)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
