(function(){
    'use strict'
   var paper = Raphael(50, 10, 700, 700);

   function drawSpiral(centerX, centerY, a, b) {
        var spiralPoints = 'M' + centerX + ' ' + centerY;

        for (var i = 0; i < 300; i++) {
            var angle = 0.1 * i,
            // Archimedian spiral equation r = a + b * angle;
            // a - the offset from the center
            // b - the distance between turnings
            x = centerX + (a + b * angle) * Math.cos(angle),         
            y = centerY + (a + b * angle) * Math.sin(angle);

            spiralPoints += ' L' + x + ' ' + y;
         }

        var spiral = paper.path(spiralPoints)
            .attr({
            stroke: 'yellowgreen',
            'stroke-width': 8
        })
            .animate({
                opacity: 0.2,
                'stroke-width': 1,
                stroke: 'yellow',
                callback: function(){
                    spiral.animate({
                        stroke:'darkblue',
                        opacity: 1,
                        'stroke-width': 4
                    }, 2000);
                }
            }, 2000)
    }
	drawSpiral(300, 300, 0, 8);
})();