const uri = '../../api/OderAPI';
var ListOders = [];


function GetOders() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Không lấy dc danh sách Loại', error));
}

function displayEditForm(id) {

    const item = ListCates.find(item => item.id === id);

    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-Status').value = item.status;
    document.getElementById('edit-Price').value = item.totalPrice;
    document.getElementById('edit-OderDate').value = item.oderDate;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemID = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemID, 10),
        name: document.getElementById('edit-name').value.trim()
    };
    fetch(`${uri}/${itemID}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => GetCategories())
        .catch(error => console.error('Khong update dc', error));
    closeInput();
    return false;
}
function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => GetCategories())
        .catch(error => console.error('Khong xoa dc', error));
}

function _displayItems(data) {


    const tBody = document.getElementById('ListOders');
    tBody.innerHTML = '';


    //_displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        //let isCompleteCheckbox = document.createElement('input');
        //isCompleteCheckbox.type = 'checkbox';
        //isCompleteCheckbox.disabled = true;
        //isCompleteCheckbox.checked = item.isComplete;
        var id = item.id;


        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);


        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let idNode = document.createTextNode(item.oderDate);
        td1.appendChild(idNode);

        let td2 = tr.insertCell(1);
        let nameNode = document.createTextNode(item.userId);
        td2.appendChild(nameNode);

        let td3 = tr.insertCell(2);
        let sttNode = document.createTextNode(item.status);
        td3.appendChild(sttNode);

        let td4 = tr.insertCell(3);
        let priceNode = document.createTextNode(item.totalPrice);
        td4.appendChild(priceNode);

        let td5 = tr.insertCell(4);
        td5.appendChild(editButton);

    });
    ListOders = data;
}