<?php 
	for ($i = 1; $i <= 1000; $i++) {
		if($i % 3 == 0 || $i % 7 == 0){
			echo $i;
		}
	}

//Or what?

	for ($i = 1; $i <= 1000; $i++) {
		if($i % 21 == 0){
			echo $i;
		}
	}
?> 
