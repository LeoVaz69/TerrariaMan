using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace TerrariaMan.Items.Weapons
{
	public class MegaBuster : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mega Buster"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Original One");

		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.mana = 5;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.knockBack = 2;
			item.value = Item.sellPrice(silver: 2);
			item.rare = ItemRarityID.Blue;
			item.shoot = ModContent.ProjectileType<Projectile.Magic.P_MBuster>();
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/s_mbuster");
			item.shootSpeed = 5f;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}

}
