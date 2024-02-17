# Speedshard - Stances

## Description

This mod is a rework of all ten stances found in Stoneshard. With the following changes:
- Stances stay indefinitevely until weapon is swaped or unequipped, no more duration.
- Stances activation and deactivation does not cost a turn, it's just pure MP management.
- Stances can be deactivated by clicking the skill again, no need to switch layout to remove the stance buff.
- Normal attacks restore 1 MP * stage.
- Normal attack reduces the number of stack by 1 as previously, but don't dissipate the buff.
- While a stance is active, MP regeneration is greatly reduced (for early levels, that means you can't regenerate MP while using a stance).
- MP regeneration penalty scales with stages ( -10% * stage, -5% * stage if stance_training).
- While a stance is active, each 2 turns remove 1 MP (4 turns if stance_training), now you will run out quickly out of mp in mid game.
- If you run out of MP, stances will automatically dissipate.

Other functionalities can be found in [Speedshard_Core](https://github.com/remyCases/SpeedshardCore), [Speedshard_Backpack](https://github.com/remyCases/SpeedshardBackpack), [Speedshard_Skinning](https://github.com/remyCases/SpeedshardSkinning), [Speedshard_MoneyDungeon](https://github.com/remyCases/SpeedshardMoneyDungeon) and [Speedshard_Sprint](https://github.com/remyCases/SpeedshardSprint).

## Installation

Since this mod was made through MSL, you first need to install it and then patching the game with it.
You can follow the official [installation guide](https://dddddragon.github.io/ModShardLauncher/guides/how-to-play-mod.html) on the MSL documentation.

A [video](https://www.youtube.com/watch?v=_J0oJYGi38E&t=13s&ab_channel=Nylux) was made by Nylux to show how to install Neoconsole, if you prefer a video guide.

### installing MSL

- Download the lastest release of [MSL](https://github.com/DDDDDragon/ModShardLauncher).
- Unzip it.
- **Move the `ModShard.dll` file to your Stoneshard folder.**
- (Optional) Rename the data.win file in the Stoneshard folder with an other name so you'll have a backup if something went wrong.

### Using MSL

- Download the lastest `.sml` file released of [Speedshard - Stances](https://github.com/remyCases/SpeedshardStances/releases).
- Move the `Speedshard_Stances.sml` in the `MSL/Mods` folder.
- Run `ModShardLauncher.exe`.
- Click on the anvil icon on the leftside.
- Click on the folder icon on the topside. A dialog box should pop up.
- Select the `.win` file in the Stoneshard folder (`data.win` if you didn't rename it).
- Enable the mod by checking the `Enable` box.
- Click the floppy disk icon on the topside. A dialog box should pop up.
- In this dialog box, create a new `.win` file and save (`data.win` if you didn't rename it).

You can now play the game with the modded version !

## Troubleshooting

If you encountered some troubles while trying to patch your game, first check if you **move the `ModShard.dll`** in the Stoneshard folder.

Then you can contact me on [Discord](https://discord.com/users/200330865522376704), and send me the lastest log file found in `MSL/logs`.

## See also

*Other mods I've made, WIP.*