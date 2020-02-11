using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textGLOW : MonoBehaviour
{

    //prof. blakes code

    public TMPro.TMP_Text Text;

    private void Update()
    {
        Text.fontSharedMaterial.SetFloat("_GlowPower", Mathf.Sin(Time.time * 10f));
    }
}
