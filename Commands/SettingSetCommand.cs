using Build1.PostMVC.Core.MVCS.Commands;
using Build1.PostMVC.Core.MVCS.Injection;

namespace Build1.PostMVC.Unity.Settings.Commands
{
    public sealed class SettingSetCommand<V> : Command<V, Setting<V>> where V : struct
    {
        [Inject] public ISettingsController SettingsController { get; set; }

        public override void Execute(V value, Setting<V> setting)
        {
            SettingsController.SetSetting(setting, value);
        }
    }
}