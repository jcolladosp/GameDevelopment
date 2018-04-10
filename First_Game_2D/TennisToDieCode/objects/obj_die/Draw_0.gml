
draw_set_font(fnt_score);
draw_set_color(c_white);
draw_text(512,50,"You died with " + string(global.scores) + " points");
draw_text(512,100,"Press ENTER to restart");