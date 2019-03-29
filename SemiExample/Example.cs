using System;
using Semi;
using ModTheGungeon;

namespace SemiExample {
    public class Example : Mod {
        public Logger Logger = new Logger("ExampleMod");

        public override void Loaded() {
            Logger.Info("Example mod loaded!");
        }
    }
}
