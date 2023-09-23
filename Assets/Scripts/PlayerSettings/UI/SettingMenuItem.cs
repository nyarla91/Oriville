using UnityEngine;
using Zenject;

namespace PlayerSettings.UI
{
    public abstract class SettingMenuItem : MonoBehaviour
    {
        [SerializeField] private SettingsSectionLabel _section;
        [SerializeField] private string _settingLabel;

        [Inject] private Settings Settings { get; set; }

        protected void ApplySetting(int value)
        {
            if (Settings == null)
                return;
            Settings.SetSetting(_section, _settingLabel, value);
            Settings.SaveAndApply();
        }

        protected abstract void SetStartingValue(int value);

        private void Start()
        {
            SetStartingValue(Settings.GetSettingValue(_section, _settingLabel));
        }
    }
}