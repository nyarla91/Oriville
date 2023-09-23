using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PlayerSettings.UI
{
    public class SliderValueView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tmp;
        [SerializeField] private List<string> _value;

        public void OnValueChanged(float value) => _tmp.text = _value[Mathf.RoundToInt(value)];
    }
}