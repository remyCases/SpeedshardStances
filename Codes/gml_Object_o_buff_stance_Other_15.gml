event_inherited()
with (target)
{
    var _mp = -0.25
    var _res = math_round((-5 * other.stage))
    if (!scr_stance_training(o_player))
    {
        ds_map_replace(other.data, "MP_Restoration", (2 * _res))
        ds_map_replace(other.data, "MP_turn", 2*_mp)
    }
    else
    {
        ds_map_replace(other.data, "MP_Restoration", _res)
        ds_map_replace(other.data, "MP_turn", _mp)
    }
    scr_atr_calc(id)
}