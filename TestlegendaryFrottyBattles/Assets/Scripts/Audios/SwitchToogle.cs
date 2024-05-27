using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToogle : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleReckTransform;
    [SerializeField] Sprite onToggle;
    [SerializeField] Sprite offToggle;

    Toggle toggle;

    Vector2 handlePos;

    public bool BGM, SFX;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        //handlePos = uiHandleReckTransform.anchoredPosition;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
        {
            //OnSwitch(true);
        }

    }

    private void Update()
    {
        if (BGM)
        {
            if (!AudioManager.Instance.musicSource.mute)
            {
                OnSwitch(true);
            }
            else
            {
                OnSwitch(false);
            }
        }

        /*if (SFX)
        {
            if (!AudioManager.Instance.sfxSource.mute)
            {

                OnSwitch(true);
            }
            else
            {
                OnSwitch(false);
            }
        }*/
    }

    void OnSwitch(bool on)
    {
        //toggle.isOn = on ? !on : false;
        //uiHandleReckTransform.anchoredPosition = on ? handlePos * -1 : handlePos;
        //transform.GetChild(0).GetComponent<Image>().sprite = on ? onToggle: offToggle;
    }


}
