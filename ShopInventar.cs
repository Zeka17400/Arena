using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public static class ShopInventar
    {
        static List<Artifact> artifacts = new List<Artifact>();

        public static void standard_artifacts()
        {
            //Добавлять: artifacts.Add(new Artifact("Имя", Урон, Доп.HP, Цена));
            artifacts.Add(new Artifact("Рапира", 100, 500, 0));
        }

        public static void BoughtArtifact(Artifact artifact)
        {
            Character.GetInventory().Add(artifact);
            Character.SetItem(artifact);
            artifacts.Remove(artifact);
        }

        public static List<Artifact> getShop()
        {
            return artifacts;
        }
    }
}
