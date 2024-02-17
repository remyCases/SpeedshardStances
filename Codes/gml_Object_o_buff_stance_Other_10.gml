if instance_exists(owner)
{
    mp_loss_counter++
    var mp_loss_max_counter = 2
    var to_destroy_buff = 0
    if (!scr_stance_training(o_player))
        mp_loss_max_counter = 4
    if (mp_loss_counter == mp_loss_max_counter)
    {
        with (target)
        {
            if (MP <= 1)
                MP = 0
            else
                MP -= 1
            if (MP == 0)
                to_destroy_buff = 1
        }
        mp_loss_counter = 0
    }
    if to_destroy_buff
        instance_destroy()
}