const express = require("express");
const router = require("./router");
const app = express();
const bodyParser = require('body-parser');

app.use('/',router);
app.use(bodyParser.json());
app.use(express.static('public'));
app.set('view engine', 'ejs');
app.listen(5000);