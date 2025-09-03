event_inherited()
with (target)
{
    var _res = math_round((-5 * other.stage))
    if (!scr_stance_training(o_player))
    {
        ds_map_replace(other.data, "MP_Restoration", _res)
        ds_map_replace(other.data, "MP_turn", -1)
    }
    else
    {
        ds_map_replace(other.data, "MP_Restoration", _res)
    }
    scr_atr_calc(id)
}