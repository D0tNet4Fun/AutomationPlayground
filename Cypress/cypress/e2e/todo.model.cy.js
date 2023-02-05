/// <reference types="cypress" />

import { todoPage } from "../../model/todoPage.js";

describe('todo using model', () => {
  it('passes', () => {
    todoPage.open();
    todoPage.listItems().first().should('have.text', 'Pay electric bill')
    todoPage.listItems().last().should('have.text', 'Walk the dog')
    todoPage.listItems().should('have.length', 2)
  })
})