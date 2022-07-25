const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const morgan = require('morgan');
const db = require('./dbConnection');
const authRouter = require('./routerAuth');
const pokemonRouter = require('./routerPokemon');
const swaggerUI = require("swagger-ui-express");
const swaggerDocument = require('./swagger.json');


app.use(bodyParser.json());
app.use(morgan('short'));
app.use('/auth', authRouter);
app.use('/pokemon', pokemonRouter);

app.get("/swagger.json", (req, res) => res.json(swaggerDocument));
app.use("/api-docs", swaggerUI.serve, swaggerUI.setup(swaggerDocument));

app.listen(3000, () => {
    console.log('Listening on port 3000');
});