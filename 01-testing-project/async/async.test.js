import { expect, it } from "vitest";

import { generateToken, generateTokenPromise } from "./async";

it("should generate a token value", (done) => {
    const testUserEmail = "test@test.com";

    generateToken(testUserEmail, (err, token) => {
        // expect(token).toBeDefined();

        try {
            expect(token).toBeDefined();
            // expect(token).toBe(2);
            done();
        } catch (err) {
            done(err);
        }
    });
});

it("should generate a token value promise", () => {
    const testUserEmail = "test@test.com";

    expect(generateTokenPromise(testUserEmail)).resolves.toBeDefined();
});

it("should generate a token value processed asynchronously", async () => {
    const testUserEmail = "test@test.com";

    const token = await generateTokenPromise(testUserEmail);

    expect(token).toBeDefined();
});
