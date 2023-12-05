import { extractPostData, savePost } from "./posts/posts.js";
// import { storeData } from "./storeData.js";
import { showError } from "./util/dom.js";

const formElement = document.querySelector("form");

export async function submitFormHandler(event) {
    event.preventDefault();

    const formData = new FormData(formElement);
    try {
        const postData = extractPostData(formData);
        await savePost(postData);
        // await storeData();
    } catch (error) {
        showError(error.message);
    }
}

formElement.addEventListener("submit", submitFormHandler);
