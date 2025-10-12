

using UnityEngine;

public class RingExpand : MonoBehaviour
{
    public UIRing ring;
    public float growSpeed = 50f;
    public float thinSpeed = 5f;

    [Header("初始狀態")]
    public float startRadius = 50f;
    public float startThickness = 20f;

    private bool isAnimating = false;

    void OnEnable()
    {
        if (ring == null) return;

        // 重設初始狀態
        ring.Radius = startRadius;
        ring.Thickness = startThickness;

        isAnimating = true; // 開始播放動畫
    }

    void Update()
    {
        if (!isAnimating || ring == null)
            return;

        ring.Radius += growSpeed * Time.deltaTime;
        ring.Thickness = Mathf.Max(1f, ring.Thickness - thinSpeed * Time.deltaTime);
    }
}
