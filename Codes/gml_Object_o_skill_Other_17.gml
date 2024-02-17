if (ds_list_find_index(_category, "Stance") >= 0) {
	maxKD = 1
}
if scr_stance_training(owner.id)
{
	if (ds_list_find_index(_category, "Maneuver") >= 0)
	{
		MPcost = math_round((MPcost * 0.8))
		maxKD = math_round((maxKD * 0.8))
        }
        if (ds_list_find_index(_category, "Stance") >= 0) {
		MPcost = math_round((MPcost * 0.8))
        }
}