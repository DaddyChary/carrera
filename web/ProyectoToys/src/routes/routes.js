const { Router } = require('express');
const ruta = Router();
const categoriasRoutes = require('./categorias.routes');
const marcasRoutes = require('./marcas.routes');
const proveedoresRoutes = require('./proveedores.routes');
const juguetesRoutes = require('./juguetes.routes');
const ingresosRoutes = require('./ingresos.routes');
const egresosRoutes = require('./egresos.routes');
const inventarioRoutes = require('./inventario.routes');

ruta.use('/inventario', inventarioRoutes);
ruta.use('/egresos', egresosRoutes);
ruta.use('/ingresos', ingresosRoutes);
ruta.use('/juguetes', juguetesRoutes);
ruta.use('/proveedores', proveedoresRoutes);
ruta.use('/categorias', categoriasRoutes);
ruta.use('/marcas', marcasRoutes);

ruta.get('/', (req, res) => {
    res.send('¡Bienvenido a la pagina principal!');
});

ruta.get('/about', (req, res) => {
    res.send('¡About!');
});

module.exports = ruta;