using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.Carson_s_Stupid_Modded_Objects {
    public class Carson_s_Stupid_Modded_ObjectsModule : EverestModule {
        public static Carson_s_Stupid_Modded_ObjectsModule Instance { get; private set; }

        public override Type SettingsType => typeof(Carson_s_Stupid_Modded_ObjectsModuleSettings);
        public static Carson_s_Stupid_Modded_ObjectsModuleSettings Settings => (Carson_s_Stupid_Modded_ObjectsModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(Carson_s_Stupid_Modded_ObjectsModuleSession);
        public static Carson_s_Stupid_Modded_ObjectsModuleSession Session => (Carson_s_Stupid_Modded_ObjectsModuleSession) Instance._Session;

        public override Type SaveDataType => typeof(Carson_s_Stupid_Modded_ObjectsModuleSaveData);
        public static Carson_s_Stupid_Modded_ObjectsModuleSaveData SaveData => (Carson_s_Stupid_Modded_ObjectsModuleSaveData) Instance._SaveData;

        public Carson_s_Stupid_Modded_ObjectsModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(Carson_s_Stupid_Modded_ObjectsModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(Carson_s_Stupid_Modded_ObjectsModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}
