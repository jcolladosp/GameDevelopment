# Game Development

#### Functions used in the tutorial

- ### Movement

  `if (keyboard_check(ord("D"))) x = x + 4`  → Keyboard key pressed.

  `mouse_check_button(mb_left)` →  Mouse button pressed.

  `move_towards_point(obj_player.x,obj_player.y,spd)` → Move object to a given point.  

  `image_angle = point_direction(x,y,mouse_x,mouse_y)` → Change angle of object sprite.

  `random_range(4,-4)` → Generate random within the range.

  `speed = 16` → Set speed of the object.



Get camera position.

```
  var cx = camera_get_view_x(view_camera[0])
  var cy = camera_get_view_y(view_camera[0])
  var cw = camera_get_view_width(view_camera[0])
```
`draw_set_font(fnt_score)` → Set font to a text
`draw_set_color(c_white)` → Set color to a text
`draw_text(cx+cw/2,cy+25,string(score))` → Draw text in a specific position

`game_restart()` → Restart game.



`with(obj_score)`

`with(other)`

`audio_play_sound(snd_death,0,0)` → Play sound.

`room_goto(rm_game)` → Start a new room, close the current one.



image_xscale = 0.1;
image_xscale = 0.1;