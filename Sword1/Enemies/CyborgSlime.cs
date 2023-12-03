using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace Sword1.Enemies
{
    public class CyborgSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyborg Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];

        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.damage = 50;
            npc.defense = 4;
            npc.lifeMax = 200;
            npc.value = 10000f;
            npc.aiStyle = 1;
            npc.HitSound = SoundID.NPCHit1;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            aiType = NPCID.DungeonSlime;

        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
        }
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.frameCounter >= 20)
            {
                npc.frameCounter = 0;
            }
            npc.frame.Y = (int)npc.frameCounter / 10 * frameHeight;
        }
        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("GraftCore"), Main.rand.Next(0, 1));
            Item.NewItem(npc.getRect(), ItemID.Gel, Main.rand.Next(0, 4));
        }
    }
}