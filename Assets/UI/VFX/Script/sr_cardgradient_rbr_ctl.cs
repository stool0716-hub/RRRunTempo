using UnityEngine;
using UnityEngine.UI;

public class sr_cardgradient_rbr_ctl : MonoBehaviour
{
    Material UI_sr_gacha_rbr;
    public float Move;
    
    
    void Start()
    {
        Image img = GetComponent<Image>();
        UI_sr_gacha_rbr = Instantiate(img.material); // 取得獨立材質
        img.material = UI_sr_gacha_rbr;             // 再貼回去
    }

    void Update()
    {
        UI_sr_gacha_rbr.SetFloat("_Move", Move);
       
    }
}
