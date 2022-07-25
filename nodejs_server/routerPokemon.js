const express = require('express');
const router = express.Router();
const db  = require('./dbConnection');

router.get('', function (req, res) {
    db.query('SELECT * FROM pokemon', function (error, results) {
        if (error) throw error;
        res.json(results);
    })
  });
  
  router.get('/:id', function (req, res) {
    db.query('SELECT * FROM pokemon WHERE id = ' + req.params.id, function (error, results) {
        if (error) throw error;
        if (!results.length) {
          res.status(404).send({
            msg: 'Pokemon not found!'
          })
        }
        else {
          res.json(results);
        }
        
    })
  });
  
  router.post('', function (req, res) {
    db.query("INSERT INTO pokemon (name, type, health, region) VALUES ('"+ req.body.name +"', '"+ req.body.type +"', '"+ req.body.health +"', '"+ req.body.region +"')", function (error, results) {
        if (error) {
          return res.status(400).send({
            msg: error
          });
        }
        return res.status(201).send({
          msg: 'Pokemon created!'
        });
    });
  });
  
  router.put('', function (req, res) {
    db.query("UPDATE pokemon SET name = '"+ req.body.name +"', type = '"+ req.body.type +"', health = '"+ req.body.health +"', region = '"+ req.body.region +"' WHERE id = '" + req.body.id + "'", function (error, results) {
      if (error) {
        return res.status(400).send({
          msg: error
        });
      }
      return res.status(200).send({
        msg: 'Pokemon updated!'
      });
    });
  });
  
  router.delete('/:id', function (req, res) {
    db.query('DELETE FROM pokemon WHERE id = ' + req.params.id, function (error, results) {
      if (error) {
        return res.status(400).send({
          msg: error
        });
      }
      return res.status(200).send({
        msg: 'Pokemon deleted!'
      });
    }); 
  });

  module.exports = router;