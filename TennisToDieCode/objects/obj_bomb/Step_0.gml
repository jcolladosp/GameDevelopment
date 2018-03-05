if(!groundLine){
y = y + 5;
}
if (state == "falling" && groundLine){
sprite_index = spr_bomb_burning;
state = "fallingWait";
}

if(state == "fallingWait" && round(image_index) == 25){
state = "explode";
}

if(state == "explode" ){

	sprite_index = spr_bomb_explosion;
	if(round(image_index) == 7){
		if(place_meeting(x,y,inst_player)){
		game_restart();
		}
		state = "explodeLast"
	}
}

if(state == "explodeLast"){
	
	instance_destroy();
}