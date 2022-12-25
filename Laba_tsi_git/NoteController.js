
const database = require("./Database");

async function getAddPage(request, respons){
    try{
        let filedata = request.files;
        let files = [];
        for(i = 0; i < filedata.length; i++){
            let str = filedata[i].filename;
            files.push(str);
        }
        await database.query("INSERT INTO notes VALUES(DEFAULT, $1, $2, $3, $4)", [request.body.note_name, request.body.note, files, request.body.ChooseMarks]);
        respons.sendStatus(200);

    } catch(error) {
        console.log(error.stack);
        respons.sendStatus(500);
    }
};

async function get_Search_Req(request, respons){
    try{
        let selectType = request.body.sel_val; 
        if(selectType == "по метке"){
            let notes = await database.query("SELECT * FROM public.notes WHERE $1 = ANY(selected_marks)", [request.body.req_val]);
            respons.json(notes.rows)
        } else if(selectType == "по слову в заголовке"){
            let notes = await database.query("SELECT * FROM public.notes WHERE public.notes.note ILIKE '%' || $1 || '%'", [request.body.req_val]);
            respons.json(notes.rows)
        } else if(selectType == "по слову в тексте"){
            let notes = await database.query("SELECT * FROM public.notes WHERE public.notes.note_text ILIKE '%' || $1 || '%'", [request.body.req_val]);
            respons.json(notes.rows)
        }

    } catch(error) {
        console.log(error.stack);
        respons.sendStatus(500);
    }
};

module.exports = {
    getAddPage, get_Search_Req
};