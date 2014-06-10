(function() {
	'use strict'
	var svgNS = 'http://www.w3.org/2000/svg';
	var svg = document.createElementNS(svgNS, 'svg');
	svg.setAttribute('width', '400');
	svg.setAttribute('height', '350');
	svg.setAttribute('margin-left', '20px');
	svg.setAttribute('margin-top', '30px');
	document.body.appendChild(svg);

	var fontSizeBig = '40px',
		fontSizeSmall = '25px',
		tahoma = 'Tahoma',
		boldFont = 'bold',
		normalFont = 'normal',
		radius = '55',
		gray = '#3E3F37',
		black = '#282827',
		red = '#E23337',
		green = '#8EC74E',
		nodeColor = '#47493F';

	function createText(x, y, color, fontSize, fontFamily, fontWeight, innerText) {
		var text = document.createElementNS(svgNS, 'text');
		text.setAttribute('x', x);
		text.setAttribute('y', y);
		text.setAttribute('font-size', fontSize);
		text.setAttribute('fill', color);
		text.setAttribute('font-family', fontFamily);
		text.setAttribute('font-weight', fontWeight);
		text.innerHTML = innerText;
		svg.appendChild(text);
	}

	function createCircle(x, y, r, fillColor) {
		var circle = document.createElementNS(svgNS, 'circle');
		circle.setAttribute('cx', x);
		circle.setAttribute('cy', y);
		circle.setAttribute('r', r);
		circle.setAttribute('stroke', 'none');
		circle.setAttribute('fill', fillColor);
		svg.appendChild(circle);
	}

	function drawPath(d, fillColor, strokeColor, strokeWidth) {
		var curve = document.createElementNS(svgNS, 'path');
		curve.setAttribute('d', d);
		curve.setAttribute('fill', fillColor);
		curve.setAttribute('stroke', strokeColor);
		curve.setAttribute('stroke-width', strokeWidth);
		svg.appendChild(curve);
	}

	function drawPolygon(points, fillColor) {
		var curve = document.createElementNS(svgNS, 'polygon');
		curve.setAttribute('points', points);
		curve.setAttribute('fill', fillColor);
		svg.appendChild(curve);
	}

	createText('90', '105', gray, fontSizeBig, tahoma, boldFont, 'M');
	createText('95', '157', black, fontSizeBig, tahoma, boldFont, 'E');
	createText('93', '214', red, fontSizeBig, tahoma, boldFont, 'A');
	createText('93', '270', green, fontSizeBig, tahoma, boldFont, 'N');

	createCircle('200', '100', radius, gray);
	drawPath('M200 70 Q170 95 200 150', "#5EB14A", '#5EB14A', '3');
	drawPath('M200 70 Q230 95 200 150', "#449644", '#449644', '3');

	createCircle('200', '150', radius, black);
	createText('157', '150', '#FFFFFF', fontSizeSmall, tahoma, normalFont, 'express');

	createCircle('200', '204', radius, red);
	drawPath('M177 209 L 173 180 L 200 171 L 226 180 L 223 209', 'none', 'lightgrey', '3');
	drawPath('M190 204 L 200 181 L 210 204', 'none', 'lightgrey', '5');

	createCircle('200', '253', radius, green);

	// node js
	drawPolygon('162 243 172 248 172 263 165 260 165 253 162 251 159 253 159 260 152 263 152 248 162 243', nodeColor);
	drawPolygon('187 243 197 248 197 258 187 263 177 258 177 248', 'white');
	drawPolygon('212 243 215 245 215 231 222 235 222 260 212 266 202 260 202 250 212 243', nodeColor);
	createCircle('212', '255', '3', green);
	drawPolygon('239 243 249 248 249 252 242 255 236 255 244 261 239 266 229 260 229 248 239 243', nodeColor);
	createCircle('239', '254', '3', 'white');
})();