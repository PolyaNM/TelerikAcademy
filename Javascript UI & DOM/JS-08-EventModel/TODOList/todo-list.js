function onCreateTODOList() {
    'use strict'
    var toDoList = document.getElementById('toDoList');

    var btnAdd = document.getElementById('btnAdd');
    btnAdd.addEventListener('click', function () {
        var newItem = document.createElement('li'),
            checkboxItem = document.createElement('input'),
            content = document.getElementById('text');

        checkboxItem.type = 'radio';
        checkboxItem.className = 'checked';
        // checkboxItem.name = 'selected'; - If we want to allow selecting only one element, not multiple
        newItem.appendChild(checkboxItem);
        newItem.appendChild(document.createTextNode(content.value));
        toDoList.appendChild(newItem);

        content.value = '';
    });

    var btnDelete = document.getElementById('btnDelete');
    btnDelete.addEventListener('click', function () {
        var selectedList = toDoList.querySelectorAll('.checked');
        for (var i = 0; i < selectedList.length; i++) {
            if (selectedList[i].checked) {
                selectedList[i].parentElement.parentElement.removeChild(selectedList[i].parentElement);
            }
        }
    });

    var btnHide = document.getElementById('btnHide');
    btnHide.addEventListener('click', function () {
        var selectedList = toDoList.querySelectorAll('.checked');
        for (var i = 0; i < selectedList.length; i++) {
            if (selectedList[i].checked) {
                // when we use commands HIDE and DELETE in this order - the delete command will delete both the hidden 
                // and the newly checked items. To prevent this we have to uncheck the hidden items.
				selectedList[i].checked = false; 
                selectedList[i].parentElement.style.display = 'none';
            }
        }
    });

    var btnShow = document.getElementById('btnShow');
    btnShow.addEventListener('click', function () {
        var liList = toDoList.querySelectorAll('li');
        for (var i = 0; i < liList.length; i++) {
            if (liList[i].style.display === 'none') {
                liList[i].style.display = 'list-item';
            }
        }
    });
}