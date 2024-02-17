if is_player(owner)
{{
    cost_turn = 0
    if instance_exists({0})
    {{
        instance_destroy({0})
    }}
    else
    {{
        {1}
    }}
}}
else
{{
    {1}
}}