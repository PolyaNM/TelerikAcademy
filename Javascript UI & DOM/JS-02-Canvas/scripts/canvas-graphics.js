(function () {
    var canvasCtx = document.getElementById("the-canvas").getContext("2d"),

    // colors used for drawing the graphics
    pink = '#975B5B',
    black = '#000000',
    lightCyan = '#90CAD7',
    darkCyan = '#194B56', // person's face - stroke
    blue = '#396693',
    lightBlue = '#468B9C'; // bike - stroke

    // ======= HOUSE =======
    // outlines of the house
    canvasCtx.strokeStyle = black;
    canvasCtx.fillStyle = pink;
    canvasCtx.lineWidth = 2.5;

    canvasCtx.beginPath();
    canvasCtx.moveTo(600, 200);
    canvasCtx.lineTo(745, 45);
    canvasCtx.lineTo(890, 200);
    canvasCtx.lineTo(890, 420);
    canvasCtx.lineTo(600, 420);
    canvasCtx.lineTo(600, 200);
    canvasCtx.stroke();
    canvasCtx.fill();

    canvasCtx.lineTo(890, 200);
    canvasCtx.stroke();

    // windows
    function createWindow(x, y) {
        canvasCtx.beginPath();
        canvasCtx.fillStyle = black;
        canvasCtx.strokeStyle = pink;
        canvasCtx.fillRect(x, y, 106, 70);

        canvasCtx.moveTo(x + 53, y);
        canvasCtx.lineTo(x + 53, y + 70);
        canvasCtx.moveTo(x, y + 35);
        canvasCtx.lineTo(x + 106, y + 35);
        canvasCtx.stroke();
        canvasCtx.closePath();
    }

    createWindow(620, 225);
    createWindow(765, 225);
    createWindow(765, 320);

    // chimney
    canvasCtx.beginPath();
    canvasCtx.strokeStyle = black;
    canvasCtx.fillStyle = pink;
    canvasCtx.moveTo(800, 160);
    canvasCtx.lineTo(800, 80);
    canvasCtx.arcTo(815, 70, 830, 80, 28);
    canvasCtx.lineTo(830, 160);
    canvasCtx.fill();
    canvasCtx.stroke();
    canvasCtx.moveTo(830, 80);
    canvasCtx.arcTo(815, 90, 800, 80, 28);
    canvasCtx.stroke();

    // door
    canvasCtx.beginPath();
    canvasCtx.moveTo(630, 420);
    canvasCtx.lineTo(630, 345);
    canvasCtx.arcTo(670, 300, 710, 345, 52);
    canvasCtx.lineTo(710, 420);
    canvasCtx.closePath();
    canvasCtx.fill();
    canvasCtx.moveTo(670, 420);
    canvasCtx.lineTo(670, 325);
    canvasCtx.stroke();

    // door knobs
    canvasCtx.beginPath();
    canvasCtx.arc(660, 390, 4, 0, 2 * Math.PI);
    canvasCtx.stroke();

    canvasCtx.beginPath();
    canvasCtx.arc(680, 390, 4, 0, 2 * Math.PI);
    canvasCtx.stroke();

    // ======= BIKE =======
    canvasCtx.strokeStyle = lightBlue;
    canvasCtx.fillStyle = lightCyan;

    function createWheel(x, y) {
        canvasCtx.beginPath();
        canvasCtx.arc(x, y, 60, 0, 2 * Math.PI);
        canvasCtx.fill();
        canvasCtx.stroke();
    }

    createWheel(200, 500);
    createWheel(430, 500);

    // bike frame
    canvasCtx.beginPath();
    canvasCtx.moveTo(250, 400);
    canvasCtx.lineTo(300, 500);
    canvasCtx.lineTo(200, 500);
    canvasCtx.lineTo(265, 420);
    canvasCtx.lineTo(410, 420);
    canvasCtx.lineTo(300, 500);
    canvasCtx.stroke();

    // small wheel
    canvasCtx.beginPath();
    canvasCtx.arc(300, 500, 17, 0, 2 * Math.PI);
    canvasCtx.stroke();

    // pedals
    canvasCtx.beginPath();
    canvasCtx.moveTo(323, 525);
    canvasCtx.lineTo(310, 512);
    canvasCtx.moveTo(288, 487);
    canvasCtx.lineTo(276, 474);
    // seat
    canvasCtx.moveTo(225, 400);
    canvasCtx.lineTo(275, 400);
    //front lines
    canvasCtx.moveTo(430, 500);
    canvasCtx.lineTo(405, 390);
    canvasCtx.lineTo(440, 360);
    canvasCtx.moveTo(405, 390);
    canvasCtx.lineTo(360, 395);
    canvasCtx.stroke();

    // ======= PERSON =======
    canvasCtx.strokeStyle = darkCyan;
    canvasCtx.fillStyle = lightCyan;

    // head
    canvasCtx.save();
    canvasCtx.beginPath();
    canvasCtx.scale(1, 0.9);
    canvasCtx.arc(260, 290, 70, 0, 2 * Math.PI);
    canvasCtx.fill();
    canvasCtx.stroke();
    canvasCtx.closePath();
    canvasCtx.restore();

    // nose 
    canvasCtx.beginPath();
    canvasCtx.moveTo(250, 265);
    canvasCtx.lineTo(235, 265);
    canvasCtx.lineTo(247, 235);
    canvasCtx.stroke();

    // mouth
    canvasCtx.save(); // save the current context
    canvasCtx.beginPath();
    canvasCtx.lineWidth = 4;
    canvasCtx.setTransform(1, 0.2, 0, 0.35, 0, 160); // transformin the current context
    canvasCtx.arc(245, 235, 25, 0, 2 * Math.PI);
    canvasCtx.stroke();
    canvasCtx.closePath();
    canvasCtx.restore(); // restore the context

    // eyes
    function drawEyes(x, y) {
        canvasCtx.save();
        canvasCtx.beginPath();
        canvasCtx.scale(1, 0.6);
        canvasCtx.arc(x, y, 12, 0, 2 * Math.PI);
        canvasCtx.stroke();
        canvasCtx.closePath();
        canvasCtx.restore();
    }

    function drawPupils(x, y) {
        canvasCtx.save();
        canvasCtx.beginPath();
        canvasCtx.scale(0.5, 1);
        canvasCtx.arc(x, y, 6, 0, 2 * Math.PI);
        canvasCtx.stroke();
        canvasCtx.fill();
        canvasCtx.closePath();
        canvasCtx.restore();
    }

    canvasCtx.fillStyle = darkCyan;
    drawEyes(220, 400);
    drawEyes(270, 400);
    drawPupils(430, 240);
    drawPupils(530, 240);

    // hat
    canvasCtx.fillStyle = blue;
    canvasCtx.strokeStyle = black;

    // bottom ellipse
    canvasCtx.save();
    canvasCtx.beginPath();
    canvasCtx.lineWidth = 10;
    canvasCtx.scale(1, 0.2);
    canvasCtx.arc(250, 1030, 80, 0, 2 * Math.PI);
    canvasCtx.stroke();
    canvasCtx.fill();
    canvasCtx.closePath();
    canvasCtx.restore();

    // the rest
    canvasCtx.beginPath();
    canvasCtx.moveTo(210, 120);
    canvasCtx.lineTo(210, 193);
    canvasCtx.arcTo(250, 210, 295, 193, 115);
    canvasCtx.lineTo(295, 120);
    canvasCtx.closePath();
    canvasCtx.fill();
    canvasCtx.stroke();

    // top ellipse
    canvasCtx.save();
    canvasCtx.beginPath();
    canvasCtx.lineWidth = 10;
    canvasCtx.scale(1, 0.35);
    canvasCtx.arc(253, 350, 40, 0, 2 * Math.PI, true);
    canvasCtx.stroke();
    canvasCtx.fill();
    canvasCtx.closePath();
})();
