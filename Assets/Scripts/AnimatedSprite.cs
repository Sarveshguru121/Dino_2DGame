using UnityEngine;

public class AnimatedSprite : MonoBehaviour
{
   
    public Sprite[] sprites;

    private SpriteRenderer SpriteRenderer;
    private int frame;

    private void Awake()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void OnEnable()
    {
        Invoke(nameof(Animate), 0f);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }


    private void Animate()
    {
        frame++;

        if(frame >= sprites.Length)
        {
            frame = 0;
        }

        if (frame >= 0 && frame < sprites.Length)
        {
            SpriteRenderer.sprite = sprites[frame];
        }

        Invoke(nameof(Animate), 1f / GameManager.Instance.gameSpeed);
       
    }
}
