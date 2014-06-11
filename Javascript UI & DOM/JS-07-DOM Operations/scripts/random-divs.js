function getRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

function getRandomColor() {
    return '#' + Math.floor(Math.random() * 16777215).toString(16);
}

function onGenerateDivs() {
    var numberOfDivs = document.getElementById('number').value,
        result = document.getElementById('result');

    // removes the previously generated divs in the result div
    while (result.firstChild) {
        result.removeChild(result.firstChild);
    }

    var frag = document.createDocumentFragment();

    for (var i = 0; i < numberOfDivs; i++) {
        var div = document.createElement('div');

        div.style.width = getRandomNumber(20, 100) + 'px';
        div.style.height = getRandomNumber(20, 100) + 'px';

        div.style.backgroundColor = getRandomColor();
        div.style.color = getRandomColor();

        div.style.position = 'absolute';
        div.style.top = getRandomNumber(25, screen.height - 300) + 'px';
        div.style.left = getRandomNumber(0, screen.width - 150) + 'px';

        div.innerHTML = '<strong>div</strong>';
        div.style.textAlign = 'center';

        div.style.borderStyle = ['solid', 'dashed', 'dotted', 'groove', 'inset', 'outset'][getRandomNumber(0, 5)];
        div.style.borderRadius = getRandomNumber(0, 50) + '%';
        div.style.borderWidth = getRandomNumber(0, 20) + 'px';
        div.style.borderColor = getRandomColor();

        frag.appendChild(div);
    }

    result.appendChild(frag);
}