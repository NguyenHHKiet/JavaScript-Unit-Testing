import fs from "fs";
import path from "path";

import { it, expect, describe, vi, beforeEach } from "vitest";
import { Window } from "happy-dom";

import { showError } from "./dom";

// Setting up a Virtual HTML Page
const htmlDocPath = path.join(process.cwd(), "index.html");
const htmlDocumentContent = fs.readFileSync(htmlDocPath).toString();

const window = new Window();
const document = window.document;
vi.stubGlobal("document", document);

beforeEach(() => {
    document.body.innerHTML = "";
    document.write(htmlDocumentContent);
});

it("should add an error paragraph to the id='errors' element", () => {
    showError("test");

    const errorEl = document.getElementById("errors");
    const errorParagraph = errorEl.firstElementChild;

    expect(errorParagraph).not.toBeNull();
});

it("should not contain an error paragraph initially", () => {
    const errorEl = document.getElementById("errors");
    const errorParagraph = errorEl.firstElementChild;

    expect(errorParagraph).toBeNull();
});

it("should output the provided message in the error paragraph", () => {
    const testErrorMessage = "Test Error Message";

    showError(testErrorMessage);

    const errorsEl = document.getElementById("errors");
    const errorParagraph = errorsEl.firstElementChild;

    expect(errorParagraph.textContent).toBe(testErrorMessage);
});
