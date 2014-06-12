(function moveDivs(){
	var divs = Array(5);

	for (var i = 0; i < divs.length; i++) {
		var currDiv = document.createElement('div');
		document.body.appendChild(currDiv);

		currDiv.style.width = 80 + 'px';
		currDiv.style.height = 80 + 'px';
		currDiv.style.borderStyle = ['inset', 'outset'][getRandomNumber(0,1)];
		currDiv.style.borderColor = 'black';
		currDiv.style.borderWidth = 2 + 'px';
		currDiv.style.position = 'absolute';
		currDiv.style.borderRadius = 100 + 'px';
		currDiv.style.backgroundColor = getRandomColor();

		divs[i] = currDiv;
	}

	function getRandomNumber(min, max) {
		return Math.floor(Math.random() * (max - min + 1)) + min;
	}

	function getRandomColor() {
		return '#' + Math.floor(Math.random() * 16777215).toString(16);
	}

	var centerX = 200,
		centerY = 200,
		radius = 130,
		angle = 0;

	var functionTimer = setInterval(function updatePosition() {
		angle++;
		if (angle == 360) {
			angle = 0;
		}

		for (var i = 0; i < divs.length; i++) {
                // space between the divs
                var addition = (360 / divs.length) * i;

                var left = centerX + Math.cos((2*3.14/180)*(angle + addition)) * radius;
                var top = centerY + Math.sin((2*3.14/180)*(angle + addition)) * radius;
                divs[i].style.left = left + 'px';
                divs[i].style.top = top + 'px';
            }
        }, 100);
})();