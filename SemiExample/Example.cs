using System;
using Semi;
using ModTheGungeon;

namespace SemiExample {
    public class Example : Mod {
        public Logger Logger = new Logger("ExampleMod");

        public override void Loaded() {
            Logger.Info("Example mod loaded!");

            Logger.Debug($"magic_lamp: {Gungeon.Items["magic_lamp"]}");
            Logger.Debug($"gungeon:magic_lamp: {Gungeon.Items["gungeon:magic_lamp"]}");
            Logger.Debug($"megalich: {Gungeon.Enemies["megalich"]}");
            Logger.Debug($"gungeon:megalich: {Gungeon.Enemies["gungeon:megalich"]}");
        }
    }
}
