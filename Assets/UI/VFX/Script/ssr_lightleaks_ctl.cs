using UnityEngine;
using UnityEngine.UI;

public class ssr_lightleaks_ctl : MonoBehaviour
{
    Material UI_ssr_lightleaks;
    public float Move;
    public float MaskStart;
    
    void Start()
    {
        Image img = GetComponent<Image>();
        UI_ssr_lightleaks = Instantiate(img.material); // 取得獨立材質
        img.material = UI_ssr_lightleaks;             // 再貼回去
    }

    void Update()
    {
        UI_ssr_lightleaks.SetFloat("_Move", Move);
        UI_ssr_lightleaks.SetFloat("_MaskStart", MaskStart);

    }
}
