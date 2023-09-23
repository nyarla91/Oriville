using System.Collections.Generic;
using Localization;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace PlayerSettings.UI
{
    public class SliderDictionaryView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _tmp;
        [FormerlySerializedAs("_value")] [SerializeField] private List<LocalizedString> _labels;

        [Inject] private ISettingsRead Settings { get; set; }

        public void OnValueChanged(float value)
        {
            LocalizedString localizedLabel = _labels[Mathf.RoundToInt(value)];
            int language = Settings.GetSettingValue(SettingsSectionLabel.Game, "language");
            _tmp.text = localizedLabel.GetTranslation(language);
        }
    }
}