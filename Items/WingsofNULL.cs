using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Cysteel.Items.Placeable;

namespace Cysteel.Items
{
	[AutoloadEquip(EquipType.Wings)]
	public class WingsofNULL : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wings of NULL");
			Tooltip.SetDefault("'Who wouldn't want to fly in style Viddy?'");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.value = 10;
			item.rare = ItemRarityID.Cyan;
			item.accessory = true;
		}
		//these wings use the same values as the solar wings
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 300;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 1f;
			ascentWhenRising = 2f;
			maxCanAscendMultiplier = 10f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.2f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 10f;
			acceleration *= 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Placeable.CytoxicSteelBar>(), 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.WingsNebula, 1);
			recipe.AddIngredient(ItemID.FallenStar, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}