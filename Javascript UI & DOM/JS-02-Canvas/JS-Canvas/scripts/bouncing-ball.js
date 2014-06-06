(function () {
    'use strict';
    var ctx = document.getElementById('canvas').getContext('2d'),
        totalWidth = ctx.canvas.width,
        totalHeight = ctx.canvas.height,

        movementByX = 'Positive',
        movementByY = 'Positive',

        positionX = totalWidth / 2,
        positionY = totalHeight / 2,

        radius = 30,
        speed = 4;

    function drawCircle(fillStyle) {
        ctx.beginPath();
        ctx.fillStyle = fillStyle;
        ctx.moveTo(positionX, positionY);
        ctx.arc(positionX, positionY, radius, 0, 7);
        ctx.fill();
    }

    function updateDirections() {
        if (movementByX === 'Positive') {
            positionX += speed;
            if (positionX + radius > totalWidth) {
                movementByX = 'Negative';
                positionX -= 2 * speed;
            }
        }
        else if (movementByX === 'Negative') {
            positionX -= speed;
            if (positionX - radius < 0) {
                movementByX = 'Positive';
                positionX += 2 * speed;
            }
        }

        if (movementByY === 'Positive') {
            positionY += speed;
            if (positionY + radius > totalHeight) {
                movementByY = 'Negative';
                positionY -= 2 * speed;
            }
        }
        else if (movementByY === 'Negative') {
            positionY -= speed;
            if (positionY - radius < 0) {
                movementByY = 'Positive';
                positionY += 2 * speed;
            }
        }
    }

    function circleMove() {
        ctx.clearRect(0, 0, totalWidth, totalHeight);
        updateDirections();
        drawCircle('orange');
    }

    setInterval(circleMove, 10);
})();
