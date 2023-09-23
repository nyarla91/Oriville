namespace PlayerSettings
{
    public interface ISettingSet
    {
        void SetSetting(SettingsSectionLabel section, string setting, int value);
        void SaveAndApply();
    }
}