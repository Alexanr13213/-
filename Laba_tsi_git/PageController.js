const database = require("./Database");

function getStartPage(request, response){
    try{
        response.render('StartPage');

    } catch(error) {
        console.log(error.stack);
        response.sendStatus(500);
    }
};

function getSearchPage (request, respons){
    try{
        respons.render('SearchPage');

    } catch(error) {
        console.log(error.stack);
        respons.sendStatus(500);
    }
};

async function getAddPage (request, respons){
    try{
        const marks = database.query("SELECT * FROM marks");
        respons.render('AddPage', {
            marks: marks.rows
       });
    } catch(error) {
        console.log(error.stack);
        respons.sendStatus(500);
    }
};

module.exports = {
    getStartPage, getSearchPage, getAddPage
};