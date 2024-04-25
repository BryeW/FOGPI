using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SuperPupSystems.Helper
{
    public class CountDownText : MonoBehaviour
    {
        public Timer timer;
        public float time { get { return timer.timeLeft; } }
        public TMP_Text text;
        // Start is called before the first frame update
        void Start()
        {
            if (text == null)
            {
                Debug.LogError("GameObject " + name + " field text in count down timer null!!!!");
            }

            if (timer == null)
            {
                Debug.LogError("GameObject " + name + " field timer in count down timer null!!!!");
            }
        }

        // Update is called once per frame
        void Update()
        {
            text.text = "" + Mathf.Ceil(time);
        }
    }
}