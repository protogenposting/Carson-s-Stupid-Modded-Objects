using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.stupid_modded_objects {
    public class stupid_modded_objectsModule : EverestModule {
        public static stupid_modded_objectsModule Instance { get; private set; }

        public override Type SettingsType => typeof(stupid_modded_objectsModuleSettings);
        public static stupid_modded_objectsModuleSettings Settings => (stupid_modded_objectsModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(stupid_modded_objectsModuleSession);
        public static stupid_modded_objectsModuleSession Session => (stupid_modded_objectsModuleSession) Instance._Session;

        public override Type SaveDataType => typeof(stupid_modded_objectsModuleSaveData);
        public static stupid_modded_objectsModuleSaveData SaveData => (stupid_modded_objectsModuleSaveData) Instance._SaveData;

        public stupid_modded_objectsModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(stupid_modded_objectsModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(stupid_modded_objectsModule), LogLevel.Info);
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
