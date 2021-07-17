using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFlags : MonoBehaviour
{
    public Dropdown dp;
    public Sprite[] flags;

    void Start()
    {
        List < Dropdown.OptionData > flags = new List<Dropdown.OptionData>();

        foreach(var flag in flags)
        {
            string flagName = flag.text;
            int dot = flag.text.IndexOf('.');
            if(dot >= 0)
            {
                flagName = flagName.Substring(dot + 1);
            }
            var flagOption = new Dropdown.OptionData(flag.text);
            flags.Add(flagOption);
        }

        dp.AddOptions(flags);
    }
}
