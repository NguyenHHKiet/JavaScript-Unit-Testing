exports.seed = function (knex) {
    // Deletes ALL existing entries
    return knex("pets")
        .truncate()
        .then(function () {
            // Inserts seed entries
            return knex("pets").insert([
                { name: "Cooper", weight: 20, color: "red" },
                { name: "Molly", weight: 40, color: "yellow" },
                { name: "Charlie", weight: 4, color: "purple" },
            ]);
        });
};
