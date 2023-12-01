import { it, expect, beforeAll, beforeEach, afterAll, afterEach } from "vitest";
import { User } from "./hooks";

const testEmail = "test@test.com";
let user;

beforeAll(() => {
    user = new User(testEmail);
    console.log("beforeAll()");
});
beforeEach(() => {
    user = new User(testEmail);
    console.log("beforeEach()");
});
afterEach(() => {
    console.log("afterEach()");
});
afterAll(() => {
    console.log("afterAll()");
});

// Với .concurrent bạn cũng có thể thực thi hành vi này bên trong các tệp riêng lẻ
// (tức là các thử nghiệm nằm trong một và cùng một tệp được thực thi đồng thời).

// Việc thực hiện đồng thời có thể giảm lượng thời gian mà các bài kiểm tra của bạn cần thực hiện.
// Nhược điểm của việc thực thi đồng thời là các thử nghiệm thực hiện các thao tác trạng thái xung đột(toàn cầu) có thể gây trở ngại lẫn nhau.

it.concurrent("should update the email", () => {
    const newTestEmail = "test2@test.com";

    user.updateEmail(newTestEmail);

    expect(user.email).toBe(newTestEmail);
});

it.concurrent("should have an email property", () => {
    expect(user).toHaveProperty("email");
});

it.concurrent("should store the provided email value", () => {
    expect(user.email).toBe(testEmail);
});

it.concurrent("should clear the email", () => {
    user.clearEmail();

    expect(user.email).toBe("");
});

it.concurrent(
    "should still have an email property after clearing the email",
    () => {
        user.clearEmail();

        expect(user).toHaveProperty("email");
    },
);
