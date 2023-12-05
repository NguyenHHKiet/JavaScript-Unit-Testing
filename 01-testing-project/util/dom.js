export function showError(message) {
    const errorContainerElement = document.getElementById("errors");
    const errorMessageElement = document.createElement("p");
    errorMessageElement.textContent = message;
    errorMessageElement.classList = "badge text-bg-danger m-0 mt-2";
    errorContainerElement.innerHTML = "";
    errorContainerElement.append(errorMessageElement);
}
