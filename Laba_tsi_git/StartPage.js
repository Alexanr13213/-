const add_button = document.getElementsByClassName("startPage_button")[0];
const search_button = document.getElementsByClassName("startPage_button")[1];

add_button.addEventListener('click', addButtonClick);
search_button.addEventListener('click', searchButtonClick);

function addButtonClick(){
    fetch('/add', {
        method: 'GET',
    }) 
    .then(response => {
        window.location.href = '/add'
    });
}

function searchButtonClick(){
    fetch('/search', {
        method: 'GET',
    }) 
    .then(response => {
        window.location.href = '/search'
    });
}