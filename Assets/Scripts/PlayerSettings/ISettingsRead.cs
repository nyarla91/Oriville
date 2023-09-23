namespace PlayerSettings
{
    public interface ISettingsRead
    {
        int GetSettingValue(SettingsSectionLabel section, string setting);
        bool IsSettingToggled(SettingsSectionLabel section, string setting);
    }
}