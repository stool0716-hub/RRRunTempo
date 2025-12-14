using UnityEngine;
using UnityEngine.UI;

public class sr_cardgradient_as_ctl : MonoBehaviour
{
    Material UI_sr_gacha_as;
    public float Move;
    
    
    void Start()
    {
        Image img = GetComponent<Image>();
        UI_sr_gacha_as = Instantiate(img.material); // 取得獨立材質
        img.material = UI_sr_gacha_as;             // 再貼回去
    }

    void Update()
    {
        UI_sr_gacha_as.SetFloat("_Move", Move);
       
    }
}
