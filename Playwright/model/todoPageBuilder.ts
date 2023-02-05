import { Page } from "playwright-core";

export const todoPageBuilder = (page: Page) => {
  return {
    open: () => page.goto('https://example.cypress.io/todo'),
    list: page.locator('css=.todo-list li'),
  };
};