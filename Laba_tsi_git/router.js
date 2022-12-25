const express = require("express");
const router = express.Router();
const path = require("node:path")
const multer = require("multer")


const memory_place = multer.diskStorage({
    destination: function (req, file, cb) {
        cb(null, '/LABA_TSI')
    },
    filename: function (req, file, cb) {
        cb(null, path.basename(file.originalname, path.extname(file.originalname)) + '-' + Date.now())
    }
})

const pageController = require("./PageController");
const noteController = require("./NoteController");

router.get('/', pageController.getStartPage);
router.get('/search', pageController.getSearchPage);
router.get('/add', pageController.getAddPage);

router.get('/LABA_TSI/:file',(req, res) => {
    var file = req.params.file;
    var fileLocation = path.join('/Desktop/asca.txt', file);
    res.download(fileLocation, file);
});

router.post('/add', noteController.getAddPage);
router.post('/search', multer({storage:memory_place}).array("filedata"), noteController.get_Search_Req);

module.exports = router;