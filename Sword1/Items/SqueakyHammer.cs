using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace Sword1.Items
{
	public class SqueakyHammer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Squeaky Hammer");
		   Tooltip.SetDefault("Used for epic king of the hill battles.");
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void OnHitPvp(Player player, Player target, int damage, bool crit)
        {
			Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/SqueakyHammer").WithVolume(3f).WithPitchVariance(.3f), (int)target.position.X, (int)target.position.Y);
			player.AddBuff(BuffID.Cursed, 240);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/SqueakyHammer").WithVolume(3f).WithPitchVariance(.3f), (int)target.position.X, (int)target.position.Y);
			player.AddBuff(BuffID.Cursed, 240);
		}


    }
}