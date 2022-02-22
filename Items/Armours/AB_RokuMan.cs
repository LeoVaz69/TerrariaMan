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


namespace TerrariaMan.Items.Armours
{
    [AutoloadEquip(EquipType.Body)] //Equipa el Item en el cuerpo.

    public class AB_RokuMan : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RockMan's Body"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Not too resistant thou");
        }

        public override void SetDefaults()
        {

            item.Size = new Vector2(18);
            item.value = Terraria.Item.sellPrice(0, 0, 18, 0);
            item.rare = ItemRarityID.Blue;
            item.defense = 12;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
