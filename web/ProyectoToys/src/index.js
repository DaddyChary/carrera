// Imports 
const express = require('express');
const morgan = require('morgan');
const ruta = require('./routes/routes.js');

// Instancias
const app = express();
// settings
const PORT = 2000;

app.use(morgan("dev"));
app.use(express.json());
app.use(ruta)


app.listen(PORT, () => {
    console.log(`Servidor Express escuchando en el puerto http://localhost:${PORT}`);
});