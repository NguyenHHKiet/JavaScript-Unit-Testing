import { HttpError } from "./errors.js";

const url = "https://react-http-6e69f-default-rtdb.firebaseio.com/testing.json";

export async function sendDataRequest(data) {
    console.log(data);
    const response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            "Access-Control-Allow-Origin": "*",
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
