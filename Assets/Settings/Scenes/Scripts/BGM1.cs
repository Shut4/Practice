using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Title);
    }
}
