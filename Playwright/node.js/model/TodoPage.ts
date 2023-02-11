import { Page } from "playwright-core";
import { PageBase } from "./PageBase";

export class TodoPage extends PageBase {
  constructor(page: Page) {
    super(page, 'https://example.cypress.io/todo');
  };

  get list() {
    return this.page.locator('css=.todo-list li');
  }
};