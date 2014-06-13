function onGenerateTagCloud() {
	var minFontSize = document.getElementById('minFontSize').value,
		maxFontSize = document.getElementById('maxFontSize').value,
		tags = document.getElementById('tags').value.split(','),
		result = document.getElementById('result'),
		cloud = generateTagCloud(tags, minFontSize, maxFontSize);

	result = clearResultDiv(result);
	result.appendChild(cloud);

	result.style.border = "2px solid black";
	result.style.width = 400 + "px";
	result.style.padding = "5px";
}

function generateTagCloud(tags, minFont, maxFont) {
	var occurrences = countTagOccurrences(tags);

	var mostCommon = 0;
	var leastCommon = tags.length + 1;
	for (var word in occurrences) {
		if (mostCommon < occurrences[word]) {
			mostCommon = occurrences[word];
		}

		if (leastCommon > occurrences[word]) {
			leastCommon = occurrences[word];
		}
	}

	var fontsCount = mostCommon - leastCommon + 1;
	var oneStep = (maxFont - minFont) / fontsCount;
	var resultDiv = document.createElement('div');

	for (var word in occurrences) {
		var currSpan = document.createElement('span');
		var currSize = ((occurrences[word]) * oneStep);
		currSize += Number(minFont);
		currSpan.style.fontSize = currSize + "px";
		currSpan.style.color = getRandomColor();
		currSpan.innerHTML = word;
		resultDiv.appendChild(currSpan);
		resultDiv.innerHTML += " ";
	}

	return resultDiv;
}

function clearResultDiv(result) {
	while (result.firstChild) {
		result.removeChild(result.firstChild);
	}

	return result;
}

function countTagOccurrences(tags) {
	var occurrences = {};
	for (var i = 0; i < tags.length; i++) {
		var currWord = tags[i].toLowerCase().trim();

		if (!occurrences[currWord]) {
			occurrences[currWord] = 0;
		}

		occurrences[currWord]++;
	}

	return occurrences;
}

function getRandomColor() {
	return '#' + Math.floor(Math.random() * 16777215).toString(16);
}