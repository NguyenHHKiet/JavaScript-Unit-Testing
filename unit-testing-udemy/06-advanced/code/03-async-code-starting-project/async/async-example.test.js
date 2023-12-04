import { it, expect } from "vitest";
import { generateToken, generateTokenPromise } from "./async-example";

it("should generate a token value", () => {
    const testUserEmail = "testuser@example.com";
    generateToken(testUserEmail, (err, token) => {
        // expect(token).toBeDefined();
        try {
            expect(token).toBeDefined();
            // expect(token).toBe(2);
            done();
        } catch (error) {
            done(error);
        }
    });
});

it("should generate a token value", async () => {
    const testUserEmail = "test@test.com";

    const token = await generateTokenPromise(testUserEmail);

    // Even though the test worked as expected in the previous lecture, you should actually return the promise assertion in your tests:
    return expect(token).toBeDefined();
});
