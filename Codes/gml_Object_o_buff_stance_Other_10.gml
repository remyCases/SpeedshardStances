if instance_exists(owner)
{
    var to_destroy_buff = 0

    with (target)
    {
        if (MP == 0)
            to_destroy_buff = 1
    }

    if to_destroy_buff
        instance_destroy()
}