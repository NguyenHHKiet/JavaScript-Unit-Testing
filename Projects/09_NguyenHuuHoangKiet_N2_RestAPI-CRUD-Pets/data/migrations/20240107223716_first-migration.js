exports.up = function (knex) {
    return knex.schema.createTable("pets", (tbl) => {
        tbl.increments("id").primary();
        tbl.string("name", 100).notNullable();
        tbl.integer("weight").notNullable();
        tbl.string("color", 100).notNullable();
    });
};

exports.down = function (knex) {
    return knex.schema.dropTableIfExists("pets");
};
