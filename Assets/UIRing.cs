using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
public class UIRing : MaskableGraphic
{
    [Range(3, 360)]
    public int segments = 60;

    [SerializeField]
    private float radius = 100f;
    [SerializeField]
    private float thickness = 10f;

    public float Radius
    {
        get => radius;
        set { radius = value; SetVerticesDirty(); }
    }

    public float Thickness
    {
        get => thickness;
        set { thickness = value; SetVerticesDirty(); }
    }

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        float outer = radius;
        float inner = radius - thickness;

        float angleStep = 360f / segments;
        Vector2 center = rectTransform.rect.center;

        for (int i = 0; i < segments; i++)
        {
            float angle0 = Mathf.Deg2Rad * (i * angleStep);
            float angle1 = Mathf.Deg2Rad * ((i + 1) * angleStep);

            Vector2 v0_outer = new Vector2(Mathf.Cos(angle0), Mathf.Sin(angle0)) * outer + center;
            Vector2 v1_outer = new Vector2(Mathf.Cos(angle1), Mathf.Sin(angle1)) * outer + center;
            Vector2 v0_inner = new Vector2(Mathf.Cos(angle0), Mathf.Sin(angle0)) * inner + center;
            Vector2 v1_inner = new Vector2(Mathf.Cos(angle1), Mathf.Sin(angle1)) * inner + center;

            int index = vh.currentVertCount;

            vh.AddVert(v0_inner, color, Vector2.zero);
            vh.AddVert(v1_inner, color, Vector2.zero);
            vh.AddVert(v1_outer, color, Vector2.zero);
            vh.AddVert(v0_outer, color, Vector2.zero);

            vh.AddTriangle(index + 0, index + 1, index + 2);
            vh.AddTriangle(index + 2, index + 3, index + 0);
        }
    }
}
