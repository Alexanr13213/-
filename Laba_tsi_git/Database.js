const Pool = require('pg').Pool;
const pool = new Pool({
    User: "Alexandr",
    password: '1793',
    host: "localhost",
    port: 5432,
    database: 'notelistok'
})

module.exports = pool;