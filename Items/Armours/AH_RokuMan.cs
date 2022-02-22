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
    [AutoloadEquip(EquipType.Head)] //Equipa el Item en la Cabeza.

    public class AH_RokuMan : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RockMan's Head"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("I rather liked the Yellow one");
        
        }

        public override void SetDefaults()
        {

            item.Size = new Vector2(18);
            item.value = Terraria.Item.sellPrice(0,0,18,0);
            item.rare = ItemRarityID.Blue;
            item.defense = 10;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<AB_RokuMan>() && legs.type == ItemType<AL_RokuMan>() && head.type == ItemType<AH_RokuMan>();

        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Greatly Increases Mana. Increases Magic Damage. Increases Defense by 5";
            player.statManaMax += 20;
            player.magicDamage += 0.5f;
            player.statDefense += 5;

        }
        
    }
}
