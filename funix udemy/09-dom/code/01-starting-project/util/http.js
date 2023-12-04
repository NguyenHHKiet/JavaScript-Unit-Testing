import { HttpError } from "./errors.js";

export async function sendDataRequest(data) {
    console.log(data);
    const response = await fetch("https://jsonplaceholder.typicode.com/posts", {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
    });

    const responseData = await response.json();

    if (!response.ok) {
        throw new HttpError(
            response.status,
            "Sending the request failed.",
            responseData,
        );
        // throw new Error('Error!');
    }

    return responseData;
}
