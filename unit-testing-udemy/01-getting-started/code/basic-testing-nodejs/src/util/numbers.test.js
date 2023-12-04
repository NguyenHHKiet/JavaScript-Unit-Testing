import { expect, it } from "vitest";

import { transformToNumber } from "./numbers";

/*
về mặt kỹ thuật, Expect() không trả về đúng hay sai, 
thay vào đó, nó sẽ đưa ra lỗi nếu kỳ vọng không được đáp ứng. 
Người chạy thử coi các lỗi bị ném là các thử nghiệm thất bại 
và các thử nghiệm không đạt như đã đạt.
*/

it("should transform a string number to a number of type number", () => {
    const input = "1";

    const result = transformToNumber(input);

    expect(result).toBeTypeOf("number");
});

it("should transform a string number to a number of type number", () => {
    const input = "1";

    const result = transformToNumber(input);

    expect(result).toBe(+input);
});

it("should yield NaN for non-transformable values", () => {
    const input = "invalid";
    const input2 = {};

    const result = transformToNumber(input);
    const result2 = transformToNumber(input2);

    expect(result).toBeNaN();
    expect(result2).toBeNaN();
});
