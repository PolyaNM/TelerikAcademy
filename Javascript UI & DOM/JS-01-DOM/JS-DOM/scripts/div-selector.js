(function () {
    'use strict'
    function getDivsViaQuerySelectorAll() {
        return document.querySelectorAll('div>div');
    }

    function getDivsViaGetElementsByTagName() {
        var allDivs = document.getElementsByTagName('div'),
            liveDivList = [];

        for (var i = 0, len = allDivs.length; i < len; i++) {
            if (allDivs[i].parentElement instanceof HTMLDivElement) {
                liveDivList.push(allDivs[i]);
            }
        }

        return liveDivList;
    }

    console.log(getDivsViaQuerySelectorAll());
    console.log(getDivsViaGetElementsByTagName());
})();

