using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
            Debug.LogError("MeshRenderer is missing on Ground GameObject");
    }

    private void Update()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager.Instance is null");
            return;
        }

        if (meshRenderer == null)
        {
            Debug.LogError("meshRenderer is null");
            return;
        }

        if (meshRenderer.material == null)
        {
            Debug.LogError("Material is null on meshRenderer");
            return;
        }

        float speed = GameManager.Instance.gameSpeed / transform.localScale.x;
        meshRenderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
