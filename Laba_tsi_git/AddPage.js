const add_Mark_Button = document.getElementsByClassName("add_mark")[0];
const add_Note_Button = document.getElementsByClassName("form_button")[0];
const home_button = document.getElementsByClassName("home_button")[0];
const form = document.getElementsByClassName("form")[0];
const textarea = document.querySelector("textarea"); 

const ul = document.querySelector("ul");

let mark = [];
let choosenMarks = [];

add_Mark_Button.addEventListener('click', addMarksButtonClick);
add_Note_Button.addEventListener('click', addNoteButtonClick)
home_button.addEventListener('click', goHome);


function goHome(){
    fetch('/', {
        method: 'GET'
    }) .then(response => {
        
        window.location.href = '/'
    });
}

function chooseMark(e){
    let mark = e.target.textContent;
    if (!choosenMarks.includes(mark)){
        choosenMarks.push(mark);
    } else {
        choosenMarks.splice(choosenMarks.indexOf(mark), 1);
    }
    e.target.classList.toggle('green');
}

function addDefaultMarks(){
    mark = document.querySelectorAll("li");
    
    for(i=0;i<mark.length;i++){
        mark[i].addEventListener('click', chooseMark);
        mark.push(mark[i].innerHTML);
    }
}

function createMark() {
    
    let liTag = document.createElement('li');
    liTag.innerHTML = mark[mark.length-1];
    liTag.addEventListener('click', chooseMark);
    ul.insertBefore(liTag, ul.lastChild.previousSibling)
}

function inputMark(e){
    if(e.key == "Enter"){
        e.preventDefault();
        let mark = e.target.value.replace(/\s+/g, ' ');
        if(mark.length > 1 && !mark.includes(mark)){
            mark.push(mark);
            e.target.remove();
            createMark();
        }
    }
}

async function addMarksButtonClick(e){
    let inputTag = document.createElement('input');
    inputTag.className = 'mark_input'
    
    ul.insertBefore(inputTag, ul.lastChild.previousSibling);
    input_ = ul.getElementsByClassName("mark_input")[0];
    input_.addEventListener('keyup', inputMark);
}

function addNoteButtonClick(e){
    
    let form = document.getElementsByClassName("form")[0];
    let formData = new FormData(form);
    for(let i = 0; i < choosenMarks.length; i++){
        formData.append("ChooseMarks[]", choosenMarks[i]);
    }
    let values = Object.fromEntries(formData.entries());
    if(form.checkValidity()){
        form.submit();
        fetch('/add', {
            method: 'POST',
            body: formData
        }) 
    }
}
